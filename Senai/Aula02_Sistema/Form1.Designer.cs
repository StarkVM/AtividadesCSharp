namespace Aula02_Sistema
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.btnEntrar = new System.Windows.Forms.Button();
			this.pnlBackgroundEsquerdo = new System.Windows.Forms.Panel();
			this.pcbLogo = new System.Windows.Forms.PictureBox();
			this.txtLogin = new System.Windows.Forms.TextBox();
			this.txtSenha = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.btnSair = new System.Windows.Forms.Button();
			this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
			this.btnFechar = new System.Windows.Forms.Button();
			this.btnCliqueAqui = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.pnlCadastrar = new System.Windows.Forms.Panel();
			this.panel1 = new System.Windows.Forms.Panel();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.btnCadUsuario = new System.Windows.Forms.Button();
			this.txtCadSenha = new System.Windows.Forms.TextBox();
			this.txtCadLogin = new System.Windows.Forms.TextBox();
			this.lblErro = new System.Windows.Forms.Label();
			this.pnlBackgroundEsquerdo.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pcbLogo)).BeginInit();
			this.pnlCadastrar.SuspendLayout();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// btnEntrar
			// 
			this.btnEntrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(85)))), ((int)(((byte)(160)))));
			this.btnEntrar.FlatAppearance.BorderSize = 0;
			this.btnEntrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnEntrar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnEntrar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnEntrar.Location = new System.Drawing.Point(348, 239);
			this.btnEntrar.Name = "btnEntrar";
			this.btnEntrar.Size = new System.Drawing.Size(196, 46);
			this.btnEntrar.TabIndex = 3;
			this.btnEntrar.Text = "ENTRAR";
			this.toolTip1.SetToolTip(this.btnEntrar, "Clique para entrar");
			this.btnEntrar.UseVisualStyleBackColor = false;
			this.btnEntrar.Click += new System.EventHandler(this.btnEntrar_Click);
			// 
			// pnlBackgroundEsquerdo
			// 
			this.pnlBackgroundEsquerdo.BackColor = System.Drawing.Color.Gold;
			this.pnlBackgroundEsquerdo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlBackgroundEsquerdo.BackgroundImage")));
			this.pnlBackgroundEsquerdo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.pnlBackgroundEsquerdo.Controls.Add(this.pcbLogo);
			this.pnlBackgroundEsquerdo.Location = new System.Drawing.Point(0, -2);
			this.pnlBackgroundEsquerdo.Name = "pnlBackgroundEsquerdo";
			this.pnlBackgroundEsquerdo.Size = new System.Drawing.Size(275, 396);
			this.pnlBackgroundEsquerdo.TabIndex = 1;
			// 
			// pcbLogo
			// 
			this.pcbLogo.BackColor = System.Drawing.Color.Transparent;
			this.pcbLogo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pcbLogo.BackgroundImage")));
			this.pcbLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.pcbLogo.Location = new System.Drawing.Point(64, 132);
			this.pcbLogo.Name = "pcbLogo";
			this.pcbLogo.Size = new System.Drawing.Size(146, 132);
			this.pcbLogo.TabIndex = 2;
			this.pcbLogo.TabStop = false;
			// 
			// txtLogin
			// 
			this.txtLogin.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtLogin.ForeColor = System.Drawing.Color.Silver;
			this.txtLogin.Location = new System.Drawing.Point(348, 92);
			this.txtLogin.Name = "txtLogin";
			this.txtLogin.Size = new System.Drawing.Size(196, 25);
			this.txtLogin.TabIndex = 1;
			this.txtLogin.Text = "Digite o e-mail";
			this.txtLogin.TextChanged += new System.EventHandler(this.txtLogin_TextChanged);
			this.txtLogin.Enter += new System.EventHandler(this.txtLogin_Enter);
			this.txtLogin.Leave += new System.EventHandler(this.txtLogin_Leave);
			// 
			// txtSenha
			// 
			this.txtSenha.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtSenha.ForeColor = System.Drawing.Color.Silver;
			this.txtSenha.Location = new System.Drawing.Point(348, 166);
			this.txtSenha.Name = "txtSenha";
			this.txtSenha.Size = new System.Drawing.Size(196, 25);
			this.txtSenha.TabIndex = 2;
			this.txtSenha.Text = "Digite a senha";
			this.txtSenha.TextChanged += new System.EventHandler(this.txtSenha_TextChanged);
			this.txtSenha.Enter += new System.EventHandler(this.txtSenha_Enter);
			this.txtSenha.Leave += new System.EventHandler(this.txtSenha_Leave);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(85)))), ((int)(((byte)(160)))));
			this.label1.Location = new System.Drawing.Point(345, 74);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(37, 15);
			this.label1.TabIndex = 4;
			this.label1.Text = "Login";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(85)))), ((int)(((byte)(160)))));
			this.label2.Location = new System.Drawing.Point(345, 148);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(39, 15);
			this.label2.TabIndex = 5;
			this.label2.Text = "Senha";
			// 
			// btnSair
			// 
			this.btnSair.BackColor = System.Drawing.Color.Transparent;
			this.btnSair.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSair.BackgroundImage")));
			this.btnSair.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.btnSair.FlatAppearance.BorderSize = 0;
			this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSair.Location = new System.Drawing.Point(562, 12);
			this.btnSair.Name = "btnSair";
			this.btnSair.Size = new System.Drawing.Size(30, 30);
			this.btnSair.TabIndex = 0;
			this.toolTip1.SetToolTip(this.btnSair, "Fechar o programa");
			this.btnSair.UseVisualStyleBackColor = false;
			this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
			// 
			// btnFechar
			// 
			this.btnFechar.BackColor = System.Drawing.Color.Transparent;
			this.btnFechar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnFechar.BackgroundImage")));
			this.btnFechar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.btnFechar.FlatAppearance.BorderSize = 0;
			this.btnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnFechar.Location = new System.Drawing.Point(206, 6);
			this.btnFechar.Name = "btnFechar";
			this.btnFechar.Size = new System.Drawing.Size(30, 30);
			this.btnFechar.TabIndex = 9;
			this.toolTip1.SetToolTip(this.btnFechar, "Fechar o programa");
			this.btnFechar.UseVisualStyleBackColor = false;
			this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
			// 
			// btnCliqueAqui
			// 
			this.btnCliqueAqui.BackColor = System.Drawing.Color.Transparent;
			this.btnCliqueAqui.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.btnCliqueAqui.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnCliqueAqui.FlatAppearance.BorderSize = 0;
			this.btnCliqueAqui.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
			this.btnCliqueAqui.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
			this.btnCliqueAqui.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnCliqueAqui.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCliqueAqui.ForeColor = System.Drawing.Color.DarkMagenta;
			this.btnCliqueAqui.Location = new System.Drawing.Point(400, 341);
			this.btnCliqueAqui.Name = "btnCliqueAqui";
			this.btnCliqueAqui.Size = new System.Drawing.Size(90, 23);
			this.btnCliqueAqui.TabIndex = 6;
			this.btnCliqueAqui.Text = "CLIQUE AQUI";
			this.btnCliqueAqui.UseVisualStyleBackColor = false;
			this.btnCliqueAqui.Click += new System.EventHandler(this.btnCliqueAqui_Click);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.Color.Black;
			this.label3.Location = new System.Drawing.Point(376, 322);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(139, 16);
			this.label3.TabIndex = 7;
			this.label3.Text = "Não possui cadastro?";
			this.label3.Click += new System.EventHandler(this.label3_Click);
			// 
			// pnlCadastrar
			// 
			this.pnlCadastrar.BackColor = System.Drawing.Color.Navy;
			this.pnlCadastrar.Controls.Add(this.panel1);
			this.pnlCadastrar.Location = new System.Drawing.Point(323, 74);
			this.pnlCadastrar.Name = "pnlCadastrar";
			this.pnlCadastrar.Size = new System.Drawing.Size(250, 211);
			this.pnlCadastrar.TabIndex = 8;
			this.pnlCadastrar.Visible = false;
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.White;
			this.panel1.Controls.Add(this.btnFechar);
			this.panel1.Controls.Add(this.label5);
			this.panel1.Controls.Add(this.label4);
			this.panel1.Controls.Add(this.btnCadUsuario);
			this.panel1.Controls.Add(this.txtCadSenha);
			this.panel1.Controls.Add(this.txtCadLogin);
			this.panel1.Location = new System.Drawing.Point(3, 3);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(244, 205);
			this.panel1.TabIndex = 0;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.ForeColor = System.Drawing.Color.Navy;
			this.label5.Location = new System.Drawing.Point(41, 71);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(38, 13);
			this.label5.TabIndex = 4;
			this.label5.Text = "Senha";
			this.label5.Click += new System.EventHandler(this.label5_Click);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.ForeColor = System.Drawing.Color.Navy;
			this.label4.Location = new System.Drawing.Point(41, 15);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(33, 13);
			this.label4.TabIndex = 3;
			this.label4.Text = "Login";
			// 
			// btnCadUsuario
			// 
			this.btnCadUsuario.BackColor = System.Drawing.Color.Navy;
			this.btnCadUsuario.FlatAppearance.BorderSize = 0;
			this.btnCadUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnCadUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCadUsuario.ForeColor = System.Drawing.Color.GhostWhite;
			this.btnCadUsuario.Location = new System.Drawing.Point(44, 133);
			this.btnCadUsuario.Name = "btnCadUsuario";
			this.btnCadUsuario.Size = new System.Drawing.Size(156, 37);
			this.btnCadUsuario.TabIndex = 2;
			this.btnCadUsuario.Text = "CADASTRAR";
			this.btnCadUsuario.UseVisualStyleBackColor = false;
			this.btnCadUsuario.Click += new System.EventHandler(this.btnCadUsuario_Click);
			// 
			// txtCadSenha
			// 
			this.txtCadSenha.ForeColor = System.Drawing.Color.Silver;
			this.txtCadSenha.Location = new System.Drawing.Point(41, 89);
			this.txtCadSenha.Name = "txtCadSenha";
			this.txtCadSenha.Size = new System.Drawing.Size(159, 20);
			this.txtCadSenha.TabIndex = 1;
			this.txtCadSenha.Text = "Digite a senha";
			this.txtCadSenha.Enter += new System.EventHandler(this.txtCadSenha_Enter);
			this.txtCadSenha.Leave += new System.EventHandler(this.txtCadSenha_Leave);
			// 
			// txtCadLogin
			// 
			this.txtCadLogin.ForeColor = System.Drawing.Color.Silver;
			this.txtCadLogin.Location = new System.Drawing.Point(41, 36);
			this.txtCadLogin.Name = "txtCadLogin";
			this.txtCadLogin.Size = new System.Drawing.Size(159, 20);
			this.txtCadLogin.TabIndex = 0;
			this.txtCadLogin.Text = "Digite o e-mail";
			this.txtCadLogin.Enter += new System.EventHandler(this.txtCadLogin_Enter);
			this.txtCadLogin.Leave += new System.EventHandler(this.txtCadLogin_Leave);
			// 
			// lblErro
			// 
			this.lblErro.AutoSize = true;
			this.lblErro.BackColor = System.Drawing.Color.Transparent;
			this.lblErro.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblErro.ForeColor = System.Drawing.Color.Red;
			this.lblErro.Location = new System.Drawing.Point(346, 194);
			this.lblErro.Name = "lblErro";
			this.lblErro.Size = new System.Drawing.Size(38, 13);
			this.lblErro.TabIndex = 9;
			this.lblErro.Text = "label6";
			this.lblErro.Visible = false;
			this.lblErro.Click += new System.EventHandler(this.lblErro_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(604, 386);
			this.Controls.Add(this.lblErro);
			this.Controls.Add(this.pnlCadastrar);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.btnCliqueAqui);
			this.Controls.Add(this.btnSair);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txtSenha);
			this.Controls.Add(this.txtLogin);
			this.Controls.Add(this.pnlBackgroundEsquerdo);
			this.Controls.Add(this.btnEntrar);
			this.ForeColor = System.Drawing.Color.Silver;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.Enter += new System.EventHandler(this.txtLogin_Enter);
			this.pnlBackgroundEsquerdo.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pcbLogo)).EndInit();
			this.pnlCadastrar.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEntrar;
        private System.Windows.Forms.Panel pnlBackgroundEsquerdo;
        private System.Windows.Forms.PictureBox pcbLogo;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btnCliqueAqui;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel pnlCadastrar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCadUsuario;
        private System.Windows.Forms.TextBox txtCadSenha;
        private System.Windows.Forms.TextBox txtCadLogin;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Label lblErro;
    }
}

