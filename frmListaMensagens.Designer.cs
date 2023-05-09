namespace MSIF
{
    partial class frmListaMensagens
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
            dgvApelido = new DataGridViewTextBoxColumn();
            dgvNovaMensagem = new DataGridViewTextBoxColumn();
            Apelido = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            btnAbrirChat = new Button();
            btnDeletar = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { dgvApelido, dgvNovaMensagem });
            dataGridView1.Location = new Point(12, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowTemplate.Height = 33;
            dataGridView1.Size = new Size(776, 347);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // dgvApelido
            // 
            dgvApelido.HeaderText = "Apelido";
            dgvApelido.MinimumWidth = 8;
            dgvApelido.Name = "dgvApelido";
            dgvApelido.Width = 150;
            // 
            // dgvNovaMensagem
            // 
            dgvNovaMensagem.HeaderText = "Nova mensagem";
            dgvNovaMensagem.MinimumWidth = 8;
            dgvNovaMensagem.Name = "dgvNovaMensagem";
            dgvNovaMensagem.Width = 150;
            // 
            // Apelido
            // 
            Apelido.HeaderText = "Apelido";
            Apelido.MinimumWidth = 8;
            Apelido.Name = "Apelido";
            Apelido.Width = 150;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.HeaderText = "Apelido";
            dataGridViewTextBoxColumn1.MinimumWidth = 8;
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.Width = 150;
            // 
            // btnAbrirChat
            // 
            btnAbrirChat.Location = new Point(12, 365);
            btnAbrirChat.Name = "btnAbrirChat";
            btnAbrirChat.Size = new Size(112, 34);
            btnAbrirChat.TabIndex = 1;
            btnAbrirChat.Text = "Abrir";
            btnAbrirChat.UseVisualStyleBackColor = true;
            // 
            // btnDeletar
            // 
            btnDeletar.Location = new Point(130, 365);
            btnDeletar.Name = "btnDeletar";
            btnDeletar.Size = new Size(112, 34);
            btnDeletar.TabIndex = 2;
            btnDeletar.Text = "Deletar";
            btnDeletar.UseVisualStyleBackColor = true;
            // 
            // frmListaMensagens
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnDeletar);
            Controls.Add(btnAbrirChat);
            Controls.Add(dataGridView1);
            Name = "frmListaMensagens";
            Text = "MSIF - Mensagens";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn dgvApelido;
        private DataGridViewTextBoxColumn dgvNovaMensagem;
        private DataGridViewTextBoxColumn Apelido;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private Button btnAbrirChat;
        private Button btnDeletar;
    }
}