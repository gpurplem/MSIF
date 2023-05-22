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
            lblMensagemNome = new Label();
            lblMensagemCorpo = new Label();
            SuspendLayout();
            // 
            // lblMensagemNome
            // 
            lblMensagemNome.AutoSize = true;
            lblMensagemNome.Location = new Point(3, 26);
            lblMensagemNome.Name = "lblMensagemNome";
            lblMensagemNome.Size = new Size(65, 25);
            lblMensagemNome.TabIndex = 0;
            lblMensagemNome.Text = "Nome:";
            lblMensagemNome.Click += lblMensagemNome_Click;
            // 
            // lblMensagemCorpo
            // 
            lblMensagemCorpo.AutoSize = true;
            lblMensagemCorpo.Location = new Point(74, 26);
            lblMensagemCorpo.Name = "lblMensagemCorpo";
            lblMensagemCorpo.Size = new Size(100, 25);
            lblMensagemCorpo.TabIndex = 1;
            lblMensagemCorpo.Text = "mensagem";
            // 
            // Mensagem
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lblMensagemCorpo);
            Controls.Add(lblMensagemNome);
            Name = "Mensagem";
            Size = new Size(387, 78);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblMensagemNome;
        private Label lblMensagemCorpo;
    }
}
