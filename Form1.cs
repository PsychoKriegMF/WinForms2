using System.Globalization;

namespace WinForms2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {            
            textBox1.Text = Convert.ToString(numberBox1.Value);
        }     
        private void button2_Click(object sender, EventArgs e)
        {
            CultureInfo culture = CultureInfo.CreateSpecificCulture("en-GB");
            double number;
            string s = textBox1.Text.Replace(",", ".");
            Double.TryParse(s,culture, out number);
            numberBox1.Value = number;
        }

        public void KeyUp(object sender, KeyEventArgs e)
        {
            if((!(e.KeyValue >= 0 && e.KeyValue <= 9)) || (e.KeyCode != Keys.Decimal))
            {
                e.Handled = true;
            }
        }
    }
}
