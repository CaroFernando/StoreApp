namespace StoreApp
{
    partial class StoreForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TableStoreName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HasOrder = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrderCol = new System.Windows.Forms.DataGridViewButtonColumn();
            this.RemoveStore = new System.Windows.Forms.DataGridViewButtonColumn();
            this.NameField = new System.Windows.Forms.TextBox();
            this.AddBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.OkBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.TableStoreName,
            this.HasOrder,
            this.OrderCol,
            this.RemoveStore});
            this.dataGridView1.Location = new System.Drawing.Point(12, 34);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(544, 372);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            // 
            // TableStoreName
            // 
            this.TableStoreName.HeaderText = "Name";
            this.TableStoreName.Name = "TableStoreName";
            this.TableStoreName.ReadOnly = true;
            // 
            // HasOrder
            // 
            this.HasOrder.HeaderText = "HasOrder";
            this.HasOrder.Name = "HasOrder";
            this.HasOrder.ReadOnly = true;
            // 
            // OrderCol
            // 
            this.OrderCol.HeaderText = "Order";
            this.OrderCol.Name = "OrderCol";
            // 
            // RemoveStore
            // 
            this.RemoveStore.HeaderText = "RemoveStore";
            this.RemoveStore.Name = "RemoveStore";
            // 
            // NameField
            // 
            this.NameField.Location = new System.Drawing.Point(670, 64);
            this.NameField.Name = "NameField";
            this.NameField.Size = new System.Drawing.Size(180, 23);
            this.NameField.TabIndex = 1;
            // 
            // AddBtn
            // 
            this.AddBtn.Location = new System.Drawing.Point(775, 103);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(75, 23);
            this.AddBtn.TabIndex = 2;
            this.AddBtn.Text = "Add";
            this.AddBtn.UseVisualStyleBackColor = true;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(625, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Name";
            // 
            // OkBtn
            // 
            this.OkBtn.Location = new System.Drawing.Point(759, 383);
            this.OkBtn.Name = "OkBtn";
            this.OkBtn.Size = new System.Drawing.Size(91, 23);
            this.OkBtn.TabIndex = 4;
            this.OkBtn.Text = "Back";
            this.OkBtn.UseVisualStyleBackColor = true;
            this.OkBtn.Click += new System.EventHandler(this.OkBtn_Click);
            // 
            // StoreForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(896, 450);
            this.Controls.Add(this.OkBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AddBtn);
            this.Controls.Add(this.NameField);
            this.Controls.Add(this.dataGridView1);
            this.Name = "StoreForm";
            this.Text = "StoreForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dataGridView1;
        private TextBox NameField;
        private Button AddBtn;
        private Label label1;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn TableStoreName;
        private DataGridViewTextBoxColumn HasOrder;
        private DataGridViewButtonColumn OrderCol;
        private DataGridViewButtonColumn RemoveStore;
        private Button OkBtn;
    }
}