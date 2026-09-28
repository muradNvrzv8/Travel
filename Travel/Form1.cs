using System.Windows.Forms;

namespace Travel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var h1 = comboBox1.Text;
            var h2 = comboBox2.Text;
            var x = h1;
            h1 = h2;
            h2 = x;
            comboBox1.Text = h1;
            comboBox2.Text = h2;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var haradan = comboBox1.Text;
            var haraya = comboBox2.Text;
            var tarix = maskedTextBox1.Text;
            var saat = maskedTextBox2.Text;
            var yer = comboBox3.Text;

            var ad = textBox1.Text;
            var fin = maskedTextBox3.Text;
            var telefon = maskedTextBox4.Text;
            var email = textBox2.Text;

            if (string.IsNullOrEmpty(haradan) ||
                string.IsNullOrEmpty(haraya) ||
                string.IsNullOrEmpty(tarix) ||
                string.IsNullOrEmpty(saat) ||
                string.IsNullOrEmpty(yer) ||
                string.IsNullOrEmpty(ad) ||
                string.IsNullOrEmpty(fin) ||
                string.IsNullOrEmpty(telefon) ||
                string.IsNullOrEmpty(email))
            {
                MessageBox.Show("Xanalar tam doldurulmayib");
            }
            else if (fin.Length != 8)
            {
                MessageBox.Show("Fin 8 simvoldan ibaret olmalidir");
            }
            else if (haraya.Equals(haradan))
            {
                MessageBox.Show("Eyni seheri secmisiz");
            }
            else
            {
                listBox1.Items.Add("Sərnişin: " + ad);
                listBox1.Items.Add("FIN: " + fin);
                listBox1.Items.Add("Telefon: " + telefon);
                listBox1.Items.Add("Email: " + email);
                listBox1.Items.Add("Marşrut: " + haradan + " -> " + haraya);
                listBox1.Items.Add("Yer: " + yer);
                listBox1.Items.Add("Tarix/Saat: " + tarix + " " + saat);

                listBox1.Show();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
