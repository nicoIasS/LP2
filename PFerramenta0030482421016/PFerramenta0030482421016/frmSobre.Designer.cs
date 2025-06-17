namespace PFerramenta0030482421016
{
    partial class frmSobre
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSobre));
            this.lblNome1 = new System.Windows.Forms.Label();
            this.lblNome2 = new System.Windows.Forms.Label();
            this.rctBoxSobre = new System.Windows.Forms.RichTextBox();
            this.pBoxGif = new System.Windows.Forms.PictureBox();
            this.pBoxNome2 = new System.Windows.Forms.PictureBox();
            this.pBoxNome1 = new System.Windows.Forms.PictureBox();
            this.gBoxIntegrantes = new System.Windows.Forms.GroupBox();
            this.btnSair = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxGif)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxNome2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxNome1)).BeginInit();
            this.gBoxIntegrantes.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNome1
            // 
            this.lblNome1.AutoSize = true;
            this.lblNome1.Location = new System.Drawing.Point(116, 171);
            this.lblNome1.Name = "lblNome1";
            this.lblNome1.Size = new System.Drawing.Size(71, 13);
            this.lblNome1.TabIndex = 1;
            this.lblNome1.Text = "Nicolas Leme";
            // 
            // lblNome2
            // 
            this.lblNome2.AutoSize = true;
            this.lblNome2.Location = new System.Drawing.Point(581, 171);
            this.lblNome2.Name = "lblNome2";
            this.lblNome2.Size = new System.Drawing.Size(80, 13);
            this.lblNome2.TabIndex = 2;
            this.lblNome2.Text = "Otávio Augusto";
            this.lblNome2.Click += new System.EventHandler(this.label3_Click);
            // 
            // rctBoxSobre
            // 
            this.rctBoxSobre.Location = new System.Drawing.Point(170, 46);
            this.rctBoxSobre.Name = "rctBoxSobre";
            this.rctBoxSobre.ReadOnly = true;
            this.rctBoxSobre.Size = new System.Drawing.Size(1081, 83);
            this.rctBoxSobre.TabIndex = 6;
            this.rctBoxSobre.Text = resources.GetString("rctBoxSobre.Text");
            this.rctBoxSobre.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // pBoxGif
            // 
            this.pBoxGif.Image = global::PFerramenta0030482421016.Properties.Resources.dupla;
            this.pBoxGif.Location = new System.Drawing.Point(899, 260);
            this.pBoxGif.Name = "pBoxGif";
            this.pBoxGif.Size = new System.Drawing.Size(395, 240);
            this.pBoxGif.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pBoxGif.TabIndex = 7;
            this.pBoxGif.TabStop = false;
            // 
            // pBoxNome2
            // 
            this.pBoxNome2.Image = global::PFerramenta0030482421016.Properties.Resources.gato2;
            this.pBoxNome2.Location = new System.Drawing.Point(475, 52);
            this.pBoxNome2.Name = "pBoxNome2";
            this.pBoxNome2.Size = new System.Drawing.Size(275, 444);
            this.pBoxNome2.TabIndex = 5;
            this.pBoxNome2.TabStop = false;
            this.pBoxNome2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pBoxNome1
            // 
            this.pBoxNome1.Image = global::PFerramenta0030482421016.Properties.Resources.burro;
            this.pBoxNome1.InitialImage = null;
            this.pBoxNome1.Location = new System.Drawing.Point(10, 65);
            this.pBoxNome1.Name = "pBoxNome1";
            this.pBoxNome1.Size = new System.Drawing.Size(396, 410);
            this.pBoxNome1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pBoxNome1.TabIndex = 4;
            this.pBoxNome1.TabStop = false;
            // 
            // gBoxIntegrantes
            // 
            this.gBoxIntegrantes.Controls.Add(this.pBoxNome1);
            this.gBoxIntegrantes.Controls.Add(this.pBoxNome2);
            this.gBoxIntegrantes.Location = new System.Drawing.Point(109, 135);
            this.gBoxIntegrantes.Name = "gBoxIntegrantes";
            this.gBoxIntegrantes.Size = new System.Drawing.Size(769, 539);
            this.gBoxIntegrantes.TabIndex = 8;
            this.gBoxIntegrantes.TabStop = false;
            this.gBoxIntegrantes.Text = "Integrantes";
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(962, 525);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(275, 85);
            this.btnSair.TabIndex = 9;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // frmSobre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1328, 672);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.pBoxGif);
            this.Controls.Add(this.rctBoxSobre);
            this.Controls.Add(this.lblNome2);
            this.Controls.Add(this.lblNome1);
            this.Controls.Add(this.gBoxIntegrantes);
            this.Name = "frmSobre";
            this.Text = "frmSobre";
            ((System.ComponentModel.ISupportInitialize)(this.pBoxGif)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxNome2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxNome1)).EndInit();
            this.gBoxIntegrantes.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblNome1;
        private System.Windows.Forms.Label lblNome2;
        private System.Windows.Forms.PictureBox pBoxNome1;
        private System.Windows.Forms.PictureBox pBoxNome2;
        private System.Windows.Forms.RichTextBox rctBoxSobre;
        private System.Windows.Forms.PictureBox pBoxGif;
        private System.Windows.Forms.GroupBox gBoxIntegrantes;
        private System.Windows.Forms.Button btnSair;
    }
}