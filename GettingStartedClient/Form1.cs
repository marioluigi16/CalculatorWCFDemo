using GettingStartedClient.Calculatorsvc;
using System;
using System.Windows.Forms;

namespace GettingStartedClient
{
    public partial class Form1 : Form
    {
        CalculatorClient _client;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _client = new CalculatorClient();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            double val1, val2;
            GetValues(out val1, out val2);
            MessageBox.Show(_client.Add(val1, val2).ToString());
        }

        private void btnSubtract_Click(object sender, EventArgs e)
        {
            double val1, val2;
            GetValues(out val1, out val2);
            MessageBox.Show(_client.Subtract(val1, val2).ToString());
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            double val1, val2;
            GetValues(out val1, out val2);
            MessageBox.Show(_client.Multiply(val1, val2).ToString());
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            double val1, val2;
            GetValues(out val1, out val2);
            MessageBox.Show(_client.Divide(val1, val2).ToString());
        }

        private void GetValues(out double value1, out double value2)
        {
            double.TryParse(txtValue1.Text, out value1);
            double.TryParse(txtValue2.Text, out value2);
        }
    }
}
