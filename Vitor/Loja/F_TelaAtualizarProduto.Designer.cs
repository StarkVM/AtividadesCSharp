namespace Loja
{
    partial class F_TelaAtualizarProduto
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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            button1 = new Button();
            textBox3 = new TextBox();
            dataGridView1 = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            panel1 = new Panel();
            button2 = new Button();
            label4 = new Label();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            textBox7 = new TextBox();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 117);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(177, 23);
            textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(405, 117);
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(126, 23);
            textBox2.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(429, 207);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 2;
            button1.Text = "Salvar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(12, 173);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(110, 23);
            textBox3.TabIndex = 3;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(0, 262);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.Size = new Size(543, 189);
            dataGridView1.TabIndex = 4;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(9, 99);
            label1.Name = "label1";
            label1.Size = new Size(31, 15);
            label1.TabIndex = 5;
            label1.Text = "Tipo";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(397, 99);
            label2.Name = "label2";
            label2.Size = new Size(134, 15);
            label2.TabIndex = 6;
            label2.Text = "Quantidade em estoque";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(9, 155);
            label3.Name = "label3";
            label3.Size = new Size(33, 15);
            label3.TabIndex = 7;
            label3.Text = "Valor";
            // 
            // panel1
            // 
            panel1.Controls.Add(button2);
            panel1.Controls.Add(label4);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(543, 75);
            panel1.TabIndex = 8;
            panel1.Paint += panel1_Paint;
            // 
            // button2
            // 
            button2.Location = new Point(465, 3);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 1;
            button2.Text = "Voltar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(204, 35);
            label4.Name = "label4";
            label4.Size = new Size(104, 15);
            label4.TabIndex = 0;
            label4.Text = "Cadastar Produtos";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(9, 219);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(177, 23);
            textBox4.TabIndex = 3;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(204, 117);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(177, 23);
            textBox5.TabIndex = 3;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(204, 219);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(177, 23);
            textBox6.TabIndex = 3;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(204, 173);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(177, 23);
            textBox7.TabIndex = 3;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 201);
            label5.Name = "label5";
            label5.Size = new Size(26, 15);
            label5.TabIndex = 7;
            label5.Text = "Cor";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(204, 99);
            label6.Name = "label6";
            label6.Size = new Size(57, 15);
            label6.TabIndex = 7;
            label6.Text = "Tamanho";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(204, 155);
            label7.Name = "label7";
            label7.Size = new Size(40, 15);
            label7.TabIndex = 7;
            label7.Text = "Marca";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(204, 201);
            label8.Name = "label8";
            label8.Size = new Size(113, 15);
            label8.TabIndex = 7;
            label8.Text = "Quantidade minima";
            // 
            // F_TelaAtualizarProduto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(543, 450);
            Controls.Add(panel1);
            Controls.Add(label6);
            Controls.Add(label7);
            Controls.Add(label8);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Controls.Add(textBox7);
            Controls.Add(textBox5);
            Controls.Add(textBox6);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(button1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Name = "F_TelaAtualizarProduto";
            Text = "F_TelaAtualizarProduto";
            Load += F_TelaCadastroProduto_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
		private TextBox textBox2;
		private Button button1;
		private TextBox textBox3;
		private DataGridView dataGridView1;
		private Label label1;
		private Label label2;
		private Label label3;
		private Panel panel1;
		private Label label4;
		private Button button2;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
        private TextBox textBox7;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
    }
}