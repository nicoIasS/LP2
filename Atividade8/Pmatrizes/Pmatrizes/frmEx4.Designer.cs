namespace Pmatrizes
{
    partial class frmEx4
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
            this.lboxNomes = new System.Windows.Forms.ListBox();
            this.btnExe = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lboxNomes
            // 
            this.lboxNomes.FormattingEnabled = true;
            this.lboxNomes.ItemHeight = 16;
            this.lboxNomes.Location = new System.Drawing.Point(380, 47);
            this.lboxNomes.Name = "lboxNomes";
            this.lboxNomes.Size = new System.Drawing.Size(360, 356);
            this.lboxNomes.TabIndex = 3;
            this.lboxNomes.SelectedIndexChanged += new System.EventHandler(this.lboxNomes_SelectedIndexChanged);
            // 
            // btnExe
            // 
            this.btnExe.Location = new System.Drawing.Point(60, 97);
            this.btnExe.Name = "btnExe";
            this.btnExe.Size = new System.Drawing.Size(143, 117);
            this.btnExe.TabIndex = 2;
            this.btnExe.Text = "Executar";
            this.btnExe.UseVisualStyleBackColor = true;
            this.btnExe.Click += new System.EventHandler(this.btnExe_Click);
            // 
            // frmEx4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lboxNomes);
            this.Controls.Add(this.btnExe);
            this.Name = "frmEx4";
            this.Text = "frmEx4";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lboxNomes;
        private System.Windows.Forms.Button btnExe;
    }
}