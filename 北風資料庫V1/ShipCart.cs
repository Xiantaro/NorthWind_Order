using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace 北風資料庫V1
{
    internal class ShipCart
    {
        // 創建購物車
        //List<ShipItem> ShippingCart = new List<ShipItem>();
        // 新增商品
        public ShipItem AddItem(int productID, string productName, int quantity, decimal uniprice,decimal amount)
        {
            ShipItem AddCart = new ShipItem
            {
                訂單編號 = productID,
                ProductName = productName,
                Quantity = quantity,
                UniPrice = uniprice,
                Amount = amount
            };
            return AddCart;
        }
        // 刪除商品 ++已於主程式實現++
        public void DeleteItem(int productID)
        {
            //ShippingCart.RemoveAll(item => item.訂單編號 == productID);
        }
        // 購物車清空++已於主程式實現++
        public void DeleteItemAll()
        {
            //ShippingCart.Clear();
        }
        // 修改訂單數量++已於主程式實現
        public void EditQuantity(int productID, int quantity)
        {
            //var item = ShippingCart.FirstOrDefault(itesm => itesm.訂單編號 == productID);
            //if (item != null)
            //{
            //    item.Quantity = quantity;
            //    item.Amount = quantity * item.UniPrice;
            
        }
        
        // 回傳DataGridView顯示
        public DataTable ReturnDataGridView(List<ShipItem>  Cart)
        {
            DataTable tmpData = new DataTable("MyCartList");
            tmpData.Columns.Add("商品編號", typeof(int));
            tmpData.Columns.Add("商品名稱", typeof(string));
            tmpData.Columns.Add("數量", typeof(int));
            tmpData.Columns.Add("單價", typeof(double));
            tmpData.Columns.Add("價格", typeof(Decimal));

            foreach (var item in Cart)
            {
                tmpData.Rows.Add(item.訂單編號, item.ProductName, item.Quantity, item.UniPrice, item.Amount);
            }
            return tmpData;
        }
        // 購物車模板
        public DataTable myCart()
        {
            DataTable tmpData = new DataTable("MyCartList");
            tmpData.Columns.Add("商品編號", typeof(int));
            tmpData.Columns.Add("商品名稱", typeof(string));
            tmpData.Columns.Add("數量", typeof(int));
            tmpData.Columns.Add("單價", typeof(double));
            tmpData.Columns.Add("價格", typeof(Decimal));

            // 商品編號
            tmpData.Columns["商品編號"].AllowDBNull = false;
            tmpData.Columns["商品編號"].Unique = true;
            // 商品名稱
            tmpData.Columns["商品名稱"].MaxLength = 30;
            tmpData.Columns["商品名稱"].AllowDBNull = false;
            return tmpData;
        }
    }
    internal class ShipItem
    {
        public int 訂單編號 { get; set; }
        public string ProductName { get; set; }
        public int Quantity { get; set; }
        public decimal UniPrice { get; set; }
        public decimal Amount { get; set; }
    }
}
