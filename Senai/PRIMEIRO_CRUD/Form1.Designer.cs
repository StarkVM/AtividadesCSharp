namespace PRIMEIRO_CRUD
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
            gpbCadastrarCliente = new GroupBox();
            mktTxtCpf = new MaskedTextBox();
            btnCadastrar = new Button();
            txtNome = new TextBox();
            label2 = new Label();
            label1 = new Label();
            btnListar = new Button();
            dtgDados = new DataGridView();
            codigo = new DataGridViewTextBoxColumn();
            nome = new DataGridViewTextBoxColumn();
            cpf = new DataGridViewTextBoxColumn();
            txtCodigo = new TextBox();
            btnBuscar = new Button();
            gpbCadastrarCliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgDados).BeginInit();
            SuspendLayout();
            // 
            // gpbCadastrarCliente
            // 
            gpbCadastrarCliente.Controls.Add(mktTxtCpf);
            gpbCadastrarCliente.Controls.Add(btnCadastrar);
            gpbCadastrarCliente.Controls.Add(txtNome);
            gpbCadastrarCliente.Controls.Add(label2);
            gpbCadastrarCliente.Controls.Add(label1);
            gpbCadastrarCliente.Dock = DockStyle.Top;
            gpbCadastrarCliente.Location = new Point(0, 0);
            gpbCadastrarCliente.Name = "gpbCadastrarCliente";
            gpbCadastrarCliente.Size = new Size(758, 153);
            gpbCadastrarCliente.TabIndex = 0;
            gpbCadastrarCliente.TabStop = false;
            gpbCadastrarCliente.Text = "Cadastrar Cliente";
            // 
            // mktTxtCpf
            // 
            mktTxtCpf.Font = new Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            mktTxtCpf.Location = new Point(127, 64);
            mktTxtCpf.Mask = "000\\.000\\.000-00";
            mktTxtCpf.Name = "mktTxtCpf";
            mktTxtCpf.Size = new Size(105, 22);
            mktTxtCpf.TabIndex = 4;
            // 
            // btnCadastrar
            // 
            btnCadastrar.Location = new Point(648, 22);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(75, 29);
            btnCadastrar.TabIndex = 3;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.UseVisualStyleBackColor = true;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(127, 25);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(291, 23);
            txtNome.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(71, 67);
            label2.Name = "label2";
            label2.Size = new Size(26, 15);
            label2.TabIndex = 1;
            label2.Text = "Cpf";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(71, 28);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 0;
            label1.Text = "Nome";
            // 
            // btnListar
            // 
            btnListar.Location = new Point(648, 183);
            btnListar.Name = "btnListar";
            btnListar.Size = new Size(90, 29);
            btnListar.TabIndex = 1;
            btnListar.Text = "Listar Clientes";
            btnListar.UseVisualStyleBackColor = true;
            btnListar.Click += btnListar_Click;
            // 
            // dtgDados
            // 
            dtgDados.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgDados.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dtgDados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgDados.Columns.AddRange(new DataGridViewColumn[] { codigo, nome, cpf });
            dtgDados.Dock = DockStyle.Bottom;
            dtgDados.Location = new Point(0, 218);
            dtgDados.Name = "dtgDados";
            dtgDados.Size = new Size(758, 232);
            dtgDados.TabIndex = 2;
            // 
            // codigo
            // 
            codigo.DataPropertyName = "codigo";
            codigo.HeaderText = "Codigo";
            codigo.Name = "codigo";
            // 
            // nome
            // 
            nome.DataPropertyName = "nome";
            nome.HeaderText = "Nome Do Cliente";
            nome.Name = "nome";
            // 
            // cpf
            // 
            cpf.DataPropertyName = "cpf";
            cpf.HeaderText = "CPF Cliente";
            cpf.Name = "cpf";
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new Point(24, 186);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(100, 23);
            txtCodigo.TabIndex = 3;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(132, 186);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(54, 23);
            btnBuscar.TabIndex = 4;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(758, 450);
            Controls.Add(btnBuscar);
            Controls.Add(txtCodigo);
            Controls.Add(dtgDados);
            Controls.Add(btnListar);
            Controls.Add(gpbCadastrarCliente);
            Name = "Form1";
            Text = "CRUD";
            gpbCadastrarCliente.ResumeLayout(false);
            gpbCadastrarCliente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtgDados).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox gpbCadastrarCliente;
        private Button btnCadastrar;
        private TextBox txtNome;
        private Label label2;
        private Label label1;
        private MaskedTextBox mktTxtCpf;
        private Button btnListar;
        private DataGridView dtgDados;
        private DataGridViewTextBoxColumn codigo;
        private DataGridViewTextBoxColumn nome;
        private DataGridViewTextBoxColumn cpf;
        private TextBox txtCodigo;
        private Button btnBuscar;
    }
}
