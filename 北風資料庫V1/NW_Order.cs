using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace 北風資料庫V1
{
    public partial class NW_Order : Form
    {
        public NW_Order()
        {
            InitializeComponent();
        }
        // 購物車
        List<ShipItem> ShippingCart;

        private void NW_Order_Load(object sender, EventArgs e)
        {
            ComboBoxLoad();
            MyProductView();
            InitDataGird3();
            buttonEnable(false, false, false);
            ShippingCart = new List<ShipItem>();
            OrderDateTextBox.Text = DateTime.Now.ToString("yyyy-MM-dd");
        }
        private void InitDataGird3()
        {
            // 已自訂的模板實體化
            ShipCart newCart = new ShipCart();
            dataGridView3.DataSource = newCart.myCart();
        }
        // ComboBox的 轉換主換顯示 函式
        private void ComboBoxLoad()
        {
            string mySelectEmpQuery = "SELECT EmployeeID ID, LastName + ' ' + FirstName 員工 FROM Employees";
            string mySelectCustomerQuery = "SELECT cus.CustomerID, cus.CompanyName FROM Customers cus";
            string mySelectProductQuery = "SELECT ProductID, ProductName FROM Products ";
            string mySelectShipCompany = "SELECT ShipperID, CompanyName FROM Shippers";
            Sql mysql = new Sql();
            comboBox2.DataSource = new BindingSource(mysql.SelectCustomers(mySelectCustomerQuery), null);
            EmpComboBox.DataSource = new BindingSource(mysql.SelectAll(mySelectEmpQuery), null);
            //ProductComboBox.DataSource = new BindingSource(mysql.SelectAll(mySelectProductQuery), null);
            ShipCompanyComboBox.DataSource = new BindingSource(mysql.SelectAll(mySelectShipCompany), null);
            // 客戶ComboBox
            comboBox2.DisplayMember = "Value";
            comboBox2.ValueMember = "Key";
            // 員工ComoBox
            EmpComboBox.DisplayMember = "Value";
            EmpComboBox.ValueMember = "Key";

            // 產品ComboBox 
            //ProductComboBox.DisplayMember = "Value";
            //ProductComboBox.ValueMember = "Key";

            // 航運ComboBox
            ShipCompanyComboBox.DisplayMember = "Value";
            ShipCompanyComboBox.ValueMember = "Key";
        }
        // 加入購物車
        private void button2_Click(object sender, EventArgs e)
        {
            
            //--------------------------------------------------------
            // 新類別版
            int quantity = 0;
            if (Int32.TryParse(ProductCountText.Text, out int reQuantity))
            {
                quantity = reQuantity;
            }
            else
            {
                MessageBox.Show("數量輸入錯誤!", "系統提示");
                ProductCountText.Text = "";
                return;
            }
            ShipCart Carts = new ShipCart();
            int productId = Convert.ToInt32(ProductIDTextBox.Text);
            if (ShippingCart.Any(item => item.訂單編號 == productId))
            {
                DialogResult result = MessageBox.Show("商品已經存在是否要新增?", "系統提示", MessageBoxButtons.OKCancel);
                if (result == DialogResult.OK)
                {
                    var item = ShippingCart.FirstOrDefault(items => items.訂單編號 == productId);
                    if (item != null)
                    {
                        item.Quantity += quantity;
                        item.Amount = item.UniPrice * item.Quantity;
                        dataGridView3.DataSource = Carts.ReturnDataGridView(ShippingCart);
                        ProductCountText.Text = "";
                        return;
                    }
                }
                else
                {
                    return;
                }
            }
            buttonEnable(true, true, true);
            string productName = Convert.ToString(ProductNameTextBox.Text);
            decimal uniPrice = Convert.ToDecimal(Product_UniPrice.Text);
            decimal amount = Convert.ToDecimal(AmountText.Text);
            ShippingCart.Add(Carts.AddItem(productId, productName, quantity, uniPrice, amount));
            dataGridView3.DataSource = Carts.ReturnDataGridView(ShippingCart);
            ProductCountText.Text = "";
            //--------------------------------------------------------
            // 原版本
            //DataRow row = myDataTable.NewRow();
            //if (Int32.TryParse(ProductCountText.Text, out int reProductCount))
            //{
            //    row[2] = reProductCount;
            //}
            //else
            //{
            //    MessageBox.Show("輸入錯誤", "系統提示");
            //    return;
            //}
            //// 1
            //row[0] = Convert.ToDecimal(ProductIDTextBox.Text);
            //row[1] = Convert.ToString(ProductNameTextBox.Text);
            ////row[2] = Convert.ToInt32(ProductCountText.Text);
            //row[3] = Convert.ToDouble(Product_UniPrice.Text);
            //row[4] = Convert.ToDecimal(AmountText.Text);
            //myDataTable.Rows.Add(row);
            //dataGridView3.DataSource = myDataTable;
            //ProductCountText.Text = "";

            // V2 可用
            //Decimal ProductID = Convert.ToDecimal(ProductIDTextBox.Text);
            //string ProductName = Convert.ToString(ProductNameTextBox.Text);
            //int ProductCount = Convert.ToInt32(ProductCountText.Text);
            //double Product_UniPriced = Convert.ToDouble(Product_UniPrice.Text);
            //Decimal AmountTextd = Convert.ToDecimal(AmountText.Text);
            //myDataTable.Rows.Add(new object[] { ProductID, ProductName, ProductCount, Product_UniPriced, AmountTextd });
            //--------------------------------------------------------
        }
        // (已被取代)產品的ComboBox
        private void ProductComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //int ProductKey = ((KeyValuePair<int, string>)ProductComboBox.SelectedItem).Key;
            //string ProductValue = ((KeyValuePair<int, string>)ProductComboBox.SelectedItem).Value;
            //ProductIDTextBox.Text = ProductKey.ToString();
            //Sql mysql = new Sql();
            //DataTable mytable = mysql.SelectProdct_UniPrice(ProductKey, ProductValue);
           
            //Product_UniPrice.Text = mytable.Rows[0][0].ToString();
        }

        // (已被取代)新增訂單號 
        private void button1_Click(object sender, EventArgs e)
        {
            //string myCustomerID  = CustomerIDTextBox.Text;
            //int myEmpID = Convert.ToInt32(EmpIDTextBox.Text);
            //string myOrderDate =  OrderDateTextBox.Text;
            //string myRequireDate =  DataRequireTextBox.Text;
            //int myShipVia = Convert.ToInt32(ShipViaTextBox.Text );
            //Sql mysql = new Sql();
            //DataTable myTable = mysql.AddOrderID(myCustomerID, myEmpID, myOrderDate, myRequireDate, myShipVia);
            //dataGridView1.DataSource = myTable;
            //OrderIDTextBox.Text = myTable.Rows[0][0].ToString();
        }

        // 顯示訂單資訊 ?
        public void OrderIDIsBool()
        {
            bool realMyOrderID = Int32.TryParse(OrderIDTextBox.Text, out int myOrderID);
            if (realMyOrderID == false)
            {
                MessageBox.Show("請填入訂單編號!", "系統提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
        // 刪除按鈕
        private void button7_Click(object sender, EventArgs e)
        {
            bool realMyOrderID = Int32.TryParse(OrderIDTextBox.Text, out int myOrderID);
            if (realMyOrderID == false)
            {
                MessageBox.Show("請填入訂單編號!", "系統提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Sql mysql = new Sql();
            if (mysql.DeleteOrder(myOrderID))
            {
                MessageBox.Show("刪除成功", "系統提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("刪除失敗", "系統提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        // 搜尋訂單按鈕
        private void button9_Click(object sender, EventArgs e)
        {
            QueryOrder();
        }
        // 搜尋訂單
        public void QueryOrder()
        {
            Sql mySql = new Sql();
            bool orderTrueFalse = Int32.TryParse(OrderIDTextBox.Text, out int myOrderID);
            if (orderTrueFalse == false)
            {
                MessageBox.Show("請填入訂單編號!", "系統提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                dataGridView1.DataSource = mySql.SelectOrder(myOrderID);
            }
            catch
            {
                MessageBox.Show("未找到訂單!:", "系統提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // 員工連動
        private void EmpComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (EmpComboBox.SelectedItem != null)
            {
                EmpIDTextBox.Text = ((KeyValuePair<int, string>)EmpComboBox.SelectedItem).Key.ToString();
            }
        }
        // 客戶連動
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox2.SelectedItem != null)
            {
                CustomerIDTextBox.Text = ((KeyValuePair<string, string>)comboBox2.SelectedItem).Key;
            }
        }
        // 航運連動
        private void ShipCompanyComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ShipCompanyComboBox.SelectedItem != null)
            {
                ShipViaTextBox.Text = ((KeyValuePair<int, string>)ShipCompanyComboBox.SelectedItem).Key.ToString();
            }
        }
        // 產品資料庫預覽
        private void MyProductView()
        {
            Sql mysql = new Sql();
            dataGridView2.DataSource = mysql.ProductList();
        }
        // 商品列表顯示
        private void dataGridView2_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView2.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dataGridView2.SelectedRows[0];

                ProductIDTextBox.Text = row.Cells["ProductID"].Value?.ToString();
                ProductNameTextBox.Text = row.Cells["ProductName"].Value?.ToString();
                Product_UniPrice.Text = row.Cells["UnitPrice"].Value?.ToString();
                ProductCountText.Text = "";
            }
        }
        // 購物車清單顯示
        private void dataGridView3_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView3.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dataGridView3.SelectedRows[0];

                ProductIDTextBox.Text = row.Cells["商品編號"].Value?.ToString();
                ProductNameTextBox.Text = row.Cells["商品名稱"].Value?.ToString();
                ProductCountText.Text = row.Cells["數量"].Value?.ToString();
                Product_UniPrice.Text = row.Cells["單價"].Value?.ToString();
                AmountText.Text = row.Cells["價格"].Value?.ToString();
            }
        }
        // button  Enable
        public void buttonEnable(bool b1, bool b2, bool b3)
        {
            button3.Enabled = b1;
            button5.Enabled = b2;
            button6.Enabled = b3;
        }
        // 總額即時計算 主體
        private void ProductCountText_TextChanged(object sender, EventArgs e)
        {
            ProductCalcluateTotal();
        }
        // 總額即時計算 函式
        private void ProductCalcluateTotal()
        {
            if (decimal.TryParse(Product_UniPrice.Text, out decimal quantity) &&
                decimal.TryParse(ProductCountText.Text, out decimal uniprice))
            {
                AmountText.Text = (quantity * uniprice).ToString();
            }
            else
            {
                AmountText.Text = "0.00";
            }
        }
        // 刪除購物車"某項"商品
        private void button5_Click(object sender, EventArgs e)
        {
            ShipCart mycart = new ShipCart();
            bool realOrFalse = Int32.TryParse(ProductIDTextBox.Text, out int productID);
            if (realOrFalse)
            {
                ShippingCart.RemoveAll(item => item.訂單編號 == productID);
                dataGridView3.DataSource = mycart.ReturnDataGridView(ShippingCart);
            }
            if (ShippingCart.Count == 0)
            {
                buttonEnable(false, false, false);
            }
        }
        // 刪除購物車"全部"商品
        private void button6_Click(object sender, EventArgs e)
        {
            ShipCart newShipcart = new ShipCart();
            ShippingCart.Clear();
            buttonEnable(false, false, false);
            dataGridView3.DataSource = newShipcart.myCart();
        }

        // 修改數量
        private void button3_Click(object sender, EventArgs e)
        {
            ShipCart mycart = new ShipCart();
            int prodcutId = Convert.ToInt32(ProductIDTextBox.Text);
            var item = ShippingCart.FirstOrDefault(itemw => itemw.訂單編號 == prodcutId);
            bool OXquantity = Int32.TryParse(ProductCountText.Text, out int quantity);
            if (OXquantity)
            {
                item.Quantity = quantity;
                item.Amount = item.UniPrice * quantity;
            }
            else
            {
                MessageBox.Show($"輸入錯誤");
            }
            dataGridView3.DataSource = ShippingCart;
            ProductCountText.Text = "";
        }

        // 送出訂單Btn
        private void button8_Click(object sender, EventArgs e)
        {
            Sql mysql = new Sql();
            if (ShippingCart.Count != 0)
            {
                string myCustomerID = CustomerIDTextBox.Text;
                int myEmpID = Convert.ToInt32(EmpIDTextBox.Text);
                string myOrderDate = OrderDateTextBox.Text;
                string myRequireDate = DataRequireTextBox.Text;
                int myShipVia = Convert.ToInt32(ShipViaTextBox.Text);
                int OrderID = mysql.SeneOrderAndDetail(ShippingCart, myCustomerID, myEmpID, myOrderDate, myRequireDate, myShipVia);
                if (OrderID > 0)
                {
                    MessageBox.Show("成功新增訂單", "系統提示");
                    OrderIDTextBox.Text = OrderID.ToString();
                    QueryOrder();
                }
                else
                {
                    MessageBox.Show("新增失敗", "系統提示");
                }
            }
            else
            {
                MessageBox.Show("購物車是空的!無法新增訂單");
                return;
            }
        }
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dataGridView1.SelectedRows[0];

                OrderIDTextBox.Text = row.Cells[0].Value.ToString();
                ProductNameTextBox.Text = row.Cells[1].Value.ToString();
                Product_UniPrice.Text = row.Cells[2].Value.ToString();
                ProductCountText.Text = row.Cells[3].Value.ToString();
                OrderDateTextBox.Text = row.Cells[4].Value.ToString();
                DataRequireTextBox.Value = Convert.ToDateTime(row.Cells[5].Value);
                CustomerIDTextBox.Text = row.Cells[6].Value.ToString();
                EmpIDTextBox.Text = row.Cells[7].Value.ToString();
                ShipViaTextBox.Text = row.Cells[8].Value.ToString();
                ProductIDTextBox.Text = "";
            }
        }
    }

}
