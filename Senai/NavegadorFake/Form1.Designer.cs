namespace NavegadorFake
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
			this.txtPesquisa = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.lblSiteAtual = new System.Windows.Forms.Label();
			this.btnVoltar = new System.Windows.Forms.Button();
			this.btnAvancar = new System.Windows.Forms.Button();
			this.btnIr = new System.Windows.Forms.Button();
			this.btnHistorico = new System.Windows.Forms.Button();
			this.pnlHistorico = new System.Windows.Forms.Panel();
			this.listBox = new System.Windows.Forms.ListBox();
			this.btnFechar = new System.Windows.Forms.Button();
			this.pnlHistorico.SuspendLayout();
			this.SuspendLayout();
			// 
			// txtPesquisa
			// 
			this.txtPesquisa.Location = new System.Drawing.Point(206, 12);
			this.txtPesquisa.Name = "txtPesquisa";
			this.txtPesquisa.Size = new System.Drawing.Size(350, 20);
			this.txtPesquisa.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(131, 162);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(151, 25);
			this.label1.TabIndex = 1;
			this.label1.Text = "Seu site atual é: ";
			// 
			// lblSiteAtual
			// 
			this.lblSiteAtual.AutoSize = true;
			this.lblSiteAtual.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblSiteAtual.Location = new System.Drawing.Point(288, 162);
			this.lblSiteAtual.Name = "lblSiteAtual";
			this.lblSiteAtual.Size = new System.Drawing.Size(64, 25);
			this.lblSiteAtual.TabIndex = 2;
			this.lblSiteAtual.Text = "label2";
			// 
			// btnVoltar
			// 
			this.btnVoltar.Location = new System.Drawing.Point(86, 10);
			this.btnVoltar.Name = "btnVoltar";
			this.btnVoltar.Size = new System.Drawing.Size(38, 26);
			this.btnVoltar.TabIndex = 3;
			this.btnVoltar.Text = "<";
			this.btnVoltar.UseVisualStyleBackColor = true;
			this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
			// 
			// btnAvancar
			// 
			this.btnAvancar.Location = new System.Drawing.Point(130, 9);
			this.btnAvancar.Name = "btnAvancar";
			this.btnAvancar.Size = new System.Drawing.Size(38, 27);
			this.btnAvancar.TabIndex = 4;
			this.btnAvancar.Text = ">";
			this.btnAvancar.UseVisualStyleBackColor = true;
			this.btnAvancar.Click += new System.EventHandler(this.btnAvancar_Click);
			// 
			// btnIr
			// 
			this.btnIr.Location = new System.Drawing.Point(582, 9);
			this.btnIr.Name = "btnIr";
			this.btnIr.Size = new System.Drawing.Size(49, 27);
			this.btnIr.TabIndex = 5;
			this.btnIr.Text = "Ir";
			this.btnIr.UseVisualStyleBackColor = true;
			this.btnIr.Click += new System.EventHandler(this.btnIr_Click);
			// 
			// btnHistorico
			// 
			this.btnHistorico.Location = new System.Drawing.Point(637, 9);
			this.btnHistorico.Name = "btnHistorico";
			this.btnHistorico.Size = new System.Drawing.Size(75, 27);
			this.btnHistorico.TabIndex = 6;
			this.btnHistorico.Text = "Historico";
			this.btnHistorico.UseVisualStyleBackColor = true;
			this.btnHistorico.Click += new System.EventHandler(this.btnHistorico_Click);
			// 
			// pnlHistorico
			// 
			this.pnlHistorico.Controls.Add(this.btnFechar);
			this.pnlHistorico.Controls.Add(this.listBox);
			this.pnlHistorico.Location = new System.Drawing.Point(74, 9);
			this.pnlHistorico.Name = "pnlHistorico";
			this.pnlHistorico.Size = new System.Drawing.Size(652, 429);
			this.pnlHistorico.TabIndex = 7;
			this.pnlHistorico.Visible = false;
			// 
			// listBox
			// 
			this.listBox.FormattingEnabled = true;
			this.listBox.Location = new System.Drawing.Point(12, 3);
			this.listBox.Name = "listBox";
			this.listBox.Size = new System.Drawing.Size(597, 420);
			this.listBox.TabIndex = 0;
			// 
			// btnFechar
			// 
			this.btnFechar.Location = new System.Drawing.Point(615, 3);
			this.btnFechar.Name = "btnFechar";
			this.btnFechar.Size = new System.Drawing.Size(22, 23);
			this.btnFechar.TabIndex = 1;
			this.btnFechar.Text = "X";
			this.btnFechar.UseVisualStyleBackColor = true;
			this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.pnlHistorico);
			this.Controls.Add(this.btnHistorico);
			this.Controls.Add(this.btnIr);
			this.Controls.Add(this.btnAvancar);
			this.Controls.Add(this.btnVoltar);
			this.Controls.Add(this.lblSiteAtual);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txtPesquisa);
			this.Name = "Form1";
			this.Text = "Form1";
			this.pnlHistorico.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPesquisa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblSiteAtual;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Button btnAvancar;
        private System.Windows.Forms.Button btnIr;
        private System.Windows.Forms.Button btnHistorico;
        private System.Windows.Forms.Panel pnlHistorico;
        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.Button btnFechar;
    }
}

