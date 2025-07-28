using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 北風資料庫V1
{
    internal class Sql
    {
        public SqlConnection mySqlConnection;
        public SqlDataAdapter myAdapter;
        public DataSet myDataSet;
        public DataTable myDataTable;

        public Sql()
        {
            mySqlConnection = new SqlConnection(北風資料庫V1.Properties.Settings.Default.NorthWind);
            myAdapter = new SqlDataAdapter();
            myDataSet = new DataSet();
            myDataTable = new DataTable();
        }
        // 客戶名單(Key => string)
        public Dictionary<string, string> SelectCustomers(string myQurey)
        {
            Dictionary<string, string> myCusDict = new Dictionary<string, string>();
            SqlCommand mycmd = new SqlCommand(myQurey, mySqlConnection);

            mySqlConnection.Open();
            SqlDataReader myread = mycmd.ExecuteReader();
            while (myread.Read())
            {
                myCusDict.Add((string)myread[0], (string)myread[1]);
            }
            mySqlConnection.Close();
            return myCusDict;
        }
        // 搜尋comboBox (key => int)
        public Dictionary<int, string> SelectAll(string myQuery)
        {
            Dictionary<int, string> myDict = new Dictionary<int, string>();
            SqlCommand mycmd = new SqlCommand(myQuery, mySqlConnection);

            // 這一個方法是逐行讀取並加入，字典並回傳。
            mySqlConnection.Open();
            SqlDataReader myRead = mycmd.ExecuteReader();
            while (myRead.Read())
            {
                myDict.Add((int)myRead[0], (string)myRead[1]);
            }
            mySqlConnection.Close();
            return myDict;
        }
        public DataTable SelectProdct_UniPrice(int productId, string productName)
        {
            string mySelectQuery = "SELECT UnitPrice FROM Products WHERE ProductID = @PrductId AND  ProductName = @ProductName";
            myAdapter.SelectCommand = new SqlCommand(mySelectQuery, mySqlConnection);
            myAdapter.SelectCommand.Parameters.AddWithValue("@PrductId", productId);
            myAdapter.SelectCommand.Parameters.AddWithValue("@ProductName", productName);
            myAdapter.Fill(myDataTable);
            return myDataTable;
        }
        // (以被送出訂單取代)新增訂單號
        public DataTable AddOrderID(string CustomerID, int EmployeeID, string OrderDate, string RequiredDate, int ShipVia)
        {
            string myOrderIDQuery = "INSERT INTO Orders( CustomerID,EmployeeID, OrderDate,RequiredDate,ShipVia) VALUES(@CustomerID,@EmployeeID, @OrderDate,@RequiredDate,@ShipVia);" +
                "SELECT OrderID, CustomerID, EmployeeID, OrderDate, RequiredDate, ShipVia FROM Orders WHERE OrderID = SCOPE_IDENTITY();";
            using (myAdapter.SelectCommand = new SqlCommand(myOrderIDQuery, mySqlConnection))
            {
                myAdapter.SelectCommand.Parameters.AddWithValue("@CustomerID", CustomerID);
                myAdapter.SelectCommand.Parameters.AddWithValue("@EmployeeID", EmployeeID);
                myAdapter.SelectCommand.Parameters.AddWithValue("@OrderDate", OrderDate);
                myAdapter.SelectCommand.Parameters.AddWithValue("@RequiredDate", RequiredDate);
                myAdapter.SelectCommand.Parameters.AddWithValue("@ShipVia", ShipVia);

                mySqlConnection.Open();
                myAdapter.Fill(myDataTable);
                mySqlConnection.Close();
            }
            return myDataTable;
        }
        // 送出訂單
        public int SeneOrderAndDetail(List<ShipItem> ShipCart, string CustomerID, int EmployeeID, string OrderDate, string RequiredDate, int ShipVia)
        {
            try
            {
                mySqlConnection.Open();

                string myOrderIDQuery = "INSERT INTO Orders( CustomerID,EmployeeID, OrderDate,RequiredDate,ShipVia)" +
                    "VALUES(@CustomerID,@EmployeeID, @OrderDate,@RequiredDate,@ShipVia);" +
                        "SELECT SCOPE_IDENTITY();";
                SqlCommand cmd = new SqlCommand(myOrderIDQuery, mySqlConnection);

                cmd.Parameters.AddWithValue("@CustomerID", CustomerID);
                cmd.Parameters.AddWithValue("@EmployeeID", EmployeeID);
                cmd.Parameters.AddWithValue("@OrderDate", OrderDate);
                cmd.Parameters.AddWithValue("@RequiredDate", RequiredDate);
                cmd.Parameters.AddWithValue("@ShipVia", ShipVia);
                int orderID = Convert.ToInt32(cmd.ExecuteScalar());
                foreach (var item in ShipCart)
                {
                    string insertDetailQuery = @"INSERT INTO [Order Details] (OrderID, ProductID, UnitPrice, Quantity) 
                                             VALUES (@OrderID, @ProductID, @UnitPrice, @Quantity)";
                    SqlCommand insertCmd = new SqlCommand(insertDetailQuery, mySqlConnection);
                    insertCmd.Parameters.AddWithValue("@OrderID", orderID);
                    insertCmd.Parameters.AddWithValue("@ProductID", item.訂單編號);
                    insertCmd.Parameters.AddWithValue("@Quantity", item.Quantity);
                    insertCmd.Parameters.AddWithValue("@UnitPrice", item.UniPrice);
                    insertCmd.ExecuteNonQuery(); // 這一段是執行上面的程式的，回傳變動列數
                }

                mySqlConnection.Close();
                return orderID;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"訂單新增錯誤{ex}");
                mySqlConnection.Close();
                return -1;
            }
        }
        // 刪除訂單
        public bool DeleteOrder(int OrderID)
        {
            string deleteOrderDetailsQuery = "DELETE FROM [Order Details] WHERE OrderID = @OrderID";
            string deleteOrdersQuery = "DELETE FROM Orders WHERE OrderID = @OrderID";

            bool isDeleted = false;

            try
            {
                mySqlConnection.Open();
                SqlTransaction transaction = mySqlConnection.BeginTransaction();

                using (SqlCommand cmd1 = new SqlCommand(deleteOrderDetailsQuery, mySqlConnection, transaction))
                using (SqlCommand cmd2 = new SqlCommand(deleteOrdersQuery, mySqlConnection, transaction))
                {
                    cmd1.Parameters.AddWithValue("@OrderID", OrderID);
                    cmd2.Parameters.AddWithValue("@OrderID", OrderID);

                    int affectedRow1 = cmd1.ExecuteNonQuery();
                    int affectedRow2 = cmd2.ExecuteNonQuery();

                    transaction.Commit();

                    isDeleted = affectedRow2 > 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"刪除訂單失敗{ex.Message}");
                try { mySqlConnection.Close(); } catch { } 
            }
            finally
            {
                mySqlConnection.Close();
            }
            return isDeleted;
        }
        // 搜尋訂單
        public DataTable SelectOrder(int OrderID)
        {
            string SelectQuery = @"SELECT orde.OrderID 商品編號, pro.ProductName 商品, orde.UnitPrice 單價, orde.Quantity 數量, ord.OrderDate 訂購日期, ord.RequiredDate 需求日期, ord.CustomerID 客戶ID, ord.EmployeeID 業務ID, ord.ShipVia 航運代號
                            FROM [Order Details] orde JOIN Orders ord ON orde.OrderID = ord.OrderID
                            JOIN Products pro ON orde.ProductID = pro.ProductID
                            WHERE orde.OrderID = @OrderID";
            myAdapter.SelectCommand = new SqlCommand(SelectQuery, mySqlConnection);
            myAdapter.SelectCommand.Parameters.AddWithValue("@OrderID", OrderID);
            myAdapter.Fill(myDataTable);
            return myDataTable;
        }
        // 更新訂單
        public void UpdateOrder()
        {
            // 目前問題 該依造表單上的textBox 上的數值變動嗎
            // 嘗試可以在dataGridView上更改數值,
            // 但textBox上沒有設定更動
            try
            {
                // 可能更動 Orders 或 Order Details
                string updateQuer = "UPDATE ";

                using (SqlCommand myCmd = new SqlCommand(updateQuer, mySqlConnection))
                {
                    mySqlConnection.Open();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"錯誤代碼:{ex.Message}");
            }
        }
        // 商品列表
        public DataTable ProductList()
        {
            string myProductlist = "SELECT pro.ProductID, pro.ProductName, pro.UnitPrice FROM Products pro ";
            myAdapter.SelectCommand = new SqlCommand(myProductlist, mySqlConnection);
            myAdapter.Fill(myDataTable);
            return myDataTable;
        }
    }
}
