namespace Projeto
{
    partial class CriarUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CriarUsuario));
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.lbCriarConta = new System.Windows.Forms.Label();
            this.lblDigitarNovoUsuario = new System.Windows.Forms.Label();
            this.lbDigiteSuaSenha = new System.Windows.Forms.Label();
            this.lbConfirmarSenha = new System.Windows.Forms.Label();
            this.txtCorfimarSenha = new System.Windows.Forms.TextBox();
            this.txtDigitarUsuario = new System.Windows.Forms.TextBox();
            this.txtDigiteASenha = new System.Windows.Forms.TextBox();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.BtnLimpar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.BackgroundImage")));
            this.pictureBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox3.Image = global::Projeto.Properties.Resources.Smaller_Network_Connection_Background__1080p_;
            this.pictureBox3.Location = new System.Drawing.Point(0, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(800, 450);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 7;
            this.pictureBox3.TabStop = false;
            // 
            // lbCriarConta
            // 
            this.lbCriarConta.AutoSize = true;
            this.lbCriarConta.Location = new System.Drawing.Point(369, 41);
            this.lbCriarConta.Name = "lbCriarConta";
            this.lbCriarConta.Size = new System.Drawing.Size(81, 13);
            this.lbCriarConta.TabIndex = 8;
            this.lbCriarConta.Text = "Criar uma conta";
            // 
            // lblDigitarNovoUsuario
            // 
            this.lblDigitarNovoUsuario.AutoSize = true;
            this.lblDigitarNovoUsuario.Location = new System.Drawing.Point(345, 121);
            this.lblDigitarNovoUsuario.Name = "lblDigitarNovoUsuario";
            this.lblDigitarNovoUsuario.Size = new System.Drawing.Size(135, 13);
            this.lblDigitarNovoUsuario.TabIndex = 9;
            this.lblDigitarNovoUsuario.Text = "Digite seu nome de usuario";
            // 
            // lbDigiteSuaSenha
            // 
            this.lbDigiteSuaSenha.AutoSize = true;
            this.lbDigiteSuaSenha.Location = new System.Drawing.Point(369, 190);
            this.lbDigiteSuaSenha.Name = "lbDigiteSuaSenha";
            this.lbDigiteSuaSenha.Size = new System.Drawing.Size(86, 13);
            this.lbDigiteSuaSenha.TabIndex = 10;
            this.lbDigiteSuaSenha.Text = "Digite sua senha";
            // 
            // lbConfirmarSenha
            // 
            this.lbConfirmarSenha.AutoSize = true;
            this.lbConfirmarSenha.Location = new System.Drawing.Point(353, 275);
            this.lbConfirmarSenha.Name = "lbConfirmarSenha";
            this.lbConfirmarSenha.Size = new System.Drawing.Size(127, 13);
            this.lbConfirmarSenha.TabIndex = 11;
            this.lbConfirmarSenha.Text = "Confirme sua nova senha";
            // 
            // txtCorfimarSenha
            // 
            this.txtCorfimarSenha.Location = new System.Drawing.Point(356, 308);
            this.txtCorfimarSenha.Name = "txtCorfimarSenha";
            this.txtCorfimarSenha.Size = new System.Drawing.Size(100, 20);
            this.txtCorfimarSenha.TabIndex = 12;
            // 
            // txtDigitarUsuario
            // 
            this.txtDigitarUsuario.Location = new System.Drawing.Point(356, 150);
            this.txtDigitarUsuario.Name = "txtDigitarUsuario";
            this.txtDigitarUsuario.Size = new System.Drawing.Size(100, 20);
            this.txtDigitarUsuario.TabIndex = 13;
            // 
            // txtDigiteASenha
            // 
            this.txtDigiteASenha.Location = new System.Drawing.Point(356, 229);
            this.txtDigiteASenha.Name = "txtDigiteASenha";
            this.txtDigiteASenha.Size = new System.Drawing.Size(100, 20);
            this.txtDigiteASenha.TabIndex = 14;
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Location = new System.Drawing.Point(295, 371);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(75, 23);
            this.btnConfirmar.TabIndex = 15;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // BtnLimpar
            // 
            this.BtnLimpar.Location = new System.Drawing.Point(405, 371);
            this.BtnLimpar.Name = "BtnLimpar";
            this.BtnLimpar.Size = new System.Drawing.Size(75, 23);
            this.BtnLimpar.TabIndex = 16;
            this.BtnLimpar.Text = "Limpar";
            this.BtnLimpar.UseVisualStyleBackColor = true;
            this.BtnLimpar.Click += new System.EventHandler(this.BtnLimpar_Click);
            // 
            // CriarUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnLimpar);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.txtDigiteASenha);
            this.Controls.Add(this.txtDigitarUsuario);
            this.Controls.Add(this.txtCorfimarSenha);
            this.Controls.Add(this.lbConfirmarSenha);
            this.Controls.Add(this.lbDigiteSuaSenha);
            this.Controls.Add(this.lblDigitarNovoUsuario);
            this.Controls.Add(this.lbCriarConta);
            this.Controls.Add(this.pictureBox3);
            this.Name = "CriarUsuario";
            this.Text = "CriarUsuario";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label lbCriarConta;
        private System.Windows.Forms.Label lblDigitarNovoUsuario;
        private System.Windows.Forms.Label lbDigiteSuaSenha;
        private System.Windows.Forms.Label lbConfirmarSenha;
        private System.Windows.Forms.TextBox txtCorfimarSenha;
        private System.Windows.Forms.TextBox txtDigitarUsuario;
        private System.Windows.Forms.TextBox txtDigiteASenha;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.Button BtnLimpar;
    }
}