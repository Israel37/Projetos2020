namespace CalculoPrazoObra
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
            this.button1 = new System.Windows.Forms.Button();
            this.txtDataAssinatura = new System.Windows.Forms.TextBox();
            this.txtDataTerminoObra = new System.Windows.Forms.TextBox();
            this.txtPrazoObra = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(131, 231);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(171, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Calcular";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtDataAssinatura
            // 
            this.txtDataAssinatura.Location = new System.Drawing.Point(144, 117);
            this.txtDataAssinatura.Name = "txtDataAssinatura";
            this.txtDataAssinatura.Size = new System.Drawing.Size(141, 20);
            this.txtDataAssinatura.TabIndex = 1;
            // 
            // txtDataTerminoObra
            // 
            this.txtDataTerminoObra.Location = new System.Drawing.Point(144, 68);
            this.txtDataTerminoObra.Name = "txtDataTerminoObra";
            this.txtDataTerminoObra.Size = new System.Drawing.Size(141, 20);
            this.txtDataTerminoObra.TabIndex = 2;
            // 
            // txtPrazoObra
            // 
            this.txtPrazoObra.Location = new System.Drawing.Point(144, 166);
            this.txtPrazoObra.Name = "txtPrazoObra";
            this.txtPrazoObra.Size = new System.Drawing.Size(86, 20);
            this.txtPrazoObra.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Data do Término da Obra";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Data de Assinatura";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Prazo de Obra";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(247, 173);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Meses";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(131, 269);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(171, 23);
            this.button2.TabIndex = 8;
            this.button2.Text = "Limpar Campos";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 315);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPrazoObra);
            this.Controls.Add(this.txtDataTerminoObra);
            this.Controls.Add(this.txtDataAssinatura);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Calculo Prazo de Obra";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtDataAssinatura;
        private System.Windows.Forms.TextBox txtDataTerminoObra;
        private System.Windows.Forms.TextBox txtPrazoObra;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button2;
    }
}

