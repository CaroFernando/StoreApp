using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StoreApp
{
    public partial class Logs : Form
    {
        public Logs()
        {
            InitializeComponent();
            Update();
        }

        public void Update()
        {
            Info.Text = "Text: " + Core.Logger.GlobalLogger.TextLoggerCont +
                " Grid: " + Core.Logger.GlobalLogger.GridLoggerCont +
                " TextBox: " + Core.Logger.GlobalLogger.TextBoxLoggerCont;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Core.Logger.GlobalLogger.addTextLogger();
            Update();
        }

        private void TextBoxBtn_Click(object sender, EventArgs e)
        {
            Core.Logger.GlobalLogger.addTextBoxLogger();
            Update();            
        }

        private void GridLoggerBtn_Click(object sender, EventArgs e)
        {
            Core.Logger.GlobalLogger.addGridLogger();
            Update();            
        }

        private void ResetBtn_Click(object sender, EventArgs e)
        {
            Core.Logger.GlobalLogger.Reset();
            Update();
        }
        
        private void OpenWindowBtn_Click(object sender, EventArgs e)
        {
            LogMenu.Instance.Show();
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
