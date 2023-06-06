namespace MSIF
{
    partial class Mensagem
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblMensagemNome = new System.Windows.Forms.Label();
            this.lblMensagemCorpo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblMensagemNome
            // 
            this.lblMensagemNome.AutoSize = true;
            this.lblMensagemNome.Font = new System.Drawing.Font("Caladea", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMensagemNome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lblMensagemNome.Location = new System.Drawing.Point(2, 11);
            this.lblMensagemNome.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMensagemNome.Name = "lblMensagemNome";
            this.lblMensagemNome.Size = new System.Drawing.Size(57, 19);
            this.lblMensagemNome.TabIndex = 0;
            this.lblMensagemNome.Text = "Nome:";
            // 
            // lblMensagemCorpo
            // 
            this.lblMensagemCorpo.AutoSize = true;
            this.lblMensagemCorpo.Font = new System.Drawing.Font("Caladea", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblMensagemCorpo.ForeColor = System.Drawing.Color.White;
            this.lblMensagemCorpo.Location = new System.Drawing.Point(53, 13);
            this.lblMensagemCorpo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMensagemCorpo.Name = "lblMensagemCorpo";
            this.lblMensagemCorpo.Size = new System.Drawing.Size(65, 15);
            this.lblMensagemCorpo.TabIndex = 1;
            this.lblMensagemCorpo.Text = "mensagem";
            // 
            // Mensagem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.lblMensagemCorpo);
            this.Controls.Add(this.lblMensagemNome);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Mensagem";
            this.Size = new System.Drawing.Size(271, 42);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblMensagemNome;
        private Label lblMensagemCorpo;
    }
}
