namespace Aula02_Sistema
{
    partial class F_TelaPrincipal
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F_TelaPrincipal));
			this.lblMensagem = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.txtBairro = new System.Windows.Forms.TextBox();
			this.txtCidade = new System.Windows.Forms.TextBox();
			this.txtNome = new System.Windows.Forms.TextBox();
			this.txtEstado = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.btnCadastrar = new System.Windows.Forms.Button();
			this.btnLogOff = new System.Windows.Forms.Button();
			this.btnLimpar = new System.Windows.Forms.Button();
			this.panel1 = new System.Windows.Forms.Panel();
			this.label5 = new System.Windows.Forms.Label();
			this.btnExibir = new System.Windows.Forms.Button();
			this.cbEstado = new System.Windows.Forms.ComboBox();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// lblMensagem
			// 
			this.lblMensagem.AutoSize = true;
			this.lblMensagem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblMensagem.ForeColor = System.Drawing.Color.White;
			this.lblMensagem.Location = new System.Drawing.Point(4, 29);
			this.lblMensagem.Name = "lblMensagem";
			this.lblMensagem.Size = new System.Drawing.Size(43, 17);
			this.lblMensagem.TabIndex = 0;
			this.lblMensagem.Text = "label1";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(49, 72);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(57, 21);
			this.label1.TabIndex = 1;
			this.label1.Text = "Nome";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(45, 114);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(63, 21);
			this.label2.TabIndex = 2;
			this.label2.Text = "Cidade";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(45, 165);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(56, 21);
			this.label3.TabIndex = 3;
			this.label3.Text = "Bairro";
			// 
			// txtBairro
			// 
			this.txtBairro.Location = new System.Drawing.Point(130, 168);
			this.txtBairro.MaxLength = 45;
			this.txtBairro.Name = "txtBairro";
			this.txtBairro.Size = new System.Drawing.Size(220, 20);
			this.txtBairro.TabIndex = 4;
			// 
			// txtCidade
			// 
			this.txtCidade.Location = new System.Drawing.Point(130, 117);
			this.txtCidade.MaxLength = 45;
			this.txtCidade.Name = "txtCidade";
			this.txtCidade.Size = new System.Drawing.Size(220, 20);
			this.txtCidade.TabIndex = 5;
			// 
			// txtNome
			// 
			this.txtNome.Location = new System.Drawing.Point(130, 68);
			this.txtNome.MaxLength = 45;
			this.txtNome.Name = "txtNome";
			this.txtNome.Size = new System.Drawing.Size(220, 20);
			this.txtNome.TabIndex = 6;
			// 
			// txtEstado
			// 
			this.txtEstado.Location = new System.Drawing.Point(-34, 227);
			this.txtEstado.MaxLength = 2;
			this.txtEstado.Name = "txtEstado";
			this.txtEstado.Size = new System.Drawing.Size(33, 20);
			this.txtEstado.TabIndex = 7;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(45, 205);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(61, 21);
			this.label4.TabIndex = 8;
			this.label4.Text = "Estado";
			// 
			// btnCadastrar
			// 
			this.btnCadastrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCadastrar.Image")));
			this.btnCadastrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnCadastrar.Location = new System.Drawing.Point(380, 68);
			this.btnCadastrar.Name = "btnCadastrar";
			this.btnCadastrar.Size = new System.Drawing.Size(111, 32);
			this.btnCadastrar.TabIndex = 9;
			this.btnCadastrar.Text = "CADASTRAR";
			this.btnCadastrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnCadastrar.UseVisualStyleBackColor = true;
			this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
			// 
			// btnLogOff
			// 
			this.btnLogOff.Image = ((System.Drawing.Image)(resources.GetObject("btnLogOff.Image")));
			this.btnLogOff.Location = new System.Drawing.Point(460, 4);
			this.btnLogOff.Name = "btnLogOff";
			this.btnLogOff.Size = new System.Drawing.Size(31, 32);
			this.btnLogOff.TabIndex = 10;
			this.btnLogOff.UseVisualStyleBackColor = true;
			this.btnLogOff.Click += new System.EventHandler(this.btnLogOff_Click);
			// 
			// btnLimpar
			// 
			this.btnLimpar.Image = ((System.Drawing.Image)(resources.GetObject("btnLimpar.Image")));
			this.btnLimpar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnLimpar.Location = new System.Drawing.Point(380, 117);
			this.btnLimpar.Name = "btnLimpar";
			this.btnLimpar.Size = new System.Drawing.Size(111, 32);
			this.btnLimpar.TabIndex = 11;
			this.btnLimpar.Text = "LIMPAR";
			this.btnLimpar.UseVisualStyleBackColor = true;
			this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.MidnightBlue;
			this.panel1.Controls.Add(this.label5);
			this.panel1.Controls.Add(this.lblMensagem);
			this.panel1.Controls.Add(this.btnLogOff);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(503, 50);
			this.panel1.TabIndex = 12;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.BackColor = System.Drawing.Color.Transparent;
			this.label5.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.ForeColor = System.Drawing.Color.White;
			this.label5.Location = new System.Drawing.Point(3, 4);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(192, 25);
			this.label5.TabIndex = 1;
			this.label5.Text = "Cadastro de Clientes";
			// 
			// btnExibir
			// 
			this.btnExibir.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnExibir.Location = new System.Drawing.Point(380, 219);
			this.btnExibir.Name = "btnExibir";
			this.btnExibir.Size = new System.Drawing.Size(111, 33);
			this.btnExibir.TabIndex = 13;
			this.btnExibir.Text = "EXIBIR";
			this.btnExibir.UseVisualStyleBackColor = true;
			this.btnExibir.Click += new System.EventHandler(this.btnExibir_Click);
			// 
			// cbEstado
			// 
			this.cbEstado.FormattingEnabled = true;
			this.cbEstado.Items.AddRange(new object[] {
            "Acre (AC)",
            "Amapá (AP)",
            "Amazonas (AM)",
            "Pará (PA)",
            "Rondônia (RO)",
            "Roraima (RR)",
            "Tocantins (TO) ",
            "Região Nordeste ",
            "Alagoas (AL)",
            "Bahia (BA)",
            "Ceará (CE)",
            "Maranhão (MA)",
            "Paraíba (PB)",
            "Pernambuco (PE)",
            "Piauí (PI)",
            "Rio Grande do Norte (RN)",
            "Sergipe (SE) ",
            "Distrito Federal (DF) - Capital Federal",
            "Goiás (GO)",
            "Mato Grosso (MT)",
            "Mato Grosso do Sul (MS) ",
            "Espírito Santo (ES)",
            "Minas Gerais (MG)",
            "Rio de Janeiro (RJ)",
            "São Paulo (SP)",
            "Região Sul ",
            "Paraná (PR)",
            "Rio Grande do Sul (RS)",
            "Santa Catarina (SC)"});
			this.cbEstado.Location = new System.Drawing.Point(130, 208);
			this.cbEstado.Name = "cbEstado";
			this.cbEstado.Size = new System.Drawing.Size(121, 21);
			this.cbEstado.TabIndex = 14;
			// 
			// F_TelaPrincipal
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(503, 264);
			this.Controls.Add(this.cbEstado);
			this.Controls.Add(this.btnExibir);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.btnLimpar);
			this.Controls.Add(this.btnCadastrar);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.txtEstado);
			this.Controls.Add(this.txtNome);
			this.Controls.Add(this.txtCidade);
			this.Controls.Add(this.txtBairro);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "F_TelaPrincipal";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "F_TelaPrincipal";
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMensagem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtEstado;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Button btnLogOff;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnExibir;
        private System.Windows.Forms.ComboBox cbEstado;
    }
}