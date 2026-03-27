namespace PizzariaAulaForms
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
			this.btnCadastro = new System.Windows.Forms.Button();
			this.btnAtender = new System.Windows.Forms.Button();
			this.btnRemover = new System.Windows.Forms.Button();
			this.btnPosicao = new System.Windows.Forms.Button();
			this.btnOrdenar = new System.Windows.Forms.Button();
			this.btnInverter = new System.Windows.Forms.Button();
			this.btnLimpar = new System.Windows.Forms.Button();
			this.btnPedidos = new System.Windows.Forms.Button();
			this.btnAtendidos = new System.Windows.Forms.Button();
			this.pnlExibir = new System.Windows.Forms.Panel();
			this.btnFechar = new System.Windows.Forms.Button();
			this.listBox = new System.Windows.Forms.ListBox();
			this.btnAtendimento = new System.Windows.Forms.Button();
			this.pnlExibir.SuspendLayout();
			this.SuspendLayout();
			// 
			// btnCadastro
			// 
			this.btnCadastro.Location = new System.Drawing.Point(118, 32);
			this.btnCadastro.Name = "btnCadastro";
			this.btnCadastro.Size = new System.Drawing.Size(97, 38);
			this.btnCadastro.TabIndex = 0;
			this.btnCadastro.Text = "Cadastrar";
			this.btnCadastro.UseVisualStyleBackColor = true;
			this.btnCadastro.Click += new System.EventHandler(this.btnCadastro_Click);
			// 
			// btnAtender
			// 
			this.btnAtender.Location = new System.Drawing.Point(118, 76);
			this.btnAtender.Name = "btnAtender";
			this.btnAtender.Size = new System.Drawing.Size(97, 35);
			this.btnAtender.TabIndex = 1;
			this.btnAtender.Text = "Atender";
			this.btnAtender.UseVisualStyleBackColor = true;
			this.btnAtender.Click += new System.EventHandler(this.btnAtender_Click);
			// 
			// btnRemover
			// 
			this.btnRemover.Location = new System.Drawing.Point(118, 117);
			this.btnRemover.Name = "btnRemover";
			this.btnRemover.Size = new System.Drawing.Size(97, 33);
			this.btnRemover.TabIndex = 2;
			this.btnRemover.Text = "Remover";
			this.btnRemover.UseVisualStyleBackColor = true;
			this.btnRemover.Click += new System.EventHandler(this.btnRemover_Click);
			// 
			// btnPosicao
			// 
			this.btnPosicao.Location = new System.Drawing.Point(118, 156);
			this.btnPosicao.Name = "btnPosicao";
			this.btnPosicao.Size = new System.Drawing.Size(97, 35);
			this.btnPosicao.TabIndex = 3;
			this.btnPosicao.Text = "Buscar Posicao";
			this.btnPosicao.UseVisualStyleBackColor = true;
			this.btnPosicao.Click += new System.EventHandler(this.btnPosicao_Click);
			// 
			// btnOrdenar
			// 
			this.btnOrdenar.Location = new System.Drawing.Point(118, 197);
			this.btnOrdenar.Name = "btnOrdenar";
			this.btnOrdenar.Size = new System.Drawing.Size(97, 36);
			this.btnOrdenar.TabIndex = 4;
			this.btnOrdenar.Text = "Ordenar";
			this.btnOrdenar.UseVisualStyleBackColor = true;
			this.btnOrdenar.Click += new System.EventHandler(this.btnOrdenar_Click);
			// 
			// btnInverter
			// 
			this.btnInverter.Location = new System.Drawing.Point(118, 239);
			this.btnInverter.Name = "btnInverter";
			this.btnInverter.Size = new System.Drawing.Size(97, 34);
			this.btnInverter.TabIndex = 5;
			this.btnInverter.Text = "Inverter";
			this.btnInverter.UseVisualStyleBackColor = true;
			this.btnInverter.Click += new System.EventHandler(this.btnInverter_Click);
			// 
			// btnLimpar
			// 
			this.btnLimpar.Location = new System.Drawing.Point(118, 408);
			this.btnLimpar.Name = "btnLimpar";
			this.btnLimpar.Size = new System.Drawing.Size(97, 33);
			this.btnLimpar.TabIndex = 6;
			this.btnLimpar.Text = "Limpar";
			this.btnLimpar.UseVisualStyleBackColor = true;
			this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
			// 
			// btnPedidos
			// 
			this.btnPedidos.Location = new System.Drawing.Point(118, 308);
			this.btnPedidos.Name = "btnPedidos";
			this.btnPedidos.Size = new System.Drawing.Size(97, 36);
			this.btnPedidos.TabIndex = 7;
			this.btnPedidos.Text = "Pedidos";
			this.btnPedidos.UseVisualStyleBackColor = true;
			this.btnPedidos.Click += new System.EventHandler(this.btnPedidos_Click);
			// 
			// btnAtendidos
			// 
			this.btnAtendidos.Location = new System.Drawing.Point(118, 350);
			this.btnAtendidos.Name = "btnAtendidos";
			this.btnAtendidos.Size = new System.Drawing.Size(97, 32);
			this.btnAtendidos.TabIndex = 8;
			this.btnAtendidos.Text = "Atendidos";
			this.btnAtendidos.UseVisualStyleBackColor = true;
			this.btnAtendidos.Click += new System.EventHandler(this.btnAtendidos_Click);
			// 
			// pnlExibir
			// 
			this.pnlExibir.Controls.Add(this.btnFechar);
			this.pnlExibir.Controls.Add(this.listBox);
			this.pnlExibir.Location = new System.Drawing.Point(13, 32);
			this.pnlExibir.Name = "pnlExibir";
			this.pnlExibir.Size = new System.Drawing.Size(319, 409);
			this.pnlExibir.TabIndex = 9;
			this.pnlExibir.Visible = false;
			// 
			// btnFechar
			// 
			this.btnFechar.Location = new System.Drawing.Point(242, 19);
			this.btnFechar.Name = "btnFechar";
			this.btnFechar.Size = new System.Drawing.Size(35, 23);
			this.btnFechar.TabIndex = 1;
			this.btnFechar.Text = "X";
			this.btnFechar.UseVisualStyleBackColor = true;
			this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
			// 
			// listBox
			// 
			this.listBox.FormattingEnabled = true;
			this.listBox.Location = new System.Drawing.Point(36, 48);
			this.listBox.Name = "listBox";
			this.listBox.Size = new System.Drawing.Size(241, 355);
			this.listBox.TabIndex = 0;
			this.listBox.DoubleClick += new System.EventHandler(this.listBox_DoubleClick);
			// 
			// btnAtendimento
			// 
			this.btnAtendimento.Location = new System.Drawing.Point(227, 59);
			this.btnAtendimento.Name = "btnAtendimento";
			this.btnAtendimento.Size = new System.Drawing.Size(94, 35);
			this.btnAtendimento.TabIndex = 10;
			this.btnAtendimento.Text = "Atender Lista";
			this.btnAtendimento.UseVisualStyleBackColor = true;
			this.btnAtendimento.Click += new System.EventHandler(this.btnAtendimento_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(333, 453);
			this.Controls.Add(this.pnlExibir);
			this.Controls.Add(this.btnAtendidos);
			this.Controls.Add(this.btnPedidos);
			this.Controls.Add(this.btnLimpar);
			this.Controls.Add(this.btnInverter);
			this.Controls.Add(this.btnOrdenar);
			this.Controls.Add(this.btnPosicao);
			this.Controls.Add(this.btnRemover);
			this.Controls.Add(this.btnAtender);
			this.Controls.Add(this.btnCadastro);
			this.Controls.Add(this.btnAtendimento);
			this.Name = "Form1";
			this.Text = "Form1";
			this.pnlExibir.ResumeLayout(false);
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCadastro;
        private System.Windows.Forms.Button btnAtender;
        private System.Windows.Forms.Button btnRemover;
        private System.Windows.Forms.Button btnPosicao;
        private System.Windows.Forms.Button btnOrdenar;
        private System.Windows.Forms.Button btnInverter;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnPedidos;
        private System.Windows.Forms.Button btnAtendidos;
        private System.Windows.Forms.Panel pnlExibir;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.Button btnAtendimento;
    }
}

