namespace Aula02_Sistema
{
    partial class ExibirUsuarios
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
			this.lblNome = new System.Windows.Forms.Label();
			this.lblBairro = new System.Windows.Forms.Label();
			this.lblCidade = new System.Windows.Forms.Label();
			this.lblEstado = new System.Windows.Forms.Label();
			this.lblContagem = new System.Windows.Forms.Label();
			this.btnAvancar = new System.Windows.Forms.Button();
			this.btnVoltar = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.btnBack = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// lblNome
			// 
			this.lblNome.AutoSize = true;
			this.lblNome.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblNome.Location = new System.Drawing.Point(258, 95);
			this.lblNome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblNome.Name = "lblNome";
			this.lblNome.Size = new System.Drawing.Size(41, 17);
			this.lblNome.TabIndex = 0;
			this.lblNome.Text = "label1";
			// 
			// lblBairro
			// 
			this.lblBairro.AutoSize = true;
			this.lblBairro.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblBairro.Location = new System.Drawing.Point(258, 158);
			this.lblBairro.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblBairro.Name = "lblBairro";
			this.lblBairro.Size = new System.Drawing.Size(43, 17);
			this.lblBairro.TabIndex = 1;
			this.lblBairro.Text = "label2";
			// 
			// lblCidade
			// 
			this.lblCidade.AutoSize = true;
			this.lblCidade.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblCidade.Location = new System.Drawing.Point(258, 229);
			this.lblCidade.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblCidade.Name = "lblCidade";
			this.lblCidade.Size = new System.Drawing.Size(43, 17);
			this.lblCidade.TabIndex = 2;
			this.lblCidade.Text = "label3";
			// 
			// lblEstado
			// 
			this.lblEstado.AutoSize = true;
			this.lblEstado.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblEstado.Location = new System.Drawing.Point(258, 294);
			this.lblEstado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblEstado.Name = "lblEstado";
			this.lblEstado.Size = new System.Drawing.Size(43, 17);
			this.lblEstado.TabIndex = 3;
			this.lblEstado.Text = "label4";
			// 
			// lblContagem
			// 
			this.lblContagem.AutoSize = true;
			this.lblContagem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblContagem.Location = new System.Drawing.Point(210, 418);
			this.lblContagem.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblContagem.Name = "lblContagem";
			this.lblContagem.Size = new System.Drawing.Size(50, 16);
			this.lblContagem.TabIndex = 4;
			this.lblContagem.Text = "label5";
			// 
			// btnAvancar
			// 
			this.btnAvancar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAvancar.Location = new System.Drawing.Point(373, 403);
			this.btnAvancar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.btnAvancar.Name = "btnAvancar";
			this.btnAvancar.Size = new System.Drawing.Size(63, 53);
			this.btnAvancar.TabIndex = 5;
			this.btnAvancar.Text = ">";
			this.btnAvancar.UseVisualStyleBackColor = true;
			this.btnAvancar.Click += new System.EventHandler(this.btnAvancar_Click);
			// 
			// btnVoltar
			// 
			this.btnVoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnVoltar.Location = new System.Drawing.Point(39, 403);
			this.btnVoltar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.btnVoltar.Name = "btnVoltar";
			this.btnVoltar.Size = new System.Drawing.Size(63, 53);
			this.btnVoltar.TabIndex = 6;
			this.btnVoltar.Text = "<";
			this.btnVoltar.UseVisualStyleBackColor = true;
			this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(264, 418);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(32, 16);
			this.label1.TabIndex = 7;
			this.label1.Text = "/ 10";
			this.label1.Click += new System.EventHandler(this.label1_Click);
			// 
			// btnBack
			// 
			this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnBack.Location = new System.Drawing.Point(199, 480);
			this.btnBack.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.btnBack.Name = "btnBack";
			this.btnBack.Size = new System.Drawing.Size(86, 46);
			this.btnBack.TabIndex = 8;
			this.btnBack.Text = "VOLTAR";
			this.btnBack.UseVisualStyleBackColor = true;
			this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(60, 95);
			this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(47, 17);
			this.label2.TabIndex = 9;
			this.label2.Text = "NOME";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(60, 158);
			this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(55, 17);
			this.label3.TabIndex = 10;
			this.label3.Text = "BAIRRO";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(56, 229);
			this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(56, 17);
			this.label4.TabIndex = 11;
			this.label4.Text = "CIDADE";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(56, 294);
			this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(58, 17);
			this.label5.TabIndex = 12;
			this.label5.Text = "ESTADO";
			// 
			// ExibirUsuarios
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(484, 554);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.btnBack);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnVoltar);
			this.Controls.Add(this.btnAvancar);
			this.Controls.Add(this.lblContagem);
			this.Controls.Add(this.lblEstado);
			this.Controls.Add(this.lblCidade);
			this.Controls.Add(this.lblBairro);
			this.Controls.Add(this.lblNome);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.Name = "ExibirUsuarios";
			this.Text = "ExibirUsuarios";
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblBairro;
        private System.Windows.Forms.Label lblCidade;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Label lblContagem;
        private System.Windows.Forms.Button btnAvancar;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}