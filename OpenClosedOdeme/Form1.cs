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
            //cmbOdeme.Items.Add("Sms ile Ödeme");
            //cmbOdeme.Items.Add("Paypal ile Ödeme");
            //cmbOdeme.Items.Add("Apple Pay");
            //cmbOdeme.Items.Add("Coin ile Ödeme");
            //cmbOdeme.Items.Add("QR Ödeme");
            //cmbOdeme.Items.Add("Nakit Ödeme");
        }
        decimal tutar = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            if (decimal.TryParse(txtTutar.Text, out tutar))
            {
                
                switch (cmbOdeme.Text)
                {
                    case "Kredi Kartý":
                        odeme = new KrediKarti();
                        break;
                    case "Mail Order":
                        odeme = new MailOrder();
                        break;
                    case "Sms ile Ödeme":
                        odeme = new Sms();
                        break;
                    case "Paypal ile Ödeme":
                        odeme = new Paypal();
                        break;
                    case "Apple Pay":
                        odeme = new ApplePay();
                        break;
                    case "Coin ile Ödeme":
                        odeme = new Coin();
                        break;
                    case "QR Ödeme":
                        odeme = new QR();
                        break;
                    case "Nakit Ödeme":
                        odeme = new Nakit();
                        break;
                }
                if (cmbOdeme.SelectedIndex != -1)
                {
                    Odeme odm = new Odeme(odeme);
                    odm.OdemeSekli(tutar);
                    MessageBox.Show("Ödeme baþarýlý bir þekilde alýndý");
                }
                else
                {
                    MessageBox.Show("geçersiz ödeme yöntemi");
                }
            }
            
            //odeme = new KrediKarti();
            //odeme.OdemeSekli();
        }
    }
}