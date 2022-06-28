namespace calculaJurosDeMontante
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.valorParcela = new System.Windows.Forms.TextBox();
            this.taxaDeJuros = new System.Windows.Forms.TextBox();
            this.diasDeAtraso = new System.Windows.Forms.TextBox();
            this.jurosFinal = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Valor de parcela";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Taxa de juros";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tempo de atraso";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Juros do montante";
            // 
            // valorParcela
            // 
            this.valorParcela.Location = new System.Drawing.Point(118, 40);
            this.valorParcela.Name = "valorParcela";
            this.valorParcela.Size = new System.Drawing.Size(129, 20);
            this.valorParcela.TabIndex = 5;
            // 
            // taxaDeJuros
            // 
            this.taxaDeJuros.Location = new System.Drawing.Point(118, 66);
            this.taxaDeJuros.Name = "taxaDeJuros";
            this.taxaDeJuros.Size = new System.Drawing.Size(129, 20);
            this.taxaDeJuros.TabIndex = 6;
            // 
            // diasDeAtraso
            // 
            this.diasDeAtraso.Location = new System.Drawing.Point(118, 92);
            this.diasDeAtraso.Name = "diasDeAtraso";
            this.diasDeAtraso.Size = new System.Drawing.Size(129, 20);
            this.diasDeAtraso.TabIndex = 7;
            // 
            // jurosFinal
            // 
            this.jurosFinal.Location = new System.Drawing.Point(118, 118);
            this.jurosFinal.Multiline = true;
            this.jurosFinal.Name = "jurosFinal";
            this.jurosFinal.Size = new System.Drawing.Size(129, 34);
            this.jurosFinal.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(143, 158);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 36);
            this.button1.TabIndex = 10;
            this.button1.Text = "Calcula";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(288, 238);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.jurosFinal);
            this.Controls.Add(this.diasDeAtraso);
            this.Controls.Add(this.taxaDeJuros);
            this.Controls.Add(this.valorParcela);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox valorParcela;
        private System.Windows.Forms.TextBox taxaDeJuros;
        private System.Windows.Forms.TextBox diasDeAtraso;
        private System.Windows.Forms.TextBox jurosFinal;
        private System.Windows.Forms.Button button1;
    }
}

