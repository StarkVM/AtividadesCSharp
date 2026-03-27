namespace AtividadeListObjectsForms
{
    partial class F_Cadastro
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
			this.txtLogin = new System.Windows.Forms.TextBox();
			this.txtNome = new System.Windows.Forms.TextBox();
			this.txtNumero = new System.Windows.Forms.TextBox();
			this.txtSenha = new System.Windows.Forms.TextBox();
			this.txtConformarSenha = new System.Windows.Forms.TextBox();
			this.cbbTipo = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.btnCadastrar = new System.Windows.Forms.Button();
			this.btnVoltar = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// txtLogin
			// 
			this.txtLogin.Location = new System.Drawing.Point(198, 48);
			this.txtLogin.Name = "txtLogin";
			this.txtLogin.Size = new System.Drawing.Size(201, 20);
			this.txtLogin.TabIndex = 0;
			// 
			// txtNome
			// 
			this.txtNome.Location = new System.Drawing.Point(405, 48);
			this.txtNome.Name = "txtNome";
			this.txtNome.Size = new System.Drawing.Size(201, 20);
			this.txtNome.TabIndex = 1;
			// 
			// txtNumero
			// 
			this.txtNumero.Location = new System.Drawing.Point(198, 99);
			this.txtNumero.Name = "txtNumero";
			this.txtNumero.Size = new System.Drawing.Size(201, 20);
			this.txtNumero.TabIndex = 2;
			// 
			// txtSenha
			// 
			this.txtSenha.Location = new System.Drawing.Point(198, 149);
			this.txtSenha.Name = "txtSenha";
			this.txtSenha.Size = new System.Drawing.Size(201, 20);
			this.txtSenha.TabIndex = 3;
			this.txtSenha.UseSystemPasswordChar = true;
			// 
			// txtConformarSenha
			// 
			this.txtConformarSenha.Location = new System.Drawing.Point(198, 204);
			this.txtConformarSenha.Name = "txtConformarSenha";
			this.txtConformarSenha.Size = new System.Drawing.Size(201, 20);
			this.txtConformarSenha.TabIndex = 4;
			this.txtConformarSenha.UseSystemPasswordChar = true;
			// 
			// cbbTipo
			// 
			this.cbbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbbTipo.FormattingEnabled = true;
			this.cbbTipo.Items.AddRange(new object[] {
            "Admin",
            "Comum"});
			this.cbbTipo.Location = new System.Drawing.Point(408, 204);
			this.cbbTipo.Name = "cbbTipo";
			this.cbbTipo.Size = new System.Drawing.Size(201, 21);
			this.cbbTipo.TabIndex = 5;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(198, 29);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(33, 13);
			this.label1.TabIndex = 6;
			this.label1.Text = "Login";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(198, 80);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 13);
			this.label2.TabIndex = 7;
			this.label2.Text = "Numero de telefone";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(198, 130);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(38, 13);
			this.label3.TabIndex = 8;
			this.label3.Text = "Senha";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(198, 185);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(85, 13);
			this.label4.TabIndex = 9;
			this.label4.Text = "Confirmar Senha";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(405, 29);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(35, 13);
			this.label5.TabIndex = 10;
			this.label5.Text = "Nome";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(405, 188);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(82, 13);
			this.label6.TabIndex = 11;
			this.label6.Text = "Tipo de Usuario";
			// 
			// btnCadastrar
			// 
			this.btnCadastrar.Location = new System.Drawing.Point(358, 296);
			this.btnCadastrar.Name = "btnCadastrar";
			this.btnCadastrar.Size = new System.Drawing.Size(91, 30);
			this.btnCadastrar.TabIndex = 12;
			this.btnCadastrar.Text = "CADASTRAR";
			this.btnCadastrar.UseVisualStyleBackColor = true;
			this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
			// 
			// btnVoltar
			// 
			this.btnVoltar.Location = new System.Drawing.Point(12, 12);
			this.btnVoltar.Name = "btnVoltar";
			this.btnVoltar.Size = new System.Drawing.Size(91, 30);
			this.btnVoltar.TabIndex = 13;
			this.btnVoltar.Text = "VOLTAR";
			this.btnVoltar.UseVisualStyleBackColor = true;
			this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
			// 
			// F_Cadastro
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.btnVoltar);
			this.Controls.Add(this.btnCadastrar);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.cbbTipo);
			this.Controls.Add(this.txtConformarSenha);
			this.Controls.Add(this.txtSenha);
			this.Controls.Add(this.txtNumero);
			this.Controls.Add(this.txtNome);
			this.Controls.Add(this.txtLogin);
			this.Name = "F_Cadastro";
			this.Text = "F_Cadastro";
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.TextBox txtConformarSenha;
        private System.Windows.Forms.ComboBox cbbTipo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Button btnVoltar;
    }
}