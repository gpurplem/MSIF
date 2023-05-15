namespace MSIF
{
    partial class frmListaContatos
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
            btnEnviarMsg = new Button();
            btnDeletarContato = new Button();
            btnVisualizarPerfil = new Button();
            FotoListaContatos = new DataGridViewTextBoxColumn();
            ApelidoListaContatos = new DataGridViewTextBoxColumn();
            StatusListaContatos = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { FotoListaContatos, ApelidoListaContatos, StatusListaContatos });
            dataGridView1.Location = new Point(12, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowTemplate.Height = 33;
            dataGridView1.Size = new Size(776, 341);
            dataGridView1.TabIndex = 0;
            // 
            // btnEnviarMsg
            // 
            btnEnviarMsg.Location = new Point(12, 359);
            btnEnviarMsg.Name = "btnEnviarMsg";
            btnEnviarMsg.Size = new Size(180, 34);
            btnEnviarMsg.TabIndex = 1;
            btnEnviarMsg.Text = "Enviar mensagem";
            btnEnviarMsg.UseVisualStyleBackColor = true;
            // 
            // btnDeletarContato
            // 
            btnDeletarContato.Location = new Point(12, 399);
            btnDeletarContato.Name = "btnDeletarContato";
            btnDeletarContato.Size = new Size(180, 34);
            btnDeletarContato.TabIndex = 2;
            btnDeletarContato.Text = "Deletar contato";
            btnDeletarContato.UseVisualStyleBackColor = true;
            // 
            // btnVisualizarPerfil
            // 
            btnVisualizarPerfil.Location = new Point(198, 359);
            btnVisualizarPerfil.Name = "btnVisualizarPerfil";
            btnVisualizarPerfil.Size = new Size(169, 34);
            btnVisualizarPerfil.TabIndex = 3;
            btnVisualizarPerfil.Text = "Visualizar perfil";
            btnVisualizarPerfil.UseVisualStyleBackColor = true;
            // 
            // FotoListaContatos
            // 
            FotoListaContatos.HeaderText = "Foto";
            FotoListaContatos.MinimumWidth = 8;
            FotoListaContatos.Name = "FotoListaContatos";
            FotoListaContatos.Width = 150;
            // 
            // ApelidoListaContatos
            // 
            ApelidoListaContatos.HeaderText = "Apelido";
            ApelidoListaContatos.MinimumWidth = 8;
            ApelidoListaContatos.Name = "ApelidoListaContatos";
            ApelidoListaContatos.Width = 150;
            // 
            // StatusListaContatos
            // 
            StatusListaContatos.HeaderText = "Status";
            StatusListaContatos.MinimumWidth = 8;
            StatusListaContatos.Name = "StatusListaContatos";
            StatusListaContatos.Width = 150;
            // 
            // frmListaContatos
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnVisualizarPerfil);
            Controls.Add(btnDeletarContato);
            Controls.Add(btnEnviarMsg);
            Controls.Add(dataGridView1);
            Name = "frmListaContatos";
            Text = "MSIF - Lista contatos";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Button btnEnviarMsg;
        private Button btnDeletarContato;
        private Button btnVisualizarPerfil;
        private DataGridViewTextBoxColumn FotoListaContatos;
        private DataGridViewTextBoxColumn ApelidoListaContatos;
        private DataGridViewTextBoxColumn StatusListaContatos;
    }
}