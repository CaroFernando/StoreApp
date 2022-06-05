namespace StoreApp
{
    partial class Home
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.StoreBtn = new System.Windows.Forms.Button();
            this.RouteBtn = new System.Windows.Forms.Button();
            this.LogBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // StoreBtn
            // 
            this.StoreBtn.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.StoreBtn.Location = new System.Drawing.Point(147, 33);
            this.StoreBtn.Name = "StoreBtn";
            this.StoreBtn.Size = new System.Drawing.Size(231, 86);
            this.StoreBtn.TabIndex = 0;
            this.StoreBtn.Text = "Stores";
            this.StoreBtn.UseVisualStyleBackColor = true;
            this.StoreBtn.Click += new System.EventHandler(this.StoreBtn_Click);
            // 
            // RouteBtn
            // 
            this.RouteBtn.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RouteBtn.Location = new System.Drawing.Point(147, 161);
            this.RouteBtn.Name = "RouteBtn";
            this.RouteBtn.Size = new System.Drawing.Size(231, 86);
            this.RouteBtn.TabIndex = 1;
            this.RouteBtn.Text = "Route";
            this.RouteBtn.UseVisualStyleBackColor = true;
            this.RouteBtn.Click += new System.EventHandler(this.RouteBtn_Click);
            // 
            // LogBtn
            // 
            this.LogBtn.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LogBtn.Location = new System.Drawing.Point(147, 297);
            this.LogBtn.Name = "LogBtn";
            this.LogBtn.Size = new System.Drawing.Size(231, 86);
            this.LogBtn.TabIndex = 2;
            this.LogBtn.Text = "Logs";
            this.LogBtn.UseVisualStyleBackColor = true;
            this.LogBtn.Click += new System.EventHandler(this.LogBtn_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 450);
            this.Controls.Add(this.LogBtn);
            this.Controls.Add(this.RouteBtn);
            this.Controls.Add(this.StoreBtn);
            this.Name = "Home";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private Button StoreBtn;
        private Button RouteBtn;
        private Button LogBtn;
    }
}