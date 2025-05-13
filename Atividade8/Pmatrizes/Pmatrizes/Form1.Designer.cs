namespace Pmatrizes
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
            this.btnEx1 = new System.Windows.Forms.Button();
            this.btnEx2 = new System.Windows.Forms.Button();
            this.btnEx3 = new System.Windows.Forms.Button();
            this.btnEx4 = new System.Windows.Forms.Button();
            this.btnEx5 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnEx1
            // 
            this.btnEx1.Location = new System.Drawing.Point(259, 24);
            this.btnEx1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEx1.Name = "btnEx1";
            this.btnEx1.Size = new System.Drawing.Size(219, 163);
            this.btnEx1.TabIndex = 0;
            this.btnEx1.Text = "Exercício 1";
            this.btnEx1.UseVisualStyleBackColor = true;
            this.btnEx1.Click += new System.EventHandler(this.btnEx1_Click);
            // 
            // btnEx2
            // 
            this.btnEx2.Location = new System.Drawing.Point(508, 24);
            this.btnEx2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEx2.Name = "btnEx2";
            this.btnEx2.Size = new System.Drawing.Size(228, 163);
            this.btnEx2.TabIndex = 1;
            this.btnEx2.Text = "Exercício 2";
            this.btnEx2.UseVisualStyleBackColor = true;
            this.btnEx2.Click += new System.EventHandler(this.btnEx2_Click);
            // 
            // btnEx3
            // 
            this.btnEx3.Location = new System.Drawing.Point(259, 204);
            this.btnEx3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEx3.Name = "btnEx3";
            this.btnEx3.Size = new System.Drawing.Size(219, 156);
            this.btnEx3.TabIndex = 2;
            this.btnEx3.Text = "Exercício 3";
            this.btnEx3.UseVisualStyleBackColor = true;
            this.btnEx3.Click += new System.EventHandler(this.btnEx3_Click);
            // 
            // btnEx4
            // 
            this.btnEx4.Location = new System.Drawing.Point(508, 204);
            this.btnEx4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEx4.Name = "btnEx4";
            this.btnEx4.Size = new System.Drawing.Size(228, 156);
            this.btnEx4.TabIndex = 3;
            this.btnEx4.Text = "Exercício 4";
            this.btnEx4.UseVisualStyleBackColor = true;
            this.btnEx4.Click += new System.EventHandler(this.btnEx4_Click);
            // 
            // btnEx5
            // 
            this.btnEx5.Location = new System.Drawing.Point(381, 368);
            this.btnEx5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEx5.Name = "btnEx5";
            this.btnEx5.Size = new System.Drawing.Size(240, 163);
            this.btnEx5.TabIndex = 4;
            this.btnEx5.Text = "Exercício 5";
            this.btnEx5.UseVisualStyleBackColor = true;
            this.btnEx5.Click += new System.EventHandler(this.btnEx5_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.btnEx5);
            this.Controls.Add(this.btnEx4);
            this.Controls.Add(this.btnEx3);
            this.Controls.Add(this.btnEx2);
            this.Controls.Add(this.btnEx1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnEx1;
        private System.Windows.Forms.Button btnEx2;
        private System.Windows.Forms.Button btnEx3;
        private System.Windows.Forms.Button btnEx4;
        private System.Windows.Forms.Button btnEx5;
    }
}

