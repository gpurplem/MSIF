namespace MSIF.View
{
    partial class frmAceitarRecurasSoli
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAceitarRecurasSoli));
            this.btnSolicitacaoAceitar = new System.Windows.Forms.Button();
            this.btnSolicitacaoRejeitar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSolicitacaoAceitar
            // 
            this.btnSolicitacaoAceitar.BackColor = System.Drawing.Color.MediumOrchid;
            this.btnSolicitacaoAceitar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSolicitacaoAceitar.Font = new System.Drawing.Font("Caladea", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSolicitacaoAceitar.ForeColor = System.Drawing.Color.White;
            this.btnSolicitacaoAceitar.Location = new System.Drawing.Point(36, 19);
            this.btnSolicitacaoAceitar.Name = "btnSolicitacaoAceitar";
            this.btnSolicitacaoAceitar.Size = new System.Drawing.Size(82, 25);
            this.btnSolicitacaoAceitar.TabIndex = 0;
            this.btnSolicitacaoAceitar.Text = "ACEITAR";
            this.btnSolicitacaoAceitar.UseVisualStyleBackColor = false;
            // 
            // btnSolicitacaoRejeitar
            // 
            this.btnSolicitacaoRejeitar.BackColor = System.Drawing.Color.MediumOrchid;
            this.btnSolicitacaoRejeitar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSolicitacaoRejeitar.Font = new System.Drawing.Font("Caladea", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSolicitacaoRejeitar.ForeColor = System.Drawing.Color.White;
            this.btnSolicitacaoRejeitar.Location = new System.Drawing.Point(152, 19);
            this.btnSolicitacaoRejeitar.Name = "btnSolicitacaoRejeitar";
            this.btnSolicitacaoRejeitar.Size = new System.Drawing.Size(89, 25);
            this.btnSolicitacaoRejeitar.TabIndex = 1;
            this.btnSolicitacaoRejeitar.Text = "RECUSAR";
            this.btnSolicitacaoRejeitar.UseVisualStyleBackColor = false;
            // 
            // frmAceitarRecurasSoli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(275, 59);
            this.Controls.Add(this.btnSolicitacaoRejeitar);
            this.Controls.Add(this.btnSolicitacaoAceitar);
            this.Name = "frmAceitarRecurasSoli";
            this.Text = "frmAceitarRecurasSoli";
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnSolicitacaoAceitar;
        private Button btnSolicitacaoRejeitar;
    }
}