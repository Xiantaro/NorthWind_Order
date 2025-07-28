using System;

namespace 北風資料庫V1
{
    partial class NW_Order
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.ProductCountText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.OrderIDTextBox = new System.Windows.Forms.TextBox();
            this.OrderDateTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Product_UniPrice = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.ShipViaTextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.EmpComboBox = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.CustomerIDTextBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.EmpIDTextBox = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.DataRequireTextBox = new System.Windows.Forms.DateTimePicker();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.AmountText = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.ShipCompanyComboBox = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.CartByOrder = new System.Windows.Forms.Label();
            this.ProductIDLable = new System.Windows.Forms.Label();
            this.ProductIDTextBox = new System.Windows.Forms.TextBox();
            this.ProductNameTextBox = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button7.Location = new System.Drawing.Point(1605, 320);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(171, 74);
            this.button7.TabIndex = 21;
            this.button7.Text = "刪除訂單";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button8.Location = new System.Drawing.Point(1376, 629);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(225, 74);
            this.button8.TabIndex = 20;
            this.button8.Text = "新增訂單";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button9.Location = new System.Drawing.Point(1605, 240);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(171, 74);
            this.button9.TabIndex = 19;
            this.button9.Text = "搜尋訂單";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // ProductCountText
            // 
            this.ProductCountText.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.ProductCountText.Location = new System.Drawing.Point(881, 600);
            this.ProductCountText.Name = "ProductCountText";
            this.ProductCountText.Size = new System.Drawing.Size(291, 51);
            this.ProductCountText.TabIndex = 17;
            this.ProductCountText.TextChanged += new System.EventHandler(this.ProductCountText_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(696, 536);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 36);
            this.label1.TabIndex = 16;
            this.label1.Text = "商品名稱:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(43, 95);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 31;
            this.dataGridView1.Size = new System.Drawing.Size(653, 201);
            this.dataGridView1.TabIndex = 15;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(707, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 36);
            this.label2.TabIndex = 23;
            this.label2.Text = "訂單編號:";
            // 
            // OrderIDTextBox
            // 
            this.OrderIDTextBox.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.OrderIDTextBox.Location = new System.Drawing.Point(881, 31);
            this.OrderIDTextBox.Name = "OrderIDTextBox";
            this.OrderIDTextBox.Size = new System.Drawing.Size(206, 51);
            this.OrderIDTextBox.TabIndex = 24;
            // 
            // OrderDateTextBox
            // 
            this.OrderDateTextBox.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.OrderDateTextBox.Location = new System.Drawing.Point(881, 111);
            this.OrderDateTextBox.Name = "OrderDateTextBox";
            this.OrderDateTextBox.ReadOnly = true;
            this.OrderDateTextBox.Size = new System.Drawing.Size(206, 51);
            this.OrderDateTextBox.TabIndex = 26;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(707, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(168, 36);
            this.label4.TabIndex = 25;
            this.label4.Text = "訂單日期:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(1156, 192);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 36);
            this.label3.TabIndex = 27;
            this.label3.Text = "客戶:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.Location = new System.Drawing.Point(768, 611);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 36);
            this.label5.TabIndex = 29;
            this.label5.Text = "數量:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label6.Location = new System.Drawing.Point(768, 680);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 36);
            this.label6.TabIndex = 31;
            this.label6.Text = "單價:";
            // 
            // Product_UniPrice
            // 
            this.Product_UniPrice.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Product_UniPrice.Location = new System.Drawing.Point(881, 665);
            this.Product_UniPrice.Name = "Product_UniPrice";
            this.Product_UniPrice.ReadOnly = true;
            this.Product_UniPrice.Size = new System.Drawing.Size(289, 51);
            this.Product_UniPrice.TabIndex = 30;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label7.Location = new System.Drawing.Point(768, 733);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 36);
            this.label7.TabIndex = 32;
            this.label7.Text = "折扣:";
            // 
            // ShipViaTextBox
            // 
            this.ShipViaTextBox.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.ShipViaTextBox.Location = new System.Drawing.Point(881, 338);
            this.ShipViaTextBox.Name = "ShipViaTextBox";
            this.ShipViaTextBox.ReadOnly = true;
            this.ShipViaTextBox.Size = new System.Drawing.Size(206, 51);
            this.ShipViaTextBox.TabIndex = 33;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label8.Location = new System.Drawing.Point(1103, 276);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(168, 36);
            this.label8.TabIndex = 34;
            this.label8.Text = "業務名稱:";
            // 
            // comboBox2
            // 
            this.comboBox2.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(1277, 189);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(284, 44);
            this.comboBox2.TabIndex = 36;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // EmpComboBox
            // 
            this.EmpComboBox.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.EmpComboBox.FormattingEnabled = true;
            this.EmpComboBox.Location = new System.Drawing.Point(1277, 273);
            this.EmpComboBox.Name = "EmpComboBox";
            this.EmpComboBox.Size = new System.Drawing.Size(284, 44);
            this.EmpComboBox.TabIndex = 37;
            this.EmpComboBox.SelectedIndexChanged += new System.EventHandler(this.EmpComboBox_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label9.Location = new System.Drawing.Point(744, 192);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(131, 36);
            this.label9.TabIndex = 38;
            this.label9.Text = "客戶ID:";
            // 
            // CustomerIDTextBox
            // 
            this.CustomerIDTextBox.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.CustomerIDTextBox.Location = new System.Drawing.Point(881, 187);
            this.CustomerIDTextBox.Name = "CustomerIDTextBox";
            this.CustomerIDTextBox.ReadOnly = true;
            this.CustomerIDTextBox.Size = new System.Drawing.Size(206, 51);
            this.CustomerIDTextBox.TabIndex = 39;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label10.Location = new System.Drawing.Point(744, 276);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(131, 36);
            this.label10.TabIndex = 40;
            this.label10.Text = "業務ID:";
            // 
            // EmpIDTextBox
            // 
            this.EmpIDTextBox.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.EmpIDTextBox.Location = new System.Drawing.Point(881, 276);
            this.EmpIDTextBox.Name = "EmpIDTextBox";
            this.EmpIDTextBox.ReadOnly = true;
            this.EmpIDTextBox.Size = new System.Drawing.Size(206, 51);
            this.EmpIDTextBox.TabIndex = 41;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label11.Location = new System.Drawing.Point(1103, 117);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(168, 36);
            this.label11.TabIndex = 42;
            this.label11.Text = "需求日期:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label12.Location = new System.Drawing.Point(707, 341);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(168, 36);
            this.label12.TabIndex = 44;
            this.label12.Text = "航運代號:";
            // 
            // textBox8
            // 
            this.textBox8.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBox8.Location = new System.Drawing.Point(881, 730);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(291, 51);
            this.textBox8.TabIndex = 45;
            // 
            // DataRequireTextBox
            // 
            this.DataRequireTextBox.CustomFormat = "yyyy-MM-dd";
            this.DataRequireTextBox.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.DataRequireTextBox.Font = new System.Drawing.Font("新細明體", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.DataRequireTextBox.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DataRequireTextBox.Location = new System.Drawing.Point(1277, 111);
            this.DataRequireTextBox.MaxDate = new System.DateTime(2030, 5, 24, 0, 0, 0, 0);
            this.DataRequireTextBox.MinDate = new System.DateTime(2025, 1, 13, 0, 0, 0, 0);
            this.DataRequireTextBox.Name = "DataRequireTextBox";
            this.DataRequireTextBox.Size = new System.Drawing.Size(284, 46);
            this.DataRequireTextBox.TabIndex = 46;
            this.DataRequireTextBox.Value = new System.DateTime(2025, 5, 25, 23, 59, 59, 0);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView2.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(43, 665);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 62;
            this.dataGridView2.RowTemplate.Height = 31;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(653, 209);
            this.dataGridView2.TabIndex = 50;
            this.dataGridView2.SelectionChanged += new System.EventHandler(this.dataGridView2_SelectionChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("新細明體", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label14.Location = new System.Drawing.Point(35, 38);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(107, 44);
            this.label14.TabIndex = 51;
            this.label14.Text = "訂單";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label15.Font = new System.Drawing.Font("新細明體", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label15.Location = new System.Drawing.Point(35, 605);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(195, 44);
            this.label15.TabIndex = 52;
            this.label15.Text = "商品列表";
            // 
            // AmountText
            // 
            this.AmountText.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.AmountText.Location = new System.Drawing.Point(881, 796);
            this.AmountText.Name = "AmountText";
            this.AmountText.ReadOnly = true;
            this.AmountText.Size = new System.Drawing.Size(291, 51);
            this.AmountText.TabIndex = 53;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label13.Location = new System.Drawing.Point(768, 808);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(96, 36);
            this.label13.TabIndex = 54;
            this.label13.Text = "總價:";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button2.Location = new System.Drawing.Point(254, 599);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(220, 52);
            this.button2.TabIndex = 55;
            this.button2.Text = "加入購物車";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // ShipCompanyComboBox
            // 
            this.ShipCompanyComboBox.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.ShipCompanyComboBox.FormattingEnabled = true;
            this.ShipCompanyComboBox.Location = new System.Drawing.Point(1277, 350);
            this.ShipCompanyComboBox.Name = "ShipCompanyComboBox";
            this.ShipCompanyComboBox.Size = new System.Drawing.Size(284, 44);
            this.ShipCompanyComboBox.TabIndex = 56;
            this.ShipCompanyComboBox.SelectedIndexChanged += new System.EventHandler(this.ShipCompanyComboBox_SelectedIndexChanged);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label16.Location = new System.Drawing.Point(1103, 353);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(168, 36);
            this.label16.TabIndex = 57;
            this.label16.Text = "航運公司:";
            // 
            // dataGridView3
            // 
            this.dataGridView3.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(34, 383);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowHeadersWidth = 62;
            this.dataGridView3.RowTemplate.Height = 31;
            this.dataGridView3.Size = new System.Drawing.Size(653, 201);
            this.dataGridView3.TabIndex = 58;
            this.dataGridView3.SelectionChanged += new System.EventHandler(this.dataGridView3_SelectionChanged);
            // 
            // CartByOrder
            // 
            this.CartByOrder.AutoSize = true;
            this.CartByOrder.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.CartByOrder.Font = new System.Drawing.Font("新細明體", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.CartByOrder.Location = new System.Drawing.Point(35, 327);
            this.CartByOrder.Name = "CartByOrder";
            this.CartByOrder.Size = new System.Drawing.Size(151, 44);
            this.CartByOrder.TabIndex = 59;
            this.CartByOrder.Text = "購物車";
            // 
            // ProductIDLable
            // 
            this.ProductIDLable.AutoSize = true;
            this.ProductIDLable.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.ProductIDLable.Location = new System.Drawing.Point(733, 459);
            this.ProductIDLable.Name = "ProductIDLable";
            this.ProductIDLable.Size = new System.Drawing.Size(131, 36);
            this.ProductIDLable.TabIndex = 61;
            this.ProductIDLable.Text = "商品ID:";
            // 
            // ProductIDTextBox
            // 
            this.ProductIDTextBox.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.ProductIDTextBox.Location = new System.Drawing.Point(881, 444);
            this.ProductIDTextBox.Name = "ProductIDTextBox";
            this.ProductIDTextBox.Size = new System.Drawing.Size(291, 51);
            this.ProductIDTextBox.TabIndex = 62;
            // 
            // ProductNameTextBox
            // 
            this.ProductNameTextBox.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.ProductNameTextBox.Location = new System.Drawing.Point(881, 521);
            this.ProductNameTextBox.Name = "ProductNameTextBox";
            this.ProductNameTextBox.Size = new System.Drawing.Size(291, 51);
            this.ProductNameTextBox.TabIndex = 63;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button3.Location = new System.Drawing.Point(500, 600);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(187, 52);
            this.button3.TabIndex = 64;
            this.button3.Text = "修改數量";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button5.Location = new System.Drawing.Point(1343, 721);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(293, 52);
            this.button5.TabIndex = 66;
            this.button5.Text = "刪除商品";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button6.Location = new System.Drawing.Point(1343, 791);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(293, 52);
            this.button6.TabIndex = 67;
            this.button6.Text = "刪除購物車全部商品";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // NW_Order
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1819, 903);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.ProductNameTextBox);
            this.Controls.Add(this.ProductIDTextBox);
            this.Controls.Add(this.ProductIDLable);
            this.Controls.Add(this.CartByOrder);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.ShipCompanyComboBox);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.AmountText);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.DataRequireTextBox);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.EmpIDTextBox);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.CustomerIDTextBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.EmpComboBox);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.ShipViaTextBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Product_UniPrice);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.OrderDateTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.OrderIDTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.ProductCountText);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "NW_Order";
            this.Text = "NW_Order";
            this.Load += new System.EventHandler(this.NW_Order_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.TextBox ProductCountText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox OrderIDTextBox;
        private System.Windows.Forms.TextBox OrderDateTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Product_UniPrice;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox ShipViaTextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox EmpComboBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox CustomerIDTextBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox EmpIDTextBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.DateTimePicker DataRequireTextBox;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox AmountText;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox ShipCompanyComboBox;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.Label CartByOrder;
        private System.Windows.Forms.Label ProductIDLable;
        private System.Windows.Forms.TextBox ProductIDTextBox;
        private System.Windows.Forms.TextBox ProductNameTextBox;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
    }
}