using System.IO;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        public decimal valor;
        public int escolha = 0;
        public Form1()
        {
            InitializeComponent();
            txtDisplay.Text = "";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += 8;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += ",";
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += 0;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += 1;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += 2;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += 3;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += 4;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += 5;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += 6;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += 9;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += 7;
        }

        private void btnSoma_Click(object sender, EventArgs e)
        {
            valor = decimal.Parse(txtDisplay.Text);
            txtDisplay.Text = "";
            escolha = 1;
        }

        private void btnSubtacao_Click(object sender, EventArgs e)
        {
            if (decimal.TryParse(txtDisplay.Text, out decimal valor2))
            {
                valor = valor2;
                txtDisplay.Text = "";
                escolha = 2;
            }
            else if (txtDisplay.Text == "")
            {
                txtDisplay.Text += "-";
            }

        }

        private void button9_Click(object sender, EventArgs e)
        {
            valor = decimal.Parse(txtDisplay.Text);
            txtDisplay.Text = "";
            escolha = 3;
        }

        private void btnDivisao_Click(object sender, EventArgs e)
        {
            valor = decimal.Parse(txtDisplay.Text);
            txtDisplay.Text = "";
            escolha = 4;
        }

        private void btnResultado_Click(object sender, EventArgs e)
        {
            switch (escolha)
            {
                case 1:
                    Somar();
                    break;
                case 2:
                    Subtrair();
                    break;
                case 3:
                    Multiplicacao();
                    break;
                case 4:
                    Divisao();
                    break;

            }

        }

        public void Somar()
        {
            decimal.TryParse(txtDisplay.Text, out decimal valor2);

            decimal resultado = valor + valor2;

            txtDisplay.Text = resultado.ToString();
            valor = 0;
        }
        public void Subtrair()
        {
            decimal.TryParse(txtDisplay.Text, out decimal valor2);

            decimal resultado = valor - valor2;

            txtDisplay.Text = resultado.ToString();

            valor = 0;
        }
        public void Multiplicacao()
        {
            decimal.TryParse(txtDisplay.Text, out decimal valor2);

            decimal resultado = valor * valor2;

            txtDisplay.Text = resultado.ToString();
            valor = 0;
        }
        public void Divisao()
        {
            decimal.TryParse(txtDisplay.Text, out decimal valor2);

            try
            {
                decimal resultado = valor / valor2;

                txtDisplay.Text = resultado.ToString();
                valor = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = "";
            valor = 0;
        }

        
    }
}
