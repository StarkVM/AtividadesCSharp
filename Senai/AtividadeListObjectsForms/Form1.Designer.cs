namespace AtividadeListObjectsForms
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
			this.txtLogin = new System.Windows.Forms.TextBox();
			this.txtSenha = new System.Windows.Forms.TextBox();
			this.btnEntrar = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.btnCadastro = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// txtLogin
			// 
			this.txtLogin.ForeColor = System.Drawing.Color.Silver;
			this.txtLogin.Location = new System.Drawing.Point(52, 51);
			this.txtLogin.Name = "txtLogin";
			this.txtLogin.Size = new System.Drawing.Size(243, 20);
			this.txtLogin.TabIndex = 0;
			this.txtLogin.Text = "Digite o login";
			this.txtLogin.Enter += new System.EventHandler(this.txtLogin_Enter_1);
			this.txtLogin.Leave += new System.EventHandler(this.txtLogin_Leave_1);
			// 
			// txtSenha
			// 
			this.txtSenha.ForeColor = System.Drawing.Color.Silver;
			this.txtSenha.Location = new System.Drawing.Point(52, 102);
			this.txtSenha.Name = "txtSenha";
			this.txtSenha.Size = new System.Drawing.Size(243, 20);
			this.txtSenha.TabIndex = 1;
			this.txtSenha.Text = "Digite a senha";
			this.txtSenha.Enter += new System.EventHandler(this.txtSenha_Enter_1);
			this.txtSenha.Leave += new System.EventHandler(this.txtSenha_Leave_1);
			// 
			// btnEntrar
			// 
			this.btnEntrar.Location = new System.Drawing.Point(126, 165);
			this.btnEntrar.Name = "btnEntrar";
			this.btnEntrar.Size = new System.Drawing.Size(87, 34);
			this.btnEntrar.TabIndex = 2;
			this.btnEntrar.Text = "ENTRAR";
			this.btnEntrar.UseVisualStyleBackColor = true;
			this.btnEntrar.Click += new System.EventHandler(this.btnEntrar_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(52, 32);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(33, 13);
			this.label1.TabIndex = 3;
			this.label1.Text = "Login";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(52, 83);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(38, 13);
			this.label2.TabIndex = 4;
			this.label2.Text = "Senha";
			// 
			// btnCadastro
			// 
			this.btnCadastro.Location = new System.Drawing.Point(126, 206);
			this.btnCadastro.Name = "btnCadastro";
			this.btnCadastro.Size = new System.Drawing.Size(87, 34);
			this.btnCadastro.TabIndex = 5;
			this.btnCadastro.Text = "CADASTRO";
			this.btnCadastro.UseVisualStyleBackColor = true;
			this.btnCadastro.Click += new System.EventHandler(this.btnCadastro_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(356, 450);
			this.Controls.Add(this.btnCadastro);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnEntrar);
			this.Controls.Add(this.txtSenha);
			this.Controls.Add(this.txtLogin);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Button btnEntrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCadastro;
    }
}

