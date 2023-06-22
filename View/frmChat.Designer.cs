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
            components = new System.ComponentModel.Container();
            txtMsg = new TextBox();
            btnEnviar = new Button();
            flpMensagem = new FlowLayoutPanel();
            timerMensagens = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // txtMsg
            // 
            txtMsg.Location = new Point(11, 404);
            txtMsg.Name = "txtMsg";
            txtMsg.Size = new Size(659, 31);
            txtMsg.TabIndex = 1;
            // 
            // btnEnviar
            // 
            btnEnviar.Location = new Point(676, 404);
            btnEnviar.Name = "btnEnviar";
            btnEnviar.Size = new Size(112, 34);
            btnEnviar.TabIndex = 2;
            btnEnviar.Text = "Enviar";
            btnEnviar.UseVisualStyleBackColor = true;
            btnEnviar.Click += btnEnviar_Click;
            // 
            // flpMensagem
            // 
            flpMensagem.AutoScroll = true;
            flpMensagem.FlowDirection = FlowDirection.TopDown;
            flpMensagem.Location = new Point(12, 12);
            flpMensagem.Name = "flpMensagem";
            flpMensagem.Size = new Size(776, 386);
            flpMensagem.TabIndex = 3;
            flpMensagem.WrapContents = false;
            flpMensagem.Paint += flpMensagem_Paint;
            // 
            // timerMensagens
            // 
            timerMensagens.Enabled = true;
            timerMensagens.Interval = 1000;
            timerMensagens.Tick += timerMensagens_Tick;
            // 
            // frmChat
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 492);
            Controls.Add(flpMensagem);
            Controls.Add(btnEnviar);
            Controls.Add(txtMsg);
            Name = "frmChat";
            Text = "MSIF - Chat";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtMsg;
        private Button btnEnviar;
        private FlowLayoutPanel flpMensagem;
        private System.Windows.Forms.Timer timerMensagens;
    }
}