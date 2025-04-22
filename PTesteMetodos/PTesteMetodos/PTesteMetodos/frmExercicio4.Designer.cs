namespace PTesteMetodos
{
    partial class frmExercicio4
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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.btnNumbCnt = new System.Windows.Forms.Button();
            this.btn1Char = new System.Windows.Forms.Button();
            this.btnCntLetra = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(83, 43);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(315, 125);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // btnNumbCnt
            // 
            this.btnNumbCnt.Location = new System.Drawing.Point(83, 218);
            this.btnNumbCnt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnNumbCnt.Name = "btnNumbCnt";
            this.btnNumbCnt.Size = new System.Drawing.Size(100, 66);
            this.btnNumbCnt.TabIndex = 1;
            this.btnNumbCnt.Text = "Conta Números";
            this.btnNumbCnt.UseVisualStyleBackColor = true;
            this.btnNumbCnt.Click += new System.EventHandler(this.btnNumbCnt_Click);
            // 
            // btn1Char
            // 
            this.btn1Char.Location = new System.Drawing.Point(191, 218);
            this.btn1Char.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn1Char.Name = "btn1Char";
            this.btn1Char.Size = new System.Drawing.Size(100, 66);
            this.btn1Char.TabIndex = 2;
            this.btn1Char.Text = "Posição 1º caracter branco";
            this.btn1Char.UseVisualStyleBackColor = true;
            this.btn1Char.Click += new System.EventHandler(this.btn1Char_Click);
            // 
            // btnCntLetra
            // 
            this.btnCntLetra.Location = new System.Drawing.Point(299, 218);
            this.btnCntLetra.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCntLetra.Name = "btnCntLetra";
            this.btnCntLetra.Size = new System.Drawing.Size(100, 66);
            this.btnCntLetra.TabIndex = 3;
            this.btnCntLetra.Text = "Conta Letras";
            this.btnCntLetra.UseVisualStyleBackColor = true;
            this.btnCntLetra.Click += new System.EventHandler(this.btnCntLetra_Click);
            // 
            // frmExercicio4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 299);
            this.Controls.Add(this.btnCntLetra);
            this.Controls.Add(this.btn1Char);
            this.Controls.Add(this.btnNumbCnt);
            this.Controls.Add(this.richTextBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmExercicio4";
            this.Text = "frmExercicio4";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button btnNumbCnt;
        private System.Windows.Forms.Button btn1Char;
        private System.Windows.Forms.Button btnCntLetra;
    }
}