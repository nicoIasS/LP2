namespace PTesEventos
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
            this.lblNome = new System.Windows.Forms.Label();
            this.lblEndereco = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblCelular = new System.Windows.Forms.Label();
            this.lblDataNasc = new System.Windows.Forms.Label();
            this.lblSalario = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtCelular = new System.Windows.Forms.TextBox();
            this.mskbxSalario = new System.Windows.Forms.MaskedTextBox();
            this.mskbxDataNasc = new System.Windows.Forms.MaskedTextBox();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(40, 19);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(35, 13);
            this.lblNome.TabIndex = 8;
            this.lblNome.Text = "Nome";
            // 
            // lblEndereco
            // 
            this.lblEndereco.AutoSize = true;
            this.lblEndereco.Location = new System.Drawing.Point(40, 55);
            this.lblEndereco.Name = "lblEndereco";
            this.lblEndereco.Size = new System.Drawing.Size(53, 13);
            this.lblEndereco.TabIndex = 9;
            this.lblEndereco.Text = "Endereço";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(40, 92);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(35, 13);
            this.lblEmail.TabIndex = 10;
            this.lblEmail.Text = "E-mail";
            // 
            // lblCelular
            // 
            this.lblCelular.AutoSize = true;
            this.lblCelular.Location = new System.Drawing.Point(40, 131);
            this.lblCelular.Name = "lblCelular";
            this.lblCelular.Size = new System.Drawing.Size(39, 13);
            this.lblCelular.TabIndex = 11;
            this.lblCelular.Text = "Celular";
            // 
            // lblDataNasc
            // 
            this.lblDataNasc.AutoSize = true;
            this.lblDataNasc.Location = new System.Drawing.Point(40, 206);
            this.lblDataNasc.Name = "lblDataNasc";
            this.lblDataNasc.Size = new System.Drawing.Size(89, 13);
            this.lblDataNasc.TabIndex = 12;
            this.lblDataNasc.Text = "Data Nascimento";
            // 
            // lblSalario
            // 
            this.lblSalario.AutoSize = true;
            this.lblSalario.Location = new System.Drawing.Point(40, 244);
            this.lblSalario.Name = "lblSalario";
            this.lblSalario.Size = new System.Drawing.Size(39, 13);
            this.lblSalario.TabIndex = 13;
            this.lblSalario.Text = "Salário";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(138, 12);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(188, 20);
            this.txtNome.TabIndex = 0;
            this.txtNome.TextChanged += new System.EventHandler(this.txtNome_TextChanged);
            this.txtNome.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNome_KeyPress);
            // 
            // txtEndereco
            // 
            this.txtEndereco.Location = new System.Drawing.Point(138, 48);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(188, 20);
            this.txtEndereco.TabIndex = 1;
            this.txtEndereco.Validating += new System.ComponentModel.CancelEventHandler(this.txtEndereco_Validating);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(138, 85);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(188, 20);
            this.txtEmail.TabIndex = 2;
            this.txtEmail.Validated += new System.EventHandler(this.txtEmail_Validated);
            // 
            // txtCelular
            // 
            this.txtCelular.Location = new System.Drawing.Point(138, 124);
            this.txtCelular.Name = "txtCelular";
            this.txtCelular.Size = new System.Drawing.Size(188, 20);
            this.txtCelular.TabIndex = 4;
            this.txtCelular.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCelular_KeyPress);
            // 
            // mskbxSalario
            // 
            this.mskbxSalario.Location = new System.Drawing.Point(138, 237);
            this.mskbxSalario.Mask = "99990.00";
            this.mskbxSalario.Name = "mskbxSalario";
            this.mskbxSalario.Size = new System.Drawing.Size(100, 20);
            this.mskbxSalario.TabIndex = 6;
            this.mskbxSalario.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mskbxSalario_MaskInputRejected);
            this.mskbxSalario.Validated += new System.EventHandler(this.mskbxSalario_Validated);
            // 
            // mskbxDataNasc
            // 
            this.mskbxDataNasc.Location = new System.Drawing.Point(138, 203);
            this.mskbxDataNasc.Mask = "00/00/0000";
            this.mskbxDataNasc.Name = "mskbxDataNasc";
            this.mskbxDataNasc.Size = new System.Drawing.Size(100, 20);
            this.mskbxDataNasc.TabIndex = 5;
            this.mskbxDataNasc.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mskbxDataNasc_MaskInputRejected);
            this.mskbxDataNasc.Leave += new System.EventHandler(this.mskbxDataNasc_Leave);
            this.mskbxDataNasc.Validated += new System.EventHandler(this.mskbxDataNasc_Validated);
            // 
            // btnEnviar
            // 
            this.btnEnviar.Location = new System.Drawing.Point(218, 286);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(163, 58);
            this.btnEnviar.TabIndex = 7;
            this.btnEnviar.Text = "Enviar Dados";
            this.btnEnviar.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 356);
            this.Controls.Add(this.btnEnviar);
            this.Controls.Add(this.mskbxDataNasc);
            this.Controls.Add(this.mskbxSalario);
            this.Controls.Add(this.txtCelular);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtEndereco);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblSalario);
            this.Controls.Add(this.lblDataNasc);
            this.Controls.Add(this.lblCelular);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblEndereco);
            this.Controls.Add(this.lblNome);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblEndereco;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblCelular;
        private System.Windows.Forms.Label lblDataNasc;
        private System.Windows.Forms.Label lblSalario;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtCelular;
        private System.Windows.Forms.MaskedTextBox mskbxSalario;
        private System.Windows.Forms.MaskedTextBox mskbxDataNasc;
        private System.Windows.Forms.Button btnEnviar;
    }
}

