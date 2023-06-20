namespace MSIF
{
    partial class frmChat
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
            this.txtMsg = new System.Windows.Forms.TextBox();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.flpMensagem = new System.Windows.Forms.FlowLayoutPanel();
            this.btnLimparChat = new System.Windows.Forms.Button();
            this.btnChatExcluirContato = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtMsg
            // 
            this.txtMsg.BackColor = System.Drawing.Color.Black;
            this.txtMsg.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMsg.Font = new System.Drawing.Font("Caladea", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtMsg.ForeColor = System.Drawing.Color.White;
            this.txtMsg.Location = new System.Drawing.Point(20, 306);
            this.txtMsg.Margin = new System.Windows.Forms.Padding(2);
            this.txtMsg.Name = "txtMsg";
            this.txtMsg.Size = new System.Drawing.Size(450, 16);
            this.txtMsg.TabIndex = 1;
            // 
            // btnEnviar
            // 
            this.btnEnviar.BackColor = System.Drawing.Color.Black;
            this.btnEnviar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEnviar.Font = new System.Drawing.Font("Caladea", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnEnviar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnEnviar.Location = new System.Drawing.Point(460, 299);
            this.btnEnviar.Margin = new System.Windows.Forms.Padding(2);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(91, 29);
            this.btnEnviar.TabIndex = 2;
            this.btnEnviar.Text = "ENVIAR";
            this.btnEnviar.UseVisualStyleBackColor = false;
            // 
            // flpMensagem
            // 
            this.flpMensagem.AutoScroll = true;
            this.flpMensagem.BackColor = System.Drawing.Color.Black;
            this.flpMensagem.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpMensagem.Location = new System.Drawing.Point(30, 36);
            this.flpMensagem.Margin = new System.Windows.Forms.Padding(2);
            this.flpMensagem.Name = "flpMensagem";
            this.flpMensagem.Size = new System.Drawing.Size(510, 195);
            this.flpMensagem.TabIndex = 3;
            this.flpMensagem.WrapContents = false;
            // 
            // btnLimparChat
            // 
            this.btnLimparChat.BackColor = System.Drawing.Color.MediumOrchid;
            this.btnLimparChat.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLimparChat.Font = new System.Drawing.Font("Caladea", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnLimparChat.ForeColor = System.Drawing.Color.White;
            this.btnLimparChat.Location = new System.Drawing.Point(143, 258);
            this.btnLimparChat.Name = "btnLimparChat";
            this.btnLimparChat.Size = new System.Drawing.Size(125, 25);
            this.btnLimparChat.TabIndex = 4;
            this.btnLimparChat.Text = "LIMPAR CHAT";
            this.btnLimparChat.UseVisualStyleBackColor = false;
            // 
            // btnChatExcluirContato
            // 
            this.btnChatExcluirContato.BackColor = System.Drawing.Color.MediumOrchid;
            this.btnChatExcluirContato.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnChatExcluirContato.Font = new System.Drawing.Font("Caladea", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnChatExcluirContato.ForeColor = System.Drawing.Color.White;
            this.btnChatExcluirContato.Location = new System.Drawing.Point(276, 258);
            this.btnChatExcluirContato.Name = "btnChatExcluirContato";
            this.btnChatExcluirContato.Size = new System.Drawing.Size(153, 25);
            this.btnChatExcluirContato.TabIndex = 5;
            this.btnChatExcluirContato.Text = "EXCLUIR CONTATO";
            this.btnChatExcluirContato.UseVisualStyleBackColor = false;
            // 
            // frmChat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MSIF.Properties.Resources.TELA_CHAT;
            this.ClientSize = new System.Drawing.Size(575, 349);
            this.Controls.Add(this.btnChatExcluirContato);
            this.Controls.Add(this.btnLimparChat);
            this.Controls.Add(this.flpMensagem);
            this.Controls.Add(this.btnEnviar);
            this.Controls.Add(this.txtMsg);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmChat";
            this.Text = "MSIF - Chat";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private TextBox txtMsg;
        private Button btnEnviar;
        private FlowLayoutPanel flpMensagem;
        private Button btnLimparChat;
        private Button btnChatExcluirContato;
    }
}