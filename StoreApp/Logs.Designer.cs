namespace StoreApp
{
    partial class Logs
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
            this.TextLoggerBtn = new System.Windows.Forms.Button();
            this.GridLoggerBtn = new System.Windows.Forms.Button();
            this.TextBoxBtn = new System.Windows.Forms.Button();
            this.OpenWindowBtn = new System.Windows.Forms.Button();
            this.Info = new System.Windows.Forms.Label();
            this.ResetBtn = new System.Windows.Forms.Button();
            this.BackBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TextLoggerBtn
            // 
            this.TextLoggerBtn.Location = new System.Drawing.Point(26, 102);
            this.TextLoggerBtn.Name = "TextLoggerBtn";
            this.TextLoggerBtn.Size = new System.Drawing.Size(113, 41);
            this.TextLoggerBtn.TabIndex = 0;
            this.TextLoggerBtn.Text = "Add Text Logger";
            this.TextLoggerBtn.UseVisualStyleBackColor = true;
            this.TextLoggerBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // GridLoggerBtn
            // 
            this.GridLoggerBtn.Location = new System.Drawing.Point(145, 102);
            this.GridLoggerBtn.Name = "GridLoggerBtn";
            this.GridLoggerBtn.Size = new System.Drawing.Size(108, 41);
            this.GridLoggerBtn.TabIndex = 1;
            this.GridLoggerBtn.Text = "Add Grid Logger";
            this.GridLoggerBtn.UseVisualStyleBackColor = true;
            this.GridLoggerBtn.Click += new System.EventHandler(this.GridLoggerBtn_Click);
            // 
            // TextBoxBtn
            // 
            this.TextBoxBtn.Location = new System.Drawing.Point(259, 102);
            this.TextBoxBtn.Name = "TextBoxBtn";
            this.TextBoxBtn.Size = new System.Drawing.Size(124, 41);
            this.TextBoxBtn.TabIndex = 2;
            this.TextBoxBtn.Text = "Add textbox logger";
            this.TextBoxBtn.UseVisualStyleBackColor = true;
            this.TextBoxBtn.Click += new System.EventHandler(this.TextBoxBtn_Click);
            // 
            // OpenWindowBtn
            // 
            this.OpenWindowBtn.BackColor = System.Drawing.SystemColors.Control;
            this.OpenWindowBtn.Location = new System.Drawing.Point(519, 102);
            this.OpenWindowBtn.Name = "OpenWindowBtn";
            this.OpenWindowBtn.Size = new System.Drawing.Size(132, 41);
            this.OpenWindowBtn.TabIndex = 3;
            this.OpenWindowBtn.Text = "Open Log Window";
            this.OpenWindowBtn.UseVisualStyleBackColor = false;
            this.OpenWindowBtn.Click += new System.EventHandler(this.OpenWindowBtn_Click);
            // 
            // Info
            // 
            this.Info.AutoSize = true;
            this.Info.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Info.Location = new System.Drawing.Point(36, 37);
            this.Info.Name = "Info";
            this.Info.Size = new System.Drawing.Size(45, 25);
            this.Info.TabIndex = 4;
            this.Info.Text = "Info";
            this.Info.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ResetBtn
            // 
            this.ResetBtn.Location = new System.Drawing.Point(389, 102);
            this.ResetBtn.Name = "ResetBtn";
            this.ResetBtn.Size = new System.Drawing.Size(124, 41);
            this.ResetBtn.TabIndex = 5;
            this.ResetBtn.Text = "Reset Loggers";
            this.ResetBtn.UseVisualStyleBackColor = true;
            this.ResetBtn.Click += new System.EventHandler(this.ResetBtn_Click);
            // 
            // BackBtn
            // 
            this.BackBtn.Location = new System.Drawing.Point(555, 164);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(96, 31);
            this.BackBtn.TabIndex = 6;
            this.BackBtn.Text = "Back";
            this.BackBtn.UseVisualStyleBackColor = true;
            this.BackBtn.Click += new System.EventHandler(this.BackBtn_Click);
            // 
            // Logs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(688, 218);
            this.Controls.Add(this.BackBtn);
            this.Controls.Add(this.ResetBtn);
            this.Controls.Add(this.Info);
            this.Controls.Add(this.OpenWindowBtn);
            this.Controls.Add(this.TextBoxBtn);
            this.Controls.Add(this.GridLoggerBtn);
            this.Controls.Add(this.TextLoggerBtn);
            this.Name = "Logs";
            this.Text = "Logs";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button TextLoggerBtn;
        private Button GridLoggerBtn;
        private Button TextBoxBtn;
        private Button OpenWindowBtn;
        private Label Info;
        private Button ResetBtn;
        private Button BackBtn;
    }
}