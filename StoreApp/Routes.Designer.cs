namespace StoreApp
{
    partial class Routes
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
            this.BreadBtn = new System.Windows.Forms.Button();
            this.VegetablesBtn = new System.Windows.Forms.Button();
            this.SodaBtn = new System.Windows.Forms.Button();
            this.ValidateBtn = new System.Windows.Forms.Button();
            this.SimulationBtn = new System.Windows.Forms.Button();
            this.Info = new System.Windows.Forms.Label();
            this.ResetBtn = new System.Windows.Forms.Button();
            this.BackBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BreadBtn
            // 
            this.BreadBtn.Location = new System.Drawing.Point(97, 108);
            this.BreadBtn.Name = "BreadBtn";
            this.BreadBtn.Size = new System.Drawing.Size(134, 61);
            this.BreadBtn.TabIndex = 0;
            this.BreadBtn.Text = "Add Bread Truck";
            this.BreadBtn.UseVisualStyleBackColor = true;
            this.BreadBtn.Click += new System.EventHandler(this.BreadBtn_Click);
            // 
            // VegetablesBtn
            // 
            this.VegetablesBtn.Location = new System.Drawing.Point(262, 108);
            this.VegetablesBtn.Name = "VegetablesBtn";
            this.VegetablesBtn.Size = new System.Drawing.Size(134, 61);
            this.VegetablesBtn.TabIndex = 1;
            this.VegetablesBtn.Text = "Add Vegetables Truck";
            this.VegetablesBtn.UseVisualStyleBackColor = true;
            this.VegetablesBtn.Click += new System.EventHandler(this.VegetablesBtn_Click);
            // 
            // SodaBtn
            // 
            this.SodaBtn.Location = new System.Drawing.Point(426, 108);
            this.SodaBtn.Name = "SodaBtn";
            this.SodaBtn.Size = new System.Drawing.Size(134, 61);
            this.SodaBtn.TabIndex = 2;
            this.SodaBtn.Text = "Add Soda Truck";
            this.SodaBtn.UseVisualStyleBackColor = true;
            this.SodaBtn.Click += new System.EventHandler(this.SodaBtn_Click);
            // 
            // ValidateBtn
            // 
            this.ValidateBtn.Location = new System.Drawing.Point(262, 201);
            this.ValidateBtn.Name = "ValidateBtn";
            this.ValidateBtn.Size = new System.Drawing.Size(134, 36);
            this.ValidateBtn.TabIndex = 3;
            this.ValidateBtn.Text = "Validate Route";
            this.ValidateBtn.UseVisualStyleBackColor = true;
            this.ValidateBtn.Click += new System.EventHandler(this.ValidateBtn_Click);
            // 
            // SimulationBtn
            // 
            this.SimulationBtn.Location = new System.Drawing.Point(427, 201);
            this.SimulationBtn.Name = "SimulationBtn";
            this.SimulationBtn.Size = new System.Drawing.Size(134, 36);
            this.SimulationBtn.TabIndex = 4;
            this.SimulationBtn.Text = "Start simulation";
            this.SimulationBtn.UseVisualStyleBackColor = true;
            this.SimulationBtn.Click += new System.EventHandler(this.SimulationBtn_Click);
            // 
            // Info
            // 
            this.Info.AutoSize = true;
            this.Info.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Info.Location = new System.Drawing.Point(58, 34);
            this.Info.Name = "Info";
            this.Info.Size = new System.Drawing.Size(536, 37);
            this.Info.TabIndex = 5;
            this.Info.Text = "Bread Trucks: Vegetable  Truck: Soda Trucks: ";
            // 
            // ResetBtn
            // 
            this.ResetBtn.Location = new System.Drawing.Point(97, 201);
            this.ResetBtn.Name = "ResetBtn";
            this.ResetBtn.Size = new System.Drawing.Size(134, 36);
            this.ResetBtn.TabIndex = 6;
            this.ResetBtn.Text = "Reset Deliver";
            this.ResetBtn.UseVisualStyleBackColor = true;
            this.ResetBtn.Click += new System.EventHandler(this.ResetBtn_Click);
            // 
            // BackBtn
            // 
            this.BackBtn.Location = new System.Drawing.Point(485, 269);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(75, 23);
            this.BackBtn.TabIndex = 7;
            this.BackBtn.Text = "Back";
            this.BackBtn.UseVisualStyleBackColor = true;
            this.BackBtn.Click += new System.EventHandler(this.BackBtn_Click);
            // 
            // RoutesWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 322);
            this.Controls.Add(this.BackBtn);
            this.Controls.Add(this.ResetBtn);
            this.Controls.Add(this.Info);
            this.Controls.Add(this.SimulationBtn);
            this.Controls.Add(this.ValidateBtn);
            this.Controls.Add(this.SodaBtn);
            this.Controls.Add(this.VegetablesBtn);
            this.Controls.Add(this.BreadBtn);
            this.Name = "RoutesWindow";
            this.Text = "RoutesWindow";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button BreadBtn;
        private Button VegetablesBtn;
        private Button SodaBtn;
        private Button ValidateBtn;
        private Button SimulationBtn;
        private Label Info;
        private Button ResetBtn;
        private Button BackBtn;
    }
}