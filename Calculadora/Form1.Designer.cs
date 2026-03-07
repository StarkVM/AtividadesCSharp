namespace Calculadora
{
    partial class Form1
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
            txtDisplay = new TextBox();
            btn3 = new Button();
            btnSubtacao = new Button();
            btnSoma = new Button();
            btnLimpar = new Button();
            btnResultado = new Button();
            btn0 = new Button();
            btnDivisao = new Button();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            button12 = new Button();
            SuspendLayout();
            // 
            // txtDisplay
            // 
            txtDisplay.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtDisplay.Location = new Point(24, 25);
            txtDisplay.Name = "txtDisplay";
            txtDisplay.ReadOnly = true;
            txtDisplay.RightToLeft = RightToLeft.No;
            txtDisplay.Size = new Size(248, 33);
            txtDisplay.TabIndex = 0;
            txtDisplay.TextAlign = HorizontalAlignment.Right;
            // 
            // btn3
            // 
            btn3.Location = new Point(156, 229);
            btn3.Name = "btn3";
            btn3.Size = new Size(50, 45);
            btn3.TabIndex = 1;
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = true;
            btn3.Click += btn3_Click;
            // 
            // btnSubtacao
            // 
            btnSubtacao.Location = new Point(219, 229);
            btnSubtacao.Name = "btnSubtacao";
            btnSubtacao.Size = new Size(50, 45);
            btnSubtacao.TabIndex = 1;
            btnSubtacao.Text = "-";
            btnSubtacao.UseVisualStyleBackColor = true;
            btnSubtacao.Click += btnSubtacao_Click;
            // 
            // btnSoma
            // 
            btnSoma.Location = new Point(219, 280);
            btnSoma.Name = "btnSoma";
            btnSoma.Size = new Size(50, 45);
            btnSoma.TabIndex = 1;
            btnSoma.Text = "+";
            btnSoma.UseVisualStyleBackColor = true;
            btnSoma.Click += btnSoma_Click;
            // 
            // btnLimpar
            // 
            btnLimpar.Location = new Point(24, 74);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(248, 45);
            btnLimpar.TabIndex = 1;
            btnLimpar.Text = "LIMPAR";
            btnLimpar.UseVisualStyleBackColor = true;
            btnLimpar.Click += btnLimpar_Click;
            // 
            // btnResultado
            // 
            btnResultado.Location = new Point(156, 280);
            btnResultado.Name = "btnResultado";
            btnResultado.Size = new Size(50, 45);
            btnResultado.TabIndex = 1;
            btnResultado.Text = "=";
            btnResultado.UseVisualStyleBackColor = true;
            btnResultado.Click += btnResultado_Click;
            // 
            // btn0
            // 
            btn0.Location = new Point(24, 280);
            btn0.Name = "btn0";
            btn0.Size = new Size(50, 45);
            btn0.TabIndex = 1;
            btn0.Text = "0";
            btn0.UseVisualStyleBackColor = true;
            btn0.Click += btn0_Click;
            // 
            // btnDivisao
            // 
            btnDivisao.Location = new Point(219, 127);
            btnDivisao.Name = "btnDivisao";
            btnDivisao.Size = new Size(50, 45);
            btnDivisao.TabIndex = 7;
            btnDivisao.Text = "÷\r\n";
            btnDivisao.UseVisualStyleBackColor = true;
            btnDivisao.Click += btnDivisao_Click;
            // 
            // button1
            // 
            button1.Location = new Point(24, 127);
            button1.Name = "button1";
            button1.Size = new Size(50, 45);
            button1.TabIndex = 8;
            button1.Text = "7";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(90, 176);
            button2.Name = "button2";
            button2.Size = new Size(50, 45);
            button2.TabIndex = 9;
            button2.Text = "5";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(156, 125);
            button3.Name = "button3";
            button3.Size = new Size(50, 45);
            button3.TabIndex = 10;
            button3.Text = "9";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(24, 178);
            button4.Name = "button4";
            button4.Size = new Size(50, 45);
            button4.TabIndex = 11;
            button4.Text = "4";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(24, 229);
            button5.Name = "button5";
            button5.Size = new Size(50, 45);
            button5.TabIndex = 12;
            button5.Text = "1";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Location = new Point(156, 176);
            button6.Name = "button6";
            button6.Size = new Size(50, 45);
            button6.TabIndex = 13;
            button6.Text = "6";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button7
            // 
            button7.Location = new Point(90, 127);
            button7.Name = "button7";
            button7.Size = new Size(50, 45);
            button7.TabIndex = 14;
            button7.Text = "8";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // button8
            // 
            button8.Location = new Point(90, 229);
            button8.Name = "button8";
            button8.Size = new Size(50, 45);
            button8.TabIndex = 15;
            button8.Text = "2";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // button9
            // 
            button9.Location = new Point(219, 176);
            button9.Name = "button9";
            button9.Size = new Size(50, 45);
            button9.TabIndex = 16;
            button9.Text = "x";
            button9.UseVisualStyleBackColor = true;
            button9.Click += button9_Click;
            // 
            // button12
            // 
            button12.Location = new Point(90, 280);
            button12.Name = "button12";
            button12.Size = new Size(52, 45);
            button12.TabIndex = 17;
            button12.Text = ",";
            button12.UseVisualStyleBackColor = true;
            button12.Click += button12_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(299, 349);
            Controls.Add(button12);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(btnDivisao);
            Controls.Add(btnSoma);
            Controls.Add(btnSubtacao);
            Controls.Add(btn0);
            Controls.Add(btnResultado);
            Controls.Add(btn3);
            Controls.Add(btnLimpar);
            Controls.Add(txtDisplay);
            Name = "Form1";
            RightToLeft = RightToLeft.No;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CALCULADORA";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtDisplay;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button button10;
        private Button btn3;
        private Button btnSubtacao;
        private Button button14;
        private Button button15;
        private Button btnSoma;
        private Button btnLimpar;
        private Button btnResultado;
        private Button btn0;
        private Button button11;
        private Button btnDivisao;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button12;
    }
}
