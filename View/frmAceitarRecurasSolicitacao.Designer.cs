namespace MSIF.View
{
    partial class frmAceitarRecurasSolicitacao
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
            btnSolicitacaoAceitar = new Button();
            btnSolicitacaoRejeitar = new Button();
            SuspendLayout();
            // 
            // btnSolicitacaoAceitar
            // 
            btnSolicitacaoAceitar.Location = new Point(12, 42);
            btnSolicitacaoAceitar.Name = "btnSolicitacaoAceitar";
            btnSolicitacaoAceitar.Size = new Size(112, 34);
            btnSolicitacaoAceitar.TabIndex = 0;
            btnSolicitacaoAceitar.Text = "Aceitar";
            btnSolicitacaoAceitar.UseVisualStyleBackColor = true;
            btnSolicitacaoAceitar.Click += btnSolicitacaoAceitar_Click_1;
            // 
            // btnSolicitacaoRejeitar
            // 
            btnSolicitacaoRejeitar.Location = new Point(130, 42);
            btnSolicitacaoRejeitar.Name = "btnSolicitacaoRejeitar";
            btnSolicitacaoRejeitar.Size = new Size(112, 34);
            btnSolicitacaoRejeitar.TabIndex = 1;
            btnSolicitacaoRejeitar.Text = "Rejeitar";
            btnSolicitacaoRejeitar.UseVisualStyleBackColor = true;
            btnSolicitacaoRejeitar.Click += btnSolicitacaoRejeitar_Click_1;
            // 
            // frmAceitarRecurasSolicitacao
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(393, 98);
            Controls.Add(btnSolicitacaoRejeitar);
            Controls.Add(btnSolicitacaoAceitar);
            Name = "frmAceitarRecurasSolicitacao";
            Text = "MSIF - Aceitar/Recusar";
            ResumeLayout(false);
        }

        #endregion

        private Button btnSolicitacaoAceitar;
        private Button btnSolicitacaoRejeitar;
    }
}