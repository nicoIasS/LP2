namespace PTesteMetodos
{
    partial class frmExercicio2
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
            this.lblPalavra1 = new System.Windows.Forms.Label();
            this.lblPalavra2 = new System.Windows.Forms.Label();
            this.txtBoxPalavra1 = new System.Windows.Forms.TextBox();
            this.txtBoxPalavra2 = new System.Windows.Forms.TextBox();
            this.btnCompara = new System.Windows.Forms.Button();
            this.btnInserir1no2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblPalavra1
            // 
            this.lblPalavra1.AutoSize = true;
            this.lblPalavra1.Location = new System.Drawing.Point(64, 42);
            this.lblPalavra1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPalavra1.Name = "lblPalavra1";
            this.lblPalavra1.Size = new System.Drawing.Size(64, 16);
            this.lblPalavra1.TabIndex = 0;
            this.lblPalavra1.Text = "Palavra 1";
            // 
            // lblPalavra2
            // 
            this.lblPalavra2.AutoSize = true;
            this.lblPalavra2.Location = new System.Drawing.Point(64, 86);
            this.lblPalavra2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPalavra2.Name = "lblPalavra2";
            this.lblPalavra2.Size = new System.Drawing.Size(64, 16);
            this.lblPalavra2.TabIndex = 1;
            this.lblPalavra2.Text = "Palavra 2";
            // 
            // txtBoxPalavra1
            // 
            this.txtBoxPalavra1.Location = new System.Drawing.Point(137, 38);
            this.txtBoxPalavra1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBoxPalavra1.Name = "txtBoxPalavra1";
            this.txtBoxPalavra1.Size = new System.Drawing.Size(132, 22);
            this.txtBoxPalavra1.TabIndex = 2;
            // 
            // txtBoxPalavra2
            // 
            this.txtBoxPalavra2.Location = new System.Drawing.Point(137, 82);
            this.txtBoxPalavra2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBoxPalavra2.Name = "txtBoxPalavra2";
            this.txtBoxPalavra2.Size = new System.Drawing.Size(132, 22);
            this.txtBoxPalavra2.TabIndex = 3;
            // 
            // btnCompara
            // 
            this.btnCompara.Location = new System.Drawing.Point(68, 207);
            this.btnCompara.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCompara.Name = "btnCompara";
            this.btnCompara.Size = new System.Drawing.Size(119, 57);
            this.btnCompara.TabIndex = 4;
            this.btnCompara.Text = "Testar Iguais";
            this.btnCompara.UseVisualStyleBackColor = true;
            this.btnCompara.Click += new System.EventHandler(this.btnCompara_Click);
            // 
            // btnInserir1no2
            // 
            this.btnInserir1no2.Location = new System.Drawing.Point(229, 207);
            this.btnInserir1no2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnInserir1no2.Name = "btnInserir1no2";
            this.btnInserir1no2.Size = new System.Drawing.Size(116, 57);
            this.btnInserir1no2.TabIndex = 5;
            this.btnInserir1no2.Text = "Inserir 1º no meio do 2º";
            this.btnInserir1no2.UseVisualStyleBackColor = true;
            this.btnInserir1no2.Click += new System.EventHandler(this.btnInserir1no2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(377, 207);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 57);
            this.button1.TabIndex = 6;
            this.button1.Text = "Inserir ** no meio do 1º";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmExercicio2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 346);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnInserir1no2);
            this.Controls.Add(this.btnCompara);
            this.Controls.Add(this.txtBoxPalavra2);
            this.Controls.Add(this.txtBoxPalavra1);
            this.Controls.Add(this.lblPalavra2);
            this.Controls.Add(this.lblPalavra1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmExercicio2";
            this.Text = "frmExercicio2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPalavra1;
        private System.Windows.Forms.Label lblPalavra2;
        private System.Windows.Forms.TextBox txtBoxPalavra1;
        private System.Windows.Forms.TextBox txtBoxPalavra2;
        private System.Windows.Forms.Button btnCompara;
        private System.Windows.Forms.Button btnInserir1no2;
        private System.Windows.Forms.Button button1;
    }
}