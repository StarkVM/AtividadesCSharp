namespace Loja
{
    partial class F_TelaMovimentacao
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
            panel1 = new Panel();
            button4 = new Button();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            groupBox1 = new GroupBox();
            dateTimePicker1 = new DateTimePicker();
            button3 = new Button();
            label3 = new Label();
            label2 = new Label();
            groupBox3 = new GroupBox();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            button1 = new Button();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            groupBox2 = new GroupBox();
            radioButton5 = new RadioButton();
            radioButton4 = new RadioButton();
            radioButton3 = new RadioButton();
            label4 = new Label();
            button2 = new Button();
            label5 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(button4);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(516, 72);
            panel1.TabIndex = 0;
            // 
            // button4
            // 
            button4.Location = new Point(438, 3);
            button4.Name = "button4";
            button4.Size = new Size(75, 23);
            button4.TabIndex = 1;
            button4.Text = "Voltar";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(215, 26);
            label1.Name = "label1";
            label1.Size = new Size(92, 15);
            label1.TabIndex = 0;
            label1.Text = "Movimentacoes";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(0, 282);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(516, 170);
            dataGridView1.TabIndex = 1;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dateTimePicker1);
            groupBox1.Controls.Add(button3);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(groupBox3);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Dock = DockStyle.Top;
            groupBox1.Location = new Point(0, 72);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(516, 121);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Nova Movimentacao";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(256, 63);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 9;
            // 
            // button3
            // 
            button3.Enabled = false;
            button3.Location = new Point(337, 92);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 8;
            button3.Text = "Atualizar";
            button3.UseVisualStyleBackColor = true;
            button3.Visible = false;
            button3.Click += button3_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(256, 39);
            label3.Name = "label3";
            label3.Size = new Size(130, 15);
            label3.TabIndex = 7;
            label3.Text = "Data da movimentacao";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 19);
            label2.Name = "label2";
            label2.Size = new Size(74, 15);
            label2.TabIndex = 6;
            label2.Text = "Id do Celular";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(radioButton2);
            groupBox3.Controls.Add(radioButton1);
            groupBox3.Location = new Point(12, 65);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(217, 50);
            groupBox3.TabIndex = 5;
            groupBox3.TabStop = false;
            groupBox3.Text = "Tipo";
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(6, 22);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(65, 19);
            radioButton2.TabIndex = 4;
            radioButton2.TabStop = true;
            radioButton2.Text = "Entrada";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(117, 22);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(53, 19);
            radioButton1.TabIndex = 3;
            radioButton1.TabStop = true;
            radioButton1.Text = "Saida";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(256, 92);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 2;
            button1.Text = "Salvar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(129, 36);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 1;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 36);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(80, 23);
            textBox1.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(radioButton5);
            groupBox2.Controls.Add(radioButton4);
            groupBox2.Controls.Add(radioButton3);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(button2);
            groupBox2.Dock = DockStyle.Top;
            groupBox2.Location = new Point(0, 193);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(516, 89);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "Filtrar Dados";
            groupBox2.Enter += groupBox2_Enter;
            // 
            // radioButton5
            // 
            radioButton5.AutoSize = true;
            radioButton5.Location = new Point(173, 50);
            radioButton5.Name = "radioButton5";
            radioButton5.Size = new Size(53, 19);
            radioButton5.TabIndex = 5;
            radioButton5.TabStop = true;
            radioButton5.Text = "Saida";
            radioButton5.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            radioButton4.AutoSize = true;
            radioButton4.Location = new Point(102, 50);
            radioButton4.Name = "radioButton4";
            radioButton4.Size = new Size(65, 19);
            radioButton4.TabIndex = 4;
            radioButton4.TabStop = true;
            radioButton4.Text = "Entrada";
            radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(12, 50);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(84, 19);
            radioButton3.TabIndex = 3;
            radioButton3.TabStop = true;
            radioButton3.Text = "Exibir Tudo";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 23);
            label4.Name = "label4";
            label4.Size = new Size(39, 15);
            label4.TabIndex = 2;
            label4.Text = "Filtros";
            // 
            // button2
            // 
            button2.Location = new Point(287, 50);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 1;
            button2.Text = "Filtrar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(129, 18);
            label5.Name = "label5";
            label5.Size = new Size(67, 15);
            label5.TabIndex = 7;
            label5.Text = "quantidade";
            // 
            // F_TelaMovimentacao
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(516, 450);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(dataGridView1);
            Controls.Add(panel1);
            Name = "F_TelaMovimentacao";
            Text = "F_TelaMovimentacao";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private DataGridView dataGridView1;
        private GroupBox groupBox1;
        private GroupBox groupBox3;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private Button button1;
        private TextBox textBox2;
        private TextBox textBox1;
        private GroupBox groupBox2;
        private Label label3;
        private Label label2;
        private RadioButton radioButton5;
        private RadioButton radioButton4;
        private RadioButton radioButton3;
        private Label label4;
        private Button button2;
        private Button button3;
        private Button button4;
        private DateTimePicker dateTimePicker1;
        private Label label5;
    }
}