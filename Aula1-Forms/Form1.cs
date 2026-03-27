namespace Aula1_Forms
{
    public partial class formAula01 : Form
    {
        public formAula01()
        {
            InitializeComponent();
        }

        private void ExibirMensagem()
        {
            MessageBox.Show("Olá, mundo!", "DDS", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ModificarTexto()
        {
            txtA.Text = "SENAI";
            txtB.Text = "Cachoeiro";

            lblTexto.Text = "Técnico em Desenvolvimento";
        }

        private void LimparCampos()
        {
            txtA.Clear();
            txtB.Clear();

            lblTexto.Text = "";
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void btnExecutar_Click_1(object sender, EventArgs e)
        {
            ModificarTexto();
        }

		private void btnCalcular_Click(object sender, EventArgs e)
		{
            FormCalcular fc = new FormCalcular();
            fc.ShowDialog();
		}

		private void button1_Click(object sender, EventArgs e)
        {
            ExibirMensagem();
        }

        private void txtB_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        
    }
}
