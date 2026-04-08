namespace Aula02_Sistema
{
    partial class Pesquisar
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
			this.txtPesquisar = new System.Windows.Forms.TextBox();
			this.btnPesquisar = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// txtPesquisar
			// 
			this.txtPesquisar.ForeColor = System.Drawing.Color.Silver;
			this.txtPesquisar.Location = new System.Drawing.Point(57, 47);
			this.txtPesquisar.Name = "txtPesquisar";
			this.txtPesquisar.Size = new System.Drawing.Size(209, 20);
			this.txtPesquisar.TabIndex = 0;
			this.txtPesquisar.Text = "Nome para pesquisa";
			this.txtPesquisar.Enter += new System.EventHandler(this.txtPesquisar_Enter);
			this.txtPesquisar.Leave += new System.EventHandler(this.txtPesquisar_Leave);
			// 
			// btnPesquisar
			// 
			this.btnPesquisar.Location = new System.Drawing.Point(272, 47);
			this.btnPesquisar.Name = "btnPesquisar";
			this.btnPesquisar.Size = new System.Drawing.Size(80, 23);
			this.btnPesquisar.TabIndex = 1;
			this.btnPesquisar.Text = "PESQUISAR";
			this.btnPesquisar.UseVisualStyleBackColor = true;
			// 
			// Pesquisar
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(405, 450);
			this.Controls.Add(this.btnPesquisar);
			this.Controls.Add(this.txtPesquisar);
			this.Name = "Pesquisar";
			this.Text = "Pesquisar";
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPesquisar;
        private System.Windows.Forms.Button btnPesquisar;
    }
}