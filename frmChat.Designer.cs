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
            txtMsg = new TextBox();
            btnEnviar = new Button();
            flowLayoutPanel1 = new FlowLayoutPanel();
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
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Location = new Point(12, 12);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(776, 386);
            flowLayoutPanel1.TabIndex = 3;
            // 
            // frmChat
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(flowLayoutPanel1);
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
        private FlowLayoutPanel flowLayoutPanel1;
    }
}