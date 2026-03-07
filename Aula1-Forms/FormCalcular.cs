using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula1_Forms
{
    public partial class FormCalcular : Form
    {
        public FormCalcular()
        {
            InitializeComponent();
        }

        private void btnAdicao_Click(object sender, EventArgs e)
        {
            Somar();
        }

        private void Somar()
        {
            double.TryParse(txtValor1.Text, out double a);
            double.TryParse(txtValor2.Text, out double b);
            double r = a + b;

            lblResultado.Text = r.ToString();
        }

        private void btnSubtacao_Click(object sender, EventArgs e)
        {
            Sub();
        }

        private void Sub()
        {
            double.TryParse(txtValor1.Text, out double a);
            double.TryParse(txtValor2.Text, out double b);
            double r = a - b;

            lblResultado.Text = r.ToString();
        }

        private void btnMultiplicacao_Click(object sender, EventArgs e)
        {
            Multi();
        }

        private void Multi()
        {
            double.TryParse(txtValor1.Text, out double a);
            double.TryParse(txtValor2.Text, out double b);
            double r = a * b;

            lblResultado.Text = r.ToString();
        }

        private void btnDivisao_Click(object sender, EventArgs e)
        {

        }

        private void Div()
        {
			double.TryParse(txtValor1.Text, out double a);
			double.TryParse(txtValor2.Text, out double b);

            
            double r = a / b;
            lblResultado.Text = r.ToString();
            
		}

    }
}
