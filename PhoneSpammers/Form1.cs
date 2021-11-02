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


        private void OpenFileButton_Click(object sender, EventArgs e) // При нажатии на кнопку Open File
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    var sr = new StreamReader(openFileDialog1.FileName);
                    input = sr.ReadToEnd();
                    sr.Close();
                }
                catch (SecurityException ex)
                {
                    MessageBox.Show($"Security error.\n\nError message: {ex.Message}\n\n" +
                    $"Details:\n\n{ex.StackTrace}");
                }
            }
        }

        private void SaveAndCloseButton_Click(object sender, EventArgs e) // При нажатии на кнопку Peport
        {
            var rs = new StreamWriter(openFileDialog1.FileName, false);
            rs.WriteLine(input);
            rs.Close();
        }

        private void PutButton_Click(object sender, EventArgs e) // При нажатии на кнопку Put
        {
            NumberOutPer = NumberOut.Text.Replace("(", "").Replace(")", "").Replace("-", "").Replace(" ", "");
            NumberIncPer = NumberInc.Text.Replace("(", "").Replace(")", "").Replace("-", "").Replace(" ", "");
            DateConnectionPer = Convert.ToString(DateConnection.Value.ToShortDateString());
            TimeConnectionPer = Convert.ToString(TimeConnection.Text);
            DurationCallPer = DurationCall.Text;
            

            if (NumberOutPer.Length != 12)
            {
                Heading.ForeColor = Color.Red;
                Heading.Text = @"Invalid field input format ""Outgoing call"" ";
            }

            else if (NumberIncPer.Length != 12)
            {
                Heading.ForeColor = Color.Red;
                Heading.Text = @"Invalid field input format ""Incoming call"" ";
            }

            else if (TimeConnectionPer.Length != 8) 
            {
                Heading.ForeColor = Color.Red;
                Heading.Text = @"Invalid field input format ""Time of connection start"" ";
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
                    Heading.ForeColor = Color.Red;
                    Heading.Text = @"Invalid field input format ""Connection duration"" ";
                }

                finally 
                {
                    if (x == 1)
                    {
                        Heading.ForeColor = Color.Green;
                        Heading.Text = "Spammer Detection";

                        input += NumberOutPer + ", " + NumberIncPer + ", " + DateConnectionPer + " " + TimeConnectionPer + ", " + DurationCallPer + "\n";
                    }                
                }
            }
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {

        }

        private void SavePeportButton_Click(object sender, EventArgs e)
        {
            StartTime = Convert.ToString(DateStartPeriod.Value);
            EndTime = Convert.ToString(DateEndPeriod.Value);

            var sr = new StreamReader(openFileDialog1.FileName);
            input = sr.ReadToEnd();
            //input = input.Substring(0, input.Length - 6);

            sr.Close();

            string input2 = "";
            string input3 = "";
            foreach (string i in input.Split('\n'))
            {
                 string x = i.Split(',')[2].Trim().Substring(0, 10);
                 if (DateTime.Parse(StartTime.Substring(0, 10)) <= DateTime.Parse(x) && DateTime.Parse(EndTime.Substring(0, 10)) >= DateTime.Parse(x))
                 {
                    input2 += i + '\n';
                 }
            }

            string numbersUsed = "";
            for (int j = 0; j < (input2.Length - input2.Replace("\n", "").Length) / "\n".Length; j++)
            {
                int kl = 0;
                int summ = 0;
                string activeValue = "";
                int lenghtInput2 = (input2.Length - input2.Replace("\n", "").Length) / "\n".Length;
                for (int i = 0; i < lenghtInput2; i++)
                {
                    
                    if (Array.IndexOf(numbersUsed.Split('-'), input2.Split('\n')[i].Split(',')[0].Trim()) == -1)
                    {
                        
                        if (kl == 0) 
                        {
                            activeValue = input2.Split('\n')[i].Split(',')[0].Trim();
                        }

                        if (input2.Split('\n')[i].Split(',')[0].Trim() == activeValue)
                        { 
                            kl++;
                            summ += Convert.ToInt32(input2.Split('\n')[i].Split(',')[3].Trim());
                        }
                            
                    }
                }

                int h = summ / 3600;
                int m = (summ - (h * 3600)) / 60;
                int s = summ % 60;
                if (input3.Split('\n').Length <= 10)
                { 
                    input3 += input2.Split('\n')[0].Split(',')[0].Trim() + ", " + kl + ", " + h + ":" + m + ":" + s + "\n";
                }

                numbersUsed += input2.Split('\n')[0].Split(',')[0].Trim() + "-";
            }

            System.IO.File.WriteAllText("C:\\Report.txt", input3);

        }
    }
}
