using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhoneSpammers
{
    public partial class MainWindow : Form
    {
        public string input;
        public System.DateTime StartTime;
        public System.DateTime EndTime;

        public MainWindow()
        {
            InitializeComponent();
        }


        private void Open_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    var sr = new StreamReader(openFileDialog1.FileName);
                    input = sr.ReadToEnd();
                    Heading.Text = input;
                }
                catch (SecurityException ex)
                {
                    MessageBox.Show($"Security error.\n\nError message: {ex.Message}\n\n" +
                    $"Details:\n\n{ex.StackTrace}");
                }
            }
        }

        private void ReportButton_Click(object sender, EventArgs e)
        {
            StartTime = DateStartPeriod.Value;
            EndTime = DateEndPeriod.Value;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void PutButton_Click(object sender, EventArgs e)
        {
            input += DateConnection.Value.ToShortDateString();
            Heading.Text = input;
        }
    }
}
