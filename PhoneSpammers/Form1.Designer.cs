using System.Windows.Forms;

namespace PhoneSpammers
{
    partial class MainWindow
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.NumberOut = new System.Windows.Forms.MaskedTextBox();
            this.NumberInc = new System.Windows.Forms.MaskedTextBox();
            this.Heading = new System.Windows.Forms.Label();
            this.Text_OutgoingCall = new System.Windows.Forms.Label();
            this.Text_IncomingCall = new System.Windows.Forms.Label();
            this.DateConnection = new System.Windows.Forms.DateTimePicker();
            this.TimeConnection = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.DurationCall = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.DateStartPeriod = new System.Windows.Forms.DateTimePicker();
            this.DateEndPeriod = new System.Windows.Forms.DateTimePicker();
            this.ReportButton = new System.Windows.Forms.Button();
            this.Open = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.PutButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NumberOut
            // 
            this.NumberOut.Location = new System.Drawing.Point(158, 115);
            this.NumberOut.Mask = "+7(999) 000-0000";
            this.NumberOut.Name = "NumberOut";
            this.NumberOut.Size = new System.Drawing.Size(100, 20);
            this.NumberOut.TabIndex = 1;
            // 
            // NumberInc
            // 
            this.NumberInc.Location = new System.Drawing.Point(594, 115);
            this.NumberInc.Mask = "+7(999) 000-0000";
            this.NumberInc.Name = "NumberInc";
            this.NumberInc.Size = new System.Drawing.Size(100, 20);
            this.NumberInc.TabIndex = 2;
            // 
            // Heading
            // 
            this.Heading.AutoSize = true;
            this.Heading.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Heading.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Heading.ForeColor = System.Drawing.Color.Green;
            this.Heading.Location = new System.Drawing.Point(299, 28);
            this.Heading.Name = "Heading";
            this.Heading.Size = new System.Drawing.Size(232, 32);
            this.Heading.TabIndex = 3;
            this.Heading.Text = "Spammer Detection";
            // 
            // Text_OutgoingCall
            // 
            this.Text_OutgoingCall.AutoSize = true;
            this.Text_OutgoingCall.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Text_OutgoingCall.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Text_OutgoingCall.ForeColor = System.Drawing.SystemColors.Control;
            this.Text_OutgoingCall.Location = new System.Drawing.Point(157, 79);
            this.Text_OutgoingCall.Name = "Text_OutgoingCall";
            this.Text_OutgoingCall.Size = new System.Drawing.Size(103, 18);
            this.Text_OutgoingCall.TabIndex = 4;
            this.Text_OutgoingCall.Text = "Outgoing call";
            // 
            // Text_IncomingCall
            // 
            this.Text_IncomingCall.AutoSize = true;
            this.Text_IncomingCall.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Text_IncomingCall.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Text_IncomingCall.ForeColor = System.Drawing.SystemColors.Control;
            this.Text_IncomingCall.Location = new System.Drawing.Point(591, 79);
            this.Text_IncomingCall.Name = "Text_IncomingCall";
            this.Text_IncomingCall.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text_IncomingCall.Size = new System.Drawing.Size(104, 18);
            this.Text_IncomingCall.TabIndex = 5;
            this.Text_IncomingCall.Text = "Incoming call";
            // 
            // DateConnection
            // 
            this.DateConnection.Location = new System.Drawing.Point(321, 137);
            this.DateConnection.Name = "DateConnection";
            this.DateConnection.Size = new System.Drawing.Size(140, 20);
            this.DateConnection.TabIndex = 6;
            // 
            // TimeConnection
            // 
            this.TimeConnection.Location = new System.Drawing.Point(483, 137);
            this.TimeConnection.Mask = "00:00:00";
            this.TimeConnection.Name = "TimeConnection";
            this.TimeConnection.Size = new System.Drawing.Size(48, 20);
            this.TimeConnection.TabIndex = 7;
            this.TimeConnection.ValidatingType = typeof(System.DateTime);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(313, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(229, 18);
            this.label1.TabIndex = 8;
            this.label1.Text = "Date/time of connection start";
            // 
            // DurationCall
            // 
            this.DurationCall.Location = new System.Drawing.Point(391, 216);
            this.DurationCall.Name = "DurationCall";
            this.DurationCall.Size = new System.Drawing.Size(60, 20);
            this.DurationCall.TabIndex = 9;
            this.DurationCall.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(343, 181);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 18);
            this.label2.TabIndex = 10;
            this.label2.Text = "Connection duration";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(15, 372);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(190, 18);
            this.label3.TabIndex = 11;
            this.label3.Text = "Start date of the period:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(493, 372);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 18);
            this.label4.TabIndex = 12;
            this.label4.Text = "Period end date:";
            // 
            // DateStartPeriod
            // 
            this.DateStartPeriod.Location = new System.Drawing.Point(220, 372);
            this.DateStartPeriod.Name = "DateStartPeriod";
            this.DateStartPeriod.Size = new System.Drawing.Size(140, 20);
            this.DateStartPeriod.TabIndex = 13;
            // 
            // DateEndPeriod
            // 
            this.DateEndPeriod.Location = new System.Drawing.Point(642, 370);
            this.DateEndPeriod.Name = "DateEndPeriod";
            this.DateEndPeriod.Size = new System.Drawing.Size(140, 20);
            this.DateEndPeriod.TabIndex = 14;
            // 
            // ReportButton
            // 
            this.ReportButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ReportButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ReportButton.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ReportButton.Location = new System.Drawing.Point(364, 415);
            this.ReportButton.Name = "ReportButton";
            this.ReportButton.Size = new System.Drawing.Size(126, 27);
            this.ReportButton.TabIndex = 15;
            this.ReportButton.Text = "Generate a report";
            this.ReportButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ReportButton.UseVisualStyleBackColor = false;
            this.ReportButton.Click += new System.EventHandler(this.ReportButton_Click);
            // 
            // Open
            // 
            this.Open.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Open.Location = new System.Drawing.Point(28, 28);
            this.Open.Name = "Open";
            this.Open.Size = new System.Drawing.Size(75, 26);
            this.Open.TabIndex = 16;
            this.Open.Text = "Open file";
            this.Open.UseVisualStyleBackColor = true;
            this.Open.Click += new System.EventHandler(this.Open_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // PutButton
            // 
            this.PutButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PutButton.Location = new System.Drawing.Point(384, 265);
            this.PutButton.Name = "PutButton";
            this.PutButton.Size = new System.Drawing.Size(75, 23);
            this.PutButton.TabIndex = 17;
            this.PutButton.Text = "Put";
            this.PutButton.UseVisualStyleBackColor = true;
            this.PutButton.Click += new System.EventHandler(this.PutButton_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(800, 461);
            this.Controls.Add(this.PutButton);
            this.Controls.Add(this.Open);
            this.Controls.Add(this.ReportButton);
            this.Controls.Add(this.DateEndPeriod);
            this.Controls.Add(this.DateStartPeriod);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DurationCall);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TimeConnection);
            this.Controls.Add(this.DateConnection);
            this.Controls.Add(this.Text_IncomingCall);
            this.Controls.Add(this.Text_OutgoingCall);
            this.Controls.Add(this.Heading);
            this.Controls.Add(this.NumberInc);
            this.Controls.Add(this.NumberOut);
            this.Name = "MainWindow";
            this.Text = " ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox NumberOut;
        private System.Windows.Forms.MaskedTextBox NumberInc;
        private System.Windows.Forms.Label Heading;
        private System.Windows.Forms.Label Text_OutgoingCall;
        private System.Windows.Forms.Label Text_IncomingCall;
        private System.Windows.Forms.DateTimePicker DateConnection;
        private System.Windows.Forms.MaskedTextBox TimeConnection;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox DurationCall;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker DateStartPeriod;
        private System.Windows.Forms.DateTimePicker DateEndPeriod;
        private System.Windows.Forms.Button ReportButton;
        private Button Open;
        private OpenFileDialog openFileDialog1;
        private Button PutButton;
    }
}

