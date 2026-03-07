namespace Aula1_Forms
{
    partial class FormCalcular
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
            btnAdicao = new Button();
            btnSubtacao = new Button();
            btnMultiplicacao = new Button();
            btnDivisao = new Button();
            txtValor1 = new TextBox();
            txtValor2 = new TextBox();
            lblResultado = new Label();
            SuspendLayout();
            // 
            // btnAdicao
            // 
            btnAdicao.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdicao.Location = new Point(67, 97);
            btnAdicao.Name = "btnAdicao";
            btnAdicao.Size = new Size(48, 48);
            btnAdicao.TabIndex = 0;
            btnAdicao.Text = "+";
            btnAdicao.UseVisualStyleBackColor = true;
            btnAdicao.Click += btnAdicao_Click;
            // 
            // btnSubtacao
            // 
            btnSubtacao.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSubtacao.Location = new Point(131, 96);
            btnSubtacao.Name = "btnSubtacao";
            btnSubtacao.Size = new Size(48, 48);
            btnSubtacao.TabIndex = 0;
            btnSubtacao.Text = "-";
            btnSubtacao.UseVisualStyleBackColor = true;
            btnSubtacao.Click += btnSubtacao_Click;
            // 
            // btnMultiplicacao
            // 
            btnMultiplicacao.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold);
            btnMultiplicacao.Location = new Point(198, 96);
            btnMultiplicacao.Name = "btnMultiplicacao";
            btnMultiplicacao.Size = new Size(48, 48);
            btnMultiplicacao.TabIndex = 0;
            btnMultiplicacao.Text = "X";
            btnMultiplicacao.UseVisualStyleBackColor = true;
            btnMultiplicacao.Click += btnMultiplicacao_Click;
            // 
            // btnDivisao
            // 
            btnDivisao.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold);
            btnDivisao.Location = new Point(264, 97);
            btnDivisao.Name = "btnDivisao";
            btnDivisao.Size = new Size(48, 48);
            btnDivisao.TabIndex = 0;
            btnDivisao.Text = "/";
            btnDivisao.UseVisualStyleBackColor = true;
            btnDivisao.Click += btnDivisao_Click;
            // 
            // txtValor1
            // 
            txtValor1.BorderStyle = BorderStyle.FixedSingle;
            txtValor1.Location = new Point(56, 180);
            txtValor1.Name = "txtValor1";
            txtValor1.PlaceholderText = "Valor A";
            txtValor1.Size = new Size(123, 23);
            txtValor1.TabIndex = 1;
            // 
            // txtValor2
            // 
            txtValor2.BorderStyle = BorderStyle.FixedSingle;
            txtValor2.Location = new Point(198, 180);
            txtValor2.Name = "txtValor2";
            txtValor2.PlaceholderText = "Valor B";
            txtValor2.Size = new Size(123, 23);
            txtValor2.TabIndex = 2;
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblResultado.Location = new Point(175, 244);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(25, 30);
            lblResultado.TabIndex = 3;
            lblResultado.Text = "0";
            // 
            // FormCalcular
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(424, 415);
            Controls.Add(lblResultado);
            Controls.Add(txtValor2);
            Controls.Add(txtValor1);
            Controls.Add(btnDivisao);
            Controls.Add(btnMultiplicacao);
            Controls.Add(btnSubtacao);
            Controls.Add(btnAdicao);
            Name = "FormCalcular";
            Text = "FormCalcular";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAdicao;
        private Button btnSubtacao;
        private Button btnMultiplicacao;
        private Button btnDivisao;
        private TextBox txtValor1;
        private TextBox txtValor2;
        private Label lblResultado;
    }
}