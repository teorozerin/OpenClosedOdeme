using OpenClosedOdeme.OdemeSekilleri;

namespace OpenClosedOdeme
{
    public partial class Form1 : Form
    {
        //string secilenOdemeSekli = " ";

        IOdeme odeme;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //cmbOdeme.Items.Add("Kredi Karti");
            //cmbOdeme.Items.Add("Mail Order");
            //cmbOdeme.Items.Add("Sms ile �deme");
            //cmbOdeme.Items.Add("Paypal ile �deme");
            //cmbOdeme.Items.Add("Apple Pay");
            //cmbOdeme.Items.Add("Coin ile �deme");
            //cmbOdeme.Items.Add("QR �deme");
            //cmbOdeme.Items.Add("Nakit �deme");
        }
        decimal tutar = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            if (decimal.TryParse(txtTutar.Text, out tutar))
            {
                
                switch (cmbOdeme.Text)
                {
                    case "Kredi Kart�":
                        odeme = new KrediKarti();
                        break;
                    case "Mail Order":
                        odeme = new MailOrder();
                        break;
                    case "Sms ile �deme":
                        odeme = new Sms();
                        break;
                    case "Paypal ile �deme":
                        odeme = new Paypal();
                        break;
                    case "Apple Pay":
                        odeme = new ApplePay();
                        break;
                    case "Coin ile �deme":
                        odeme = new Coin();
                        break;
                    case "QR �deme":
                        odeme = new QR();
                        break;
                    case "Nakit �deme":
                        odeme = new Nakit();
                        break;
                }
                if (cmbOdeme.SelectedIndex != -1)
                {
                    Odeme odm = new Odeme(odeme);
                    odm.OdemeSekli(tutar);
                    MessageBox.Show("�deme ba�ar�l� bir �ekilde al�nd�");
                }
                else
                {
                    MessageBox.Show("ge�ersiz �deme y�ntemi");
                }
            }
            
            //odeme = new KrediKarti();
            //odeme.OdemeSekli();
        }
    }
}