namespace AtividadeListObjectsForms
{
    partial class F_Logado
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
			this.btnLogOut = new System.Windows.Forms.Button();
			this.lblNome = new System.Windows.Forms.Label();
			this.pnlAdmin = new System.Windows.Forms.Panel();
			this.btnExcluir = new System.Windows.Forms.Button();
			this.btnListar = new System.Windows.Forms.Button();
			this.pnlExibir = new System.Windows.Forms.Panel();
			this.listBox = new System.Windows.Forms.ListBox();
			this.btnFechar = new System.Windows.Forms.Button();
			this.pnlAdmin.SuspendLayout();
			this.pnlExibir.SuspendLayout();
			this.SuspendLayout();
			// 
			// btnLogOut
			// 
			this.btnLogOut.Location = new System.Drawing.Point(13, 13);
			this.btnLogOut.Name = "btnLogOut";
			this.btnLogOut.Size = new System.Drawing.Size(75, 35);
			this.btnLogOut.TabIndex = 0;
			this.btnLogOut.Text = "LogOut";
			this.btnLogOut.UseVisualStyleBackColor = true;
			this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
			// 
			// lblNome
			// 
			this.lblNome.AutoSize = true;
			this.lblNome.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblNome.Location = new System.Drawing.Point(120, 15);
			this.lblNome.Name = "lblNome";
			this.lblNome.Size = new System.Drawing.Size(63, 25);
			this.lblNome.TabIndex = 1;
			this.lblNome.Text = "label1";
			// 
			// pnlAdmin
			// 
			this.pnlAdmin.Controls.Add(this.btnListar);
			this.pnlAdmin.Controls.Add(this.btnExcluir);
			this.pnlAdmin.Location = new System.Drawing.Point(32, 81);
			this.pnlAdmin.Name = "pnlAdmin";
			this.pnlAdmin.Size = new System.Drawing.Size(296, 331);
			this.pnlAdmin.TabIndex = 2;
			this.pnlAdmin.Visible = false;
			// 
			// btnExcluir
			// 
			this.btnExcluir.Location = new System.Drawing.Point(20, 18);
			this.btnExcluir.Name = "btnExcluir";
			this.btnExcluir.Size = new System.Drawing.Size(94, 30);
			this.btnExcluir.TabIndex = 0;
			this.btnExcluir.Text = "EXCLUIR";
			this.btnExcluir.UseVisualStyleBackColor = true;
			this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
			// 
			// btnListar
			// 
			this.btnListar.Location = new System.Drawing.Point(20, 68);
			this.btnListar.Name = "btnListar";
			this.btnListar.Size = new System.Drawing.Size(94, 34);
			this.btnListar.TabIndex = 1;
			this.btnListar.Text = "LISTAR";
			this.btnListar.UseVisualStyleBackColor = true;
			this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
			// 
			// pnlExibir
			// 
			this.pnlExibir.Controls.Add(this.btnFechar);
			this.pnlExibir.Controls.Add(this.listBox);
			this.pnlExibir.Location = new System.Drawing.Point(416, 81);
			this.pnlExibir.Name = "pnlExibir";
			this.pnlExibir.Size = new System.Drawing.Size(303, 331);
			this.pnlExibir.TabIndex = 3;
			this.pnlExibir.Visible = false;
			// 
			// listBox
			// 
			this.listBox.FormattingEnabled = true;
			this.listBox.Location = new System.Drawing.Point(4, 4);
			this.listBox.Name = "listBox";
			this.listBox.Size = new System.Drawing.Size(258, 316);
			this.listBox.TabIndex = 0;
			this.listBox.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listBox_MouseDoubleClick);
			// 
			// btnFechar
			// 
			this.btnFechar.Location = new System.Drawing.Point(269, 18);
			this.btnFechar.Name = "btnFechar";
			this.btnFechar.Size = new System.Drawing.Size(31, 23);
			this.btnFechar.TabIndex = 1;
			this.btnFechar.Text = "X";
			this.btnFechar.UseVisualStyleBackColor = true;
			this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
			// 
			// F_Logado
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.pnlExibir);
			this.Controls.Add(this.pnlAdmin);
			this.Controls.Add(this.lblNome);
			this.Controls.Add(this.btnLogOut);
			this.Name = "F_Logado";
			this.Text = "F_Logado";
			this.pnlAdmin.ResumeLayout(false);
			this.pnlExibir.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Panel pnlAdmin;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.Panel pnlExibir;
        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.Button btnFechar;
    }
}