namespace OpenClosedOdeme
{
    partial class Form1
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
            label1 = new Label();
            label2 = new Label();
            cmbOdeme = new ComboBox();
            txtTutar = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(62, 46);
            label1.Name = "label1";
            label1.Size = new Size(96, 15);
            label1.TabIndex = 0;
            label1.Text = "Ödeme Yöntemi:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(121, 102);
            label2.Name = "label2";
            label2.Size = new Size(37, 15);
            label2.TabIndex = 1;
            label2.Text = "Tutar:";
            // 
            // cmbOdeme
            // 
            cmbOdeme.FormattingEnabled = true;
            cmbOdeme.Items.AddRange(new object[] { "Kredi Kartı", "Mail Order", "Sms ile Ödeme", "Paypal ile Ödeme", "Apple Pay", "Coin ile Ödeme", "QR Ödeme", "Nakit Ödeme" });
            cmbOdeme.Location = new Point(181, 38);
            cmbOdeme.Name = "cmbOdeme";
            cmbOdeme.Size = new Size(121, 23);
            cmbOdeme.TabIndex = 2;
            // 
            // txtTutar
            // 
            txtTutar.Location = new Point(181, 94);
            txtTutar.Name = "txtTutar";
            txtTutar.Size = new Size(121, 23);
            txtTutar.TabIndex = 3;
            // 
            // button1
            // 
            button1.Location = new Point(227, 145);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 4;
            button1.Text = "Öde";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(454, 287);
            Controls.Add(button1);
            Controls.Add(txtTutar);
            Controls.Add(cmbOdeme);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private ComboBox cmbOdeme;
        private TextBox txtTutar;
        private Button button1;
    }
}