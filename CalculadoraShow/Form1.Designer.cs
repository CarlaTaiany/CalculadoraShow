namespace CalculadoraShow
{
    partial class CalculadoraSimples
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CalculadoraSimples));
            this.nudNumero1 = new System.Windows.Forms.NumericUpDown();
            this.nudNumero2 = new System.Windows.Forms.NumericUpDown();
            this.rbSoma = new System.Windows.Forms.RadioButton();
            this.rbSubtracao = new System.Windows.Forms.RadioButton();
            this.rbMultiplicacao = new System.Windows.Forms.RadioButton();
            this.rbDivisao = new System.Windows.Forms.RadioButton();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.lblNumero1 = new System.Windows.Forms.Label();
            this.lblNumero2 = new System.Windows.Forms.Label();
            this.txbResultado = new System.Windows.Forms.TextBox();
            this.btnLimpar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumero1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumero2)).BeginInit();
            this.SuspendLayout();
            // 
            // nudNumero1
            // 
            this.nudNumero1.Location = new System.Drawing.Point(175, 58);
            this.nudNumero1.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nudNumero1.Name = "nudNumero1";
            this.nudNumero1.Size = new System.Drawing.Size(132, 20);
            this.nudNumero1.TabIndex = 2;
            // 
            // nudNumero2
            // 
            this.nudNumero2.Location = new System.Drawing.Point(175, 99);
            this.nudNumero2.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nudNumero2.Name = "nudNumero2";
            this.nudNumero2.Size = new System.Drawing.Size(132, 20);
            this.nudNumero2.TabIndex = 3;
            // 
            // rbSoma
            // 
            this.rbSoma.AutoSize = true;
            this.rbSoma.Location = new System.Drawing.Point(143, 150);
            this.rbSoma.Name = "rbSoma";
            this.rbSoma.Size = new System.Drawing.Size(52, 17);
            this.rbSoma.TabIndex = 4;
            this.rbSoma.Text = "Soma";
            this.rbSoma.UseVisualStyleBackColor = true;
            // 
            // rbSubtracao
            // 
            this.rbSubtracao.AutoSize = true;
            this.rbSubtracao.Location = new System.Drawing.Point(143, 184);
            this.rbSubtracao.Name = "rbSubtracao";
            this.rbSubtracao.Size = new System.Drawing.Size(74, 17);
            this.rbSubtracao.TabIndex = 5;
            this.rbSubtracao.Text = "Subtração";
            this.rbSubtracao.UseVisualStyleBackColor = true;
            // 
            // rbMultiplicacao
            // 
            this.rbMultiplicacao.AutoSize = true;
            this.rbMultiplicacao.Location = new System.Drawing.Point(143, 219);
            this.rbMultiplicacao.Name = "rbMultiplicacao";
            this.rbMultiplicacao.Size = new System.Drawing.Size(87, 17);
            this.rbMultiplicacao.TabIndex = 6;
            this.rbMultiplicacao.Text = "Multiplicação";
            this.rbMultiplicacao.UseVisualStyleBackColor = true;
            // 
            // rbDivisao
            // 
            this.rbDivisao.AutoSize = true;
            this.rbDivisao.Location = new System.Drawing.Point(143, 251);
            this.rbDivisao.Name = "rbDivisao";
            this.rbDivisao.Size = new System.Drawing.Size(60, 17);
            this.rbDivisao.TabIndex = 7;
            this.rbDivisao.Text = "Divisão";
            this.rbDivisao.UseVisualStyleBackColor = true;
            // 
            // btnCalcular
            // 
            this.btnCalcular.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnCalcular.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalcular.Font = new System.Drawing.Font("Monospac821 BT", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.Location = new System.Drawing.Point(56, 304);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(251, 46);
            this.btnCalcular.TabIndex = 9;
            this.btnCalcular.Text = "CALCULAR";
            this.btnCalcular.UseVisualStyleBackColor = false;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // lblNumero1
            // 
            this.lblNumero1.AutoSize = true;
            this.lblNumero1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumero1.Location = new System.Drawing.Point(98, 58);
            this.lblNumero1.Name = "lblNumero1";
            this.lblNumero1.Size = new System.Drawing.Size(65, 15);
            this.lblNumero1.TabIndex = 10;
            this.lblNumero1.Text = "Número 1:";
            // 
            // lblNumero2
            // 
            this.lblNumero2.AutoSize = true;
            this.lblNumero2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumero2.Location = new System.Drawing.Point(98, 99);
            this.lblNumero2.Name = "lblNumero2";
            this.lblNumero2.Size = new System.Drawing.Size(65, 15);
            this.lblNumero2.TabIndex = 11;
            this.lblNumero2.Text = "Número 2:";
            // 
            // txbResultado
            // 
            this.txbResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbResultado.Location = new System.Drawing.Point(56, 381);
            this.txbResultado.Name = "txbResultado";
            this.txbResultado.ReadOnly = true;
            this.txbResultado.Size = new System.Drawing.Size(251, 38);
            this.txbResultado.TabIndex = 12;
            this.txbResultado.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.Color.DarkGray;
            this.btnLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnLimpar.Location = new System.Drawing.Point(115, 441);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(125, 40);
            this.btnLimpar.TabIndex = 13;
            this.btnLimpar.Text = "LIMPAR";
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // CalculadoraSimples
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 532);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.txbResultado);
            this.Controls.Add(this.lblNumero2);
            this.Controls.Add(this.lblNumero1);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.rbDivisao);
            this.Controls.Add(this.rbMultiplicacao);
            this.Controls.Add(this.rbSubtracao);
            this.Controls.Add(this.rbSoma);
            this.Controls.Add(this.nudNumero2);
            this.Controls.Add(this.nudNumero1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CalculadoraSimples";
            this.Text = "CALCULADORA SIMPLES";
            ((System.ComponentModel.ISupportInitialize)(this.nudNumero1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumero2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.NumericUpDown nudNumero1;
        private System.Windows.Forms.NumericUpDown nudNumero2;
        private System.Windows.Forms.RadioButton rbSoma;
        private System.Windows.Forms.RadioButton rbSubtracao;
        private System.Windows.Forms.RadioButton rbMultiplicacao;
        private System.Windows.Forms.RadioButton rbDivisao;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label lblNumero1;
        private System.Windows.Forms.Label lblNumero2;
        private System.Windows.Forms.TextBox txbResultado;
        private System.Windows.Forms.Button btnLimpar;
    }
}

