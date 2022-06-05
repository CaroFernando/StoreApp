namespace StoreApp
{
    partial class CreateOrder
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.QuantityTxt = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.VegetablesRadio = new System.Windows.Forms.RadioButton();
            this.SodaRadio = new System.Windows.Forms.RadioButton();
            this.BreadRadio = new System.Windows.Forms.RadioButton();
            this.OrderTable = new System.Windows.Forms.DataGridView();
            this.ProductId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProdQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProdPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProdTotalPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProdRemove = new System.Windows.Forms.DataGridViewButtonColumn();
            this.CreateBtn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OrderTable)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(306, 373);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Add Product";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(88, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // QuantityTxt
            // 
            this.QuantityTxt.Location = new System.Drawing.Point(58, 373);
            this.QuantityTxt.Name = "QuantityTxt";
            this.QuantityTxt.Size = new System.Drawing.Size(100, 23);
            this.QuantityTxt.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.VegetablesRadio);
            this.groupBox1.Controls.Add(this.SodaRadio);
            this.groupBox1.Controls.Add(this.BreadRadio);
            this.groupBox1.Location = new System.Drawing.Point(38, 295);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(389, 61);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            // 
            // VegetablesRadio
            // 
            this.VegetablesRadio.AutoSize = true;
            this.VegetablesRadio.Location = new System.Drawing.Point(233, 22);
            this.VegetablesRadio.Name = "VegetablesRadio";
            this.VegetablesRadio.Size = new System.Drawing.Size(81, 19);
            this.VegetablesRadio.TabIndex = 2;
            this.VegetablesRadio.TabStop = true;
            this.VegetablesRadio.Text = "Vegetables";
            this.VegetablesRadio.UseVisualStyleBackColor = true;
            // 
            // SodaRadio
            // 
            this.SodaRadio.AutoSize = true;
            this.SodaRadio.Location = new System.Drawing.Point(142, 22);
            this.SodaRadio.Name = "SodaRadio";
            this.SodaRadio.Size = new System.Drawing.Size(51, 19);
            this.SodaRadio.TabIndex = 1;
            this.SodaRadio.TabStop = true;
            this.SodaRadio.Text = "Soda";
            this.SodaRadio.UseVisualStyleBackColor = true;
            // 
            // BreadRadio
            // 
            this.BreadRadio.AutoSize = true;
            this.BreadRadio.Location = new System.Drawing.Point(30, 22);
            this.BreadRadio.Name = "BreadRadio";
            this.BreadRadio.Size = new System.Drawing.Size(55, 19);
            this.BreadRadio.TabIndex = 0;
            this.BreadRadio.TabStop = true;
            this.BreadRadio.Text = "Bread";
            this.BreadRadio.UseVisualStyleBackColor = true;
            // 
            // OrderTable
            // 
            this.OrderTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OrderTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProductId,
            this.ProductName,
            this.ProdQuantity,
            this.ProdPrice,
            this.ProdTotalPrice,
            this.ProdRemove});
            this.OrderTable.Location = new System.Drawing.Point(64, 111);
            this.OrderTable.Name = "OrderTable";
            this.OrderTable.RowTemplate.Height = 25;
            this.OrderTable.Size = new System.Drawing.Size(644, 178);
            this.OrderTable.TabIndex = 7;
            this.OrderTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.OrderTable_CellContentClick);
            // 
            // ProductId
            // 
            this.ProductId.HeaderText = "Id";
            this.ProductId.Name = "ProductId";
            // 
            // ProductName
            // 
            this.ProductName.HeaderText = "ProductName";
            this.ProductName.Name = "ProductName";
            // 
            // ProdQuantity
            // 
            this.ProdQuantity.HeaderText = "QuantityCol";
            this.ProdQuantity.Name = "ProdQuantity";
            // 
            // ProdPrice
            // 
            this.ProdPrice.HeaderText = "Price per unit";
            this.ProdPrice.Name = "ProdPrice";
            // 
            // ProdTotalPrice
            // 
            this.ProdTotalPrice.HeaderText = "TotalProductPrice";
            this.ProdTotalPrice.Name = "ProdTotalPrice";
            // 
            // ProdRemove
            // 
            this.ProdRemove.HeaderText = "Remove";
            this.ProdRemove.Name = "ProdRemove";
            this.ProdRemove.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ProdRemove.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // CreateBtn
            // 
            this.CreateBtn.Location = new System.Drawing.Point(601, 373);
            this.CreateBtn.Name = "CreateBtn";
            this.CreateBtn.Size = new System.Drawing.Size(107, 23);
            this.CreateBtn.TabIndex = 8;
            this.CreateBtn.Text = "Create Order";
            this.CreateBtn.UseVisualStyleBackColor = true;
            this.CreateBtn.Click += new System.EventHandler(this.CreateBtn_Click);
            // 
            // CreateOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CreateBtn);
            this.Controls.Add(this.OrderTable);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.QuantityTxt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "CreateOrder";
            this.Text = "CreateOrder";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CreateOrder_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OrderTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button1;
        private Label label1;
        private TextBox QuantityTxt;
        private GroupBox groupBox1;
        private RadioButton VegetablesRadio;
        private RadioButton SodaRadio;
        private RadioButton BreadRadio;
        private DataGridView OrderTable;
        private DataGridViewTextBoxColumn ProductId;
        private DataGridViewTextBoxColumn ProductName;
        private DataGridViewTextBoxColumn ProdQuantity;
        private DataGridViewTextBoxColumn ProdPrice;
        private DataGridViewTextBoxColumn ProdTotalPrice;
        private DataGridViewButtonColumn ProdRemove;
        private Button CreateBtn;
    }
}