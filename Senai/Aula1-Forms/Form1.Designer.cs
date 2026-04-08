namespace Aula1_Forms
{
    partial class formAula01
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtA = new TextBox();
            txtB = new TextBox();
            btnExecutar = new Button();
            btnLimpar = new Button();
            btnExibirMensagem = new Button();
            label1 = new Label();
            label2 = new Label();
            lblTexto = new Label();
            btnCalcular = new Button();
            SuspendLayout();
            // 
            // txtA
            // 
            txtA.BorderStyle = BorderStyle.FixedSingle;
            txtA.Location = new Point(122, 59);
            txtA.Name = "txtA";
            txtA.Size = new Size(193, 23);
            txtA.TabIndex = 0;
            // 
            // txtB
            // 
            txtB.BorderStyle = BorderStyle.FixedSingle;
            txtB.Location = new Point(122, 115);
            txtB.Name = "txtB";
            txtB.Size = new Size(193, 23);
            txtB.TabIndex = 1;
            txtB.TextChanged += txtB_TextChanged;
            // 
            // btnExecutar
            // 
            btnExecutar.Location = new Point(122, 181);
            btnExecutar.Name = "btnExecutar";
            btnExecutar.Size = new Size(93, 35);
            btnExecutar.TabIndex = 2;
            btnExecutar.Text = "EXECUTAR";
            btnExecutar.UseVisualStyleBackColor = true;
            btnExecutar.Click += btnExecutar_Click_1;
            // 
            // btnLimpar
            // 
            btnLimpar.Location = new Point(222, 181);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(93, 35);
            btnLimpar.TabIndex = 3;
            btnLimpar.Text = "LIMPAR";
            btnLimpar.UseVisualStyleBackColor = true;
            btnLimpar.Click += btnLimpar_Click;
            // 
            // btnExibirMensagem
            // 
            btnExibirMensagem.Location = new Point(122, 237);
            btnExibirMensagem.Name = "btnExibirMensagem";
            btnExibirMensagem.Size = new Size(193, 35);
            btnExibirMensagem.TabIndex = 3;
            btnExibirMensagem.Text = "EXIBIR MENSAGEM";
            btnExibirMensagem.UseVisualStyleBackColor = true;
            btnExibirMensagem.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(122, 41);
            label1.Name = "label1";
            label1.Size = new Size(15, 15);
            label1.TabIndex = 4;
            label1.Text = "A";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(122, 97);
            label2.Name = "label2";
            label2.Size = new Size(14, 15);
            label2.TabIndex = 5;
            label2.Text = "B";
            label2.Click += label2_Click;
            // 
            // lblTexto
            // 
            lblTexto.AutoSize = true;
            lblTexto.Location = new Point(177, 310);
            lblTexto.Name = "lblTexto";
            lblTexto.Size = new Size(38, 15);
            lblTexto.TabIndex = 6;
            lblTexto.Text = "label3";
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(335, 181);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(75, 35);
            btnCalcular.TabIndex = 7;
            btnCalcular.Text = "CALCULAR";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // formAula01
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGoldenrodYellow;
            ClientSize = new Size(451, 450);
            Controls.Add(btnCalcular);
            Controls.Add(lblTexto);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnExibirMensagem);
            Controls.Add(btnLimpar);
            Controls.Add(btnExecutar);
            Controls.Add(txtB);
            Controls.Add(txtA);
            Name = "formAula01";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Aula01 - Curso Técnico em DDS";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtA;
        private TextBox txtB;
        private Button btnExecutar;
        private Button btnLimpar;
        private Button btnExibirMensagem;
        private Label label1;
        private Label label2;
        private Label lblTexto;
        private Button btnCalcular;
    }
}
