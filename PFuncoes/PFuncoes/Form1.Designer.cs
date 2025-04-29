namespace PFuncoes
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
            this.btnSoma1 = new System.Windows.Forms.Button();
            this.btnSoma2 = new System.Windows.Forms.Button();
            this.btnSoma3 = new System.Windows.Forms.Button();
            this.btnSoma4 = new System.Windows.Forms.Button();
            this.btnSoma5 = new System.Windows.Forms.Button();
            this.btnSoma6 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSoma1
            // 
            this.btnSoma1.Location = new System.Drawing.Point(317, 191);
            this.btnSoma1.Name = "btnSoma1";
            this.btnSoma1.Size = new System.Drawing.Size(75, 23);
            this.btnSoma1.TabIndex = 0;
            this.btnSoma1.Text = "Soma1";
            this.btnSoma1.UseVisualStyleBackColor = true;
            this.btnSoma1.Click += new System.EventHandler(this.btnSoma1_Click);
            // 
            // btnSoma2
            // 
            this.btnSoma2.Location = new System.Drawing.Point(413, 191);
            this.btnSoma2.Name = "btnSoma2";
            this.btnSoma2.Size = new System.Drawing.Size(75, 23);
            this.btnSoma2.TabIndex = 1;
            this.btnSoma2.Text = "Soma2";
            this.btnSoma2.UseVisualStyleBackColor = true;
            this.btnSoma2.Click += new System.EventHandler(this.btnSoma2_Click);
            // 
            // btnSoma3
            // 
            this.btnSoma3.Location = new System.Drawing.Point(306, 220);
            this.btnSoma3.Name = "btnSoma3";
            this.btnSoma3.Size = new System.Drawing.Size(75, 23);
            this.btnSoma3.TabIndex = 2;
            this.btnSoma3.Text = "Soma3";
            this.btnSoma3.UseVisualStyleBackColor = true;
            this.btnSoma3.Click += new System.EventHandler(this.btnSoma3_Click);
            // 
            // btnSoma4
            // 
            this.btnSoma4.Location = new System.Drawing.Point(413, 220);
            this.btnSoma4.Name = "btnSoma4";
            this.btnSoma4.Size = new System.Drawing.Size(75, 23);
            this.btnSoma4.TabIndex = 3;
            this.btnSoma4.Text = "Soma4";
            this.btnSoma4.UseVisualStyleBackColor = true;
            this.btnSoma4.Click += new System.EventHandler(this.btnSoma4_Click);
            // 
            // btnSoma5
            // 
            this.btnSoma5.Location = new System.Drawing.Point(306, 249);
            this.btnSoma5.Name = "btnSoma5";
            this.btnSoma5.Size = new System.Drawing.Size(75, 23);
            this.btnSoma5.TabIndex = 4;
            this.btnSoma5.Text = "Soma5";
            this.btnSoma5.UseVisualStyleBackColor = true;
            this.btnSoma5.Click += new System.EventHandler(this.btnSoma5_Click);
            // 
            // btnSoma6
            // 
            this.btnSoma6.Location = new System.Drawing.Point(413, 249);
            this.btnSoma6.Name = "btnSoma6";
            this.btnSoma6.Size = new System.Drawing.Size(75, 23);
            this.btnSoma6.TabIndex = 5;
            this.btnSoma6.Text = "Soma6";
            this.btnSoma6.UseVisualStyleBackColor = true;
            this.btnSoma6.Click += new System.EventHandler(this.btnSoma6_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSoma6);
            this.Controls.Add(this.btnSoma5);
            this.Controls.Add(this.btnSoma4);
            this.Controls.Add(this.btnSoma3);
            this.Controls.Add(this.btnSoma2);
            this.Controls.Add(this.btnSoma1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSoma1;
        private System.Windows.Forms.Button btnSoma2;
        private System.Windows.Forms.Button btnSoma3;
        private System.Windows.Forms.Button btnSoma4;
        private System.Windows.Forms.Button btnSoma5;
        private System.Windows.Forms.Button btnSoma6;
    }
}

