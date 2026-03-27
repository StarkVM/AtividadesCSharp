namespace AulaEstruturaForms
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
			this.btnAdd = new System.Windows.Forms.Button();
			this.btnLimpar = new System.Windows.Forms.Button();
			this.btnListar = new System.Windows.Forms.Button();
			this.btnBuscar = new System.Windows.Forms.Button();
			this.btnOrdenar = new System.Windows.Forms.Button();
			this.btnInverter = new System.Windows.Forms.Button();
			this.pnlExibir = new System.Windows.Forms.Panel();
			this.listBox = new System.Windows.Forms.ListBox();
			this.btnFechar = new System.Windows.Forms.Button();
			this.pnlExibir.SuspendLayout();
			this.SuspendLayout();
			// 
			// btnAdd
			// 
			this.btnAdd.Location = new System.Drawing.Point(134, 121);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(99, 41);
			this.btnAdd.TabIndex = 0;
			this.btnAdd.Text = "ADICIONAR";
			this.btnAdd.UseVisualStyleBackColor = true;
			this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
			// 
			// btnLimpar
			// 
			this.btnLimpar.Location = new System.Drawing.Point(134, 361);
			this.btnLimpar.Name = "btnLimpar";
			this.btnLimpar.Size = new System.Drawing.Size(99, 36);
			this.btnLimpar.TabIndex = 2;
			this.btnLimpar.Text = "LIMPAR";
			this.btnLimpar.UseVisualStyleBackColor = true;
			this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
			// 
			// btnListar
			// 
			this.btnListar.Location = new System.Drawing.Point(134, 168);
			this.btnListar.Name = "btnListar";
			this.btnListar.Size = new System.Drawing.Size(99, 40);
			this.btnListar.TabIndex = 3;
			this.btnListar.Text = "LISTAR";
			this.btnListar.UseVisualStyleBackColor = true;
			this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
			// 
			// btnBuscar
			// 
			this.btnBuscar.Location = new System.Drawing.Point(134, 214);
			this.btnBuscar.Name = "btnBuscar";
			this.btnBuscar.Size = new System.Drawing.Size(99, 42);
			this.btnBuscar.TabIndex = 4;
			this.btnBuscar.Text = "BUSCAR";
			this.btnBuscar.UseVisualStyleBackColor = true;
			this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
			// 
			// btnOrdenar
			// 
			this.btnOrdenar.Location = new System.Drawing.Point(134, 262);
			this.btnOrdenar.Name = "btnOrdenar";
			this.btnOrdenar.Size = new System.Drawing.Size(99, 43);
			this.btnOrdenar.TabIndex = 5;
			this.btnOrdenar.Text = "ORDENAR";
			this.btnOrdenar.UseVisualStyleBackColor = true;
			this.btnOrdenar.Click += new System.EventHandler(this.btnOrdenar_Click);
			// 
			// btnInverter
			// 
			this.btnInverter.Location = new System.Drawing.Point(134, 311);
			this.btnInverter.Name = "btnInverter";
			this.btnInverter.Size = new System.Drawing.Size(99, 44);
			this.btnInverter.TabIndex = 6;
			this.btnInverter.Text = "INVERTER";
			this.btnInverter.UseVisualStyleBackColor = true;
			this.btnInverter.Click += new System.EventHandler(this.btnInverter_Click);
			// 
			// pnlExibir
			// 
			this.pnlExibir.Controls.Add(this.btnFechar);
			this.pnlExibir.Controls.Add(this.listBox);
			this.pnlExibir.Location = new System.Drawing.Point(61, 12);
			this.pnlExibir.Name = "pnlExibir";
			this.pnlExibir.Size = new System.Drawing.Size(255, 426);
			this.pnlExibir.TabIndex = 7;
			this.pnlExibir.Visible = false;
			// 
			// listBox
			// 
			this.listBox.FormattingEnabled = true;
			this.listBox.Location = new System.Drawing.Point(36, 3);
			this.listBox.Name = "listBox";
			this.listBox.Size = new System.Drawing.Size(179, 407);
			this.listBox.TabIndex = 0;
			// 
			// btnFechar
			// 
			this.btnFechar.Location = new System.Drawing.Point(221, 3);
			this.btnFechar.Name = "btnFechar";
			this.btnFechar.Size = new System.Drawing.Size(30, 23);
			this.btnFechar.TabIndex = 1;
			this.btnFechar.Text = "X";
			this.btnFechar.UseVisualStyleBackColor = true;
			this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(380, 450);
			this.Controls.Add(this.pnlExibir);
			this.Controls.Add(this.btnInverter);
			this.Controls.Add(this.btnOrdenar);
			this.Controls.Add(this.btnBuscar);
			this.Controls.Add(this.btnListar);
			this.Controls.Add(this.btnLimpar);
			this.Controls.Add(this.btnAdd);
			this.Name = "Form1";
			this.Text = "Form1";
			this.pnlExibir.ResumeLayout(false);
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnOrdenar;
        private System.Windows.Forms.Button btnInverter;
        private System.Windows.Forms.Panel pnlExibir;
        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.Button btnFechar;
    }
}

