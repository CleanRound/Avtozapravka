using System;
using System.Windows.Forms;

namespace Avtozapravka
{
    public partial class Form1 : Form
    {
        private const double PRICE_A95 = 50.0;
        private const double PRICE_A92 = 45.0;
        private const double PRICE_DIESEL = 47.0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            buttonOK.Enabled = false;
        }

        private void textBoxAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        private void textBoxAmount_TextChanged(object sender, EventArgs e)
        {
            buttonOK.Enabled = textBoxAmount.TextLength > 0 && comboBoxGasoline.SelectedIndex >= 0;
        }

        private void comboBoxGasoline_SelectedIndexChanged(object sender, EventArgs e)
        {
            buttonOK.Enabled = textBoxAmount.TextLength > 0 && comboBoxGasoline.SelectedIndex >= 0;
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            double amount;
            if (double.TryParse(textBoxAmount.Text, out amount))
            {
                double pricePerLiter = 0;

                switch (comboBoxGasoline.SelectedIndex)
                {
                    case 0: // A-95
                        pricePerLiter = PRICE_A95;
                        break;
                    case 1: // A-92
                        pricePerLiter = PRICE_A92;
                        break;
                    case 2: // Diesel
                        pricePerLiter = PRICE_DIESEL;
                        break;
                }

                int liters = (int)(amount / pricePerLiter);
                double remaining = amount - liters * pricePerLiter;

                textBoxLiters.Text = liters.ToString();
                textBoxRemaining.Text = remaining.ToString("F2");
            }
        }
    }
}
