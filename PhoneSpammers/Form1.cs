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
        public string StartTime;
        public string EndTime;

        public string NumberOutPer;
        public string NumberIncPer;
        public string DateConnectionPer;
        public string TimeConnectionPer;
        public string DurationCallPer;

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
            StartTime = Convert.ToString(DateStartPeriod.Value);
            EndTime = Convert.ToString(DateEndPeriod.Value);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void PutButton_Click(object sender, EventArgs e)
        {
            NumberOutPer = NumberOut.Text.Replace("(", "").Replace(")", "").Replace("-", "").Replace(" ", "");
            NumberIncPer = NumberInc.Text.Replace("(", "").Replace(")", "").Replace("-", "").Replace(" ", "");
            DateConnectionPer = Convert.ToString(DateConnection.Value.ToShortDateString());
            TimeConnectionPer = Convert.ToString(TimeConnection.Text);
            DurationCallPer = DurationCall.Text;
            input += NumberOutPer + ", " + NumberIncPer + ", " + DateConnectionPer + ", " + TimeConnectionPer + ", " + DurationCallPer;
            Heading.Text = input;

            if (NumberOutPer.Length != 11)
            {
                Heading.ForeColor;
            }

            else if (NumberOutPer.Length != 11)
            {

            }

            else if (DateConnectionPer.Length != 8) 
            { 
            
            }

            else
            {
                int x = 1;
                try
                {
                    Convert.ToInt32(DurationCallPer);
                }

                catch
                {
                    x = 0;
                }

                finally 
                {
                    if (x == 1)
                    {
                      
                    }                
                }
            }
        }

        private void NumberOut_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void MainWindow_Load(object sender, EventArgs e)
        {

        }
    }
}
