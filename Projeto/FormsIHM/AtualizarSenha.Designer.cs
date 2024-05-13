namespace Projeto
{
    partial class AtualizarSenha
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AtualizarSenha));
            this.lblAtualizarSenha = new System.Windows.Forms.Label();
            this.lblDigitarSenha = new System.Windows.Forms.Label();
            this.lbDigiteNovamente = new System.Windows.Forms.Label();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.lbLimpar = new System.Windows.Forms.Button();
            this.txtPrimeiraSenha = new System.Windows.Forms.TextBox();
            this.txtConfirmarSenha = new System.Windows.Forms.TextBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAtualizarSenha
            // 
            this.lblAtualizarSenha.AutoSize = true;
            this.lblAtualizarSenha.Location = new System.Drawing.Point(377, 56);
            this.lblAtualizarSenha.Name = "lblAtualizarSenha";
            this.lblAtualizarSenha.Size = new System.Drawing.Size(81, 13);
            this.lblAtualizarSenha.TabIndex = 7;
            this.lblAtualizarSenha.Text = "Atualizar Senha";
            // 
            // lblDigitarSenha
            // 
            this.lblDigitarSenha.AutoSize = true;
            this.lblDigitarSenha.Location = new System.Drawing.Point(359, 104);
            this.lblDigitarSenha.Name = "lblDigitarSenha";
            this.lblDigitarSenha.Size = new System.Drawing.Size(113, 13);
            this.lblDigitarSenha.TabIndex = 8;
            this.lblDigitarSenha.Text = "Digite sua nova senha";
            // 
            // lbDigiteNovamente
            // 
            this.lbDigiteNovamente.AutoSize = true;
            this.lbDigiteNovamente.Location = new System.Drawing.Point(344, 194);
            this.lbDigiteNovamente.Name = "lbDigiteNovamente";
            this.lbDigiteNovamente.Size = new System.Drawing.Size(169, 13);
            this.lbDigiteNovamente.TabIndex = 9;
            this.lbDigiteNovamente.Text = "Digite novamente sua nova senha";
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Location = new System.Drawing.Point(303, 336);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(75, 23);
            this.btnConfirmar.TabIndex = 10;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // lbLimpar
            // 
            this.lbLimpar.Location = new System.Drawing.Point(438, 336);
            this.lbLimpar.Name = "lbLimpar";
            this.lbLimpar.Size = new System.Drawing.Size(75, 23);
            this.lbLimpar.TabIndex = 11;
            this.lbLimpar.Text = "Limpar";
            this.lbLimpar.UseVisualStyleBackColor = true;
            this.lbLimpar.Click += new System.EventHandler(this.lbLimpar_Click);
            // 
            // txtPrimeiraSenha
            // 
            this.txtPrimeiraSenha.Location = new System.Drawing.Point(362, 145);
            this.txtPrimeiraSenha.Name = "txtPrimeiraSenha";
            this.txtPrimeiraSenha.Size = new System.Drawing.Size(100, 20);
            this.txtPrimeiraSenha.TabIndex = 12;
            // 
            // txtConfirmarSenha
            // 
            this.txtConfirmarSenha.Location = new System.Drawing.Point(362, 229);
            this.txtConfirmarSenha.Name = "txtConfirmarSenha";
            this.txtConfirmarSenha.Size = new System.Drawing.Size(100, 20);
            this.txtConfirmarSenha.TabIndex = 13;
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
            this.pictureBox3.TabIndex = 6;
            this.pictureBox3.TabStop = false;
            // 
            // AtualizarSenha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtConfirmarSenha);
            this.Controls.Add(this.txtPrimeiraSenha);
            this.Controls.Add(this.lbLimpar);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.lbDigiteNovamente);
            this.Controls.Add(this.lblDigitarSenha);
            this.Controls.Add(this.lblAtualizarSenha);
            this.Controls.Add(this.pictureBox3);
            this.Name = "AtualizarSenha";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label lblAtualizarSenha;
        private System.Windows.Forms.Label lblDigitarSenha;
        private System.Windows.Forms.Label lbDigiteNovamente;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.Button lbLimpar;
        private System.Windows.Forms.TextBox txtPrimeiraSenha;
        private System.Windows.Forms.TextBox txtConfirmarSenha;
    }
}