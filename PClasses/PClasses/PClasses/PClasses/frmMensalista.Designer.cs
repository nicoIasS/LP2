namespace PClasses
{
    partial class frmMensalista
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
            this.lblMatricula = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblData = new System.Windows.Forms.Label();
            this.lblSal = new System.Windows.Forms.Label();
            this.txtMatricula = new System.Windows.Forms.TextBox();
            this.txtSal = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtData = new System.Windows.Forms.TextBox();
            this.btnInstMensPrmt = new System.Windows.Forms.Button();
            this.btnInstMensal = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblMatricula
            // 
            this.lblMatricula.AutoSize = true;
            this.lblMatricula.Location = new System.Drawing.Point(76, 46);
            this.lblMatricula.Name = "lblMatricula";
            this.lblMatricula.Size = new System.Drawing.Size(50, 13);
            this.lblMatricula.TabIndex = 0;
            this.lblMatricula.Text = "Matricula";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(76, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nome";
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Location = new System.Drawing.Point(76, 185);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(128, 13);
            this.lblData.TabIndex = 2;
            this.lblData.Text = "Data Entrada na empresa";
            // 
            // lblSal
            // 
            this.lblSal.AutoSize = true;
            this.lblSal.Location = new System.Drawing.Point(76, 137);
            this.lblSal.Name = "lblSal";
            this.lblSal.Size = new System.Drawing.Size(76, 13);
            this.lblSal.TabIndex = 3;
            this.lblSal.Text = "Salário Mensal";
            // 
            // txtMatricula
            // 
            this.txtMatricula.Location = new System.Drawing.Point(218, 39);
            this.txtMatricula.Name = "txtMatricula";
            this.txtMatricula.Size = new System.Drawing.Size(206, 20);
            this.txtMatricula.TabIndex = 4;
            // 
            // txtSal
            // 
            this.txtSal.Location = new System.Drawing.Point(218, 130);
            this.txtSal.Name = "txtSal";
            this.txtSal.Size = new System.Drawing.Size(206, 20);
            this.txtSal.TabIndex = 5;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(218, 86);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(206, 20);
            this.txtNome.TabIndex = 6;
            // 
            // txtData
            // 
            this.txtData.Location = new System.Drawing.Point(218, 178);
            this.txtData.Name = "txtData";
            this.txtData.Size = new System.Drawing.Size(206, 20);
            this.txtData.TabIndex = 7;
            // 
            // btnInstMensPrmt
            // 
            this.btnInstMensPrmt.Location = new System.Drawing.Point(327, 287);
            this.btnInstMensPrmt.Name = "btnInstMensPrmt";
            this.btnInstMensPrmt.Size = new System.Drawing.Size(134, 61);
            this.btnInstMensPrmt.TabIndex = 8;
            this.btnInstMensPrmt.Text = "Instanciar Mensalista passando parâmetros";
            this.btnInstMensPrmt.UseVisualStyleBackColor = true;
            this.btnInstMensPrmt.Click += new System.EventHandler(this.btnInstMensPrmt_Click);
            // 
            // btnInstMensal
            // 
            this.btnInstMensal.Location = new System.Drawing.Point(79, 287);
            this.btnInstMensal.Name = "btnInstMensal";
            this.btnInstMensal.Size = new System.Drawing.Size(134, 61);
            this.btnInstMensal.TabIndex = 9;
            this.btnInstMensal.Text = "Instancia Mensalista";
            this.btnInstMensal.UseVisualStyleBackColor = true;
            this.btnInstMensal.Click += new System.EventHandler(this.btnInstMensal_Click);
            // 
            // frmMensalista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 398);
            this.Controls.Add(this.btnInstMensal);
            this.Controls.Add(this.btnInstMensPrmt);
            this.Controls.Add(this.txtData);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.txtSal);
            this.Controls.Add(this.txtMatricula);
            this.Controls.Add(this.lblSal);
            this.Controls.Add(this.lblData);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblMatricula);
            this.Name = "frmMensalista";
            this.Text = "frmMensalista";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMatricula;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.Label lblSal;
        private System.Windows.Forms.TextBox txtMatricula;
        private System.Windows.Forms.TextBox txtSal;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtData;
        private System.Windows.Forms.Button btnInstMensPrmt;
        private System.Windows.Forms.Button btnInstMensal;
    }
}