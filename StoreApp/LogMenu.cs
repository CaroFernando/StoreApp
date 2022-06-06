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
    public partial class LogMenu : Form
    {
        private struct LogEntry
        {
            public string From;
            public string Message;
            public string Time;
        }

        private List<LogEntry> Logs;
        
        private static LogMenu instance = null;
        private LogMenu()
        {
            InitializeComponent();
            Logs = new List<LogEntry>();
            dataGridView1.AllowUserToAddRows = false;
        }

        public static LogMenu Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new LogMenu();
                }
                return instance;
            }
        }

        public void UpdateTable(string from, string mesage, string time)
        {
            Logs.Add(new LogEntry() { From = from, Message = mesage, Time = time });
            dataGridView1.Rows.Clear();
            foreach (LogEntry log in Logs)
            {
                dataGridView1.Rows.Add(log.From, log.Message, log.Time);
            }
        }

        public void UpdateText(string from, string message, string time)
        {
            TextLog.AppendText(from + " , " + message + " , " + time);
            TextLog.AppendText(Environment.NewLine);
        }

        private void LogWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }
    }
}
