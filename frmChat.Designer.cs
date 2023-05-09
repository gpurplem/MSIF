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
            dataGridView1 = new DataGridView();
            dgvApelidoChat = new DataGridViewTextBoxColumn();
            dgvMsgChat = new DataGridViewTextBoxColumn();
            txtMsg = new TextBox();
            btnEnviar = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { dgvApelidoChat, dgvMsgChat });
            dataGridView1.Location = new Point(11, 11);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowTemplate.Height = 33;
            dataGridView1.Size = new Size(777, 267);
            dataGridView1.TabIndex = 0;
            // 
            // dgvApelidoChat
            // 
            dgvApelidoChat.HeaderText = "Apelido";
            dgvApelidoChat.MinimumWidth = 8;
            dgvApelidoChat.Name = "dgvApelidoChat";
            dgvApelidoChat.Width = 150;
            // 
            // dgvMsgChat
            // 
            dgvMsgChat.HeaderText = "Mensagem";
            dgvMsgChat.MinimumWidth = 8;
            dgvMsgChat.Name = "dgvMsgChat";
            dgvMsgChat.Width = 150;
            // 
            // txtMsg
            // 
            txtMsg.Location = new Point(11, 297);
            txtMsg.Name = "txtMsg";
            txtMsg.Size = new Size(659, 31);
            txtMsg.TabIndex = 1;
            // 
            // btnEnviar
            // 
            btnEnviar.Location = new Point(676, 297);
            btnEnviar.Name = "btnEnviar";
            btnEnviar.Size = new Size(112, 34);
            btnEnviar.TabIndex = 2;
            btnEnviar.Text = "Enviar";
            btnEnviar.UseVisualStyleBackColor = true;
            // 
            // frmChat
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnEnviar);
            Controls.Add(txtMsg);
            Controls.Add(dataGridView1);
            Name = "frmChat";
            Text = "MSIF - Chat";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn dgvApelidoChat;
        private DataGridViewTextBoxColumn dgvMsgChat;
        private TextBox txtMsg;
        private Button btnEnviar;
    }
}