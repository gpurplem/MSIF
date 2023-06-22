namespace MSIF
{
    partial class ContatoResumo
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

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            pbFotoUsuario = new PictureBox();
            lblNomeUsuario = new Label();
            ((System.ComponentModel.ISupportInitialize)pbFotoUsuario).BeginInit();
            SuspendLayout();
            // 
            // pbFotoUsuario
            // 
            pbFotoUsuario.Location = new Point(3, 3);
            pbFotoUsuario.Name = "pbFotoUsuario";
            pbFotoUsuario.Size = new Size(82, 74);
            pbFotoUsuario.SizeMode = PictureBoxSizeMode.Zoom;
            pbFotoUsuario.TabIndex = 0;
            pbFotoUsuario.TabStop = false;
            // 
            // lblNomeUsuario
            // 
            lblNomeUsuario.AutoSize = true;
            lblNomeUsuario.Location = new Point(91, 24);
            lblNomeUsuario.Name = "lblNomeUsuario";
            lblNomeUsuario.Size = new Size(121, 25);
            lblNomeUsuario.TabIndex = 1;
            lblNomeUsuario.Text = "NomeUsuario";
            // 
            // ContatoResumo
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(lblNomeUsuario);
            Controls.Add(pbFotoUsuario);
            Name = "ContatoResumo";
            Size = new Size(400, 80);
            MouseClick += ContatoResumo_MouseClick;
            ((System.ComponentModel.ISupportInitialize)pbFotoUsuario).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pbFotoUsuario;
        private Label lblNomeUsuario;
    }
}
