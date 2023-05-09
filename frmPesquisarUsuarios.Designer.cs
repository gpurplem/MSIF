namespace MSIF
{
    partial class frmPesquisarUsuarios
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
            lblApelido = new Label();
            txtApelido = new TextBox();
            btnPesquisar = new Button();
            dataGridView1 = new DataGridView();
            Apelido = new DataGridViewTextBoxColumn();
            btnEnviarSolicitacao = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // lblApelido
            // 
            lblApelido.AutoSize = true;
            lblApelido.Location = new Point(19, 33);
            lblApelido.Name = "lblApelido";
            lblApelido.Size = new Size(74, 25);
            lblApelido.TabIndex = 0;
            lblApelido.Text = "Apelido";
            // 
            // txtApelido
            // 
            txtApelido.Location = new Point(99, 33);
            txtApelido.Name = "txtApelido";
            txtApelido.Size = new Size(288, 31);
            txtApelido.TabIndex = 1;
            // 
            // btnPesquisar
            // 
            btnPesquisar.Location = new Point(393, 33);
            btnPesquisar.Name = "btnPesquisar";
            btnPesquisar.Size = new Size(112, 34);
            btnPesquisar.TabIndex = 2;
            btnPesquisar.Text = "Pesquisar";
            btnPesquisar.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Apelido });
            dataGridView1.Location = new Point(19, 70);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowTemplate.Height = 33;
            dataGridView1.Size = new Size(486, 96);
            dataGridView1.TabIndex = 3;
            // 
            // Apelido
            // 
            Apelido.HeaderText = "Apelido";
            Apelido.MinimumWidth = 8;
            Apelido.Name = "Apelido";
            Apelido.Width = 150;
            // 
            // btnEnviarSolicitacao
            // 
            btnEnviarSolicitacao.Location = new Point(19, 172);
            btnEnviarSolicitacao.Name = "btnEnviarSolicitacao";
            btnEnviarSolicitacao.Size = new Size(163, 34);
            btnEnviarSolicitacao.TabIndex = 4;
            btnEnviarSolicitacao.Text = "Enviar solicitação";
            btnEnviarSolicitacao.UseVisualStyleBackColor = true;
            // 
            // frmPesquisarUsuarios
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnEnviarSolicitacao);
            Controls.Add(dataGridView1);
            Controls.Add(btnPesquisar);
            Controls.Add(txtApelido);
            Controls.Add(lblApelido);
            Name = "frmPesquisarUsuarios";
            Text = "MSIF - Pesquisar usuários";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblApelido;
        private TextBox txtApelido;
        private Button btnPesquisar;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Apelido;
        private Button btnEnviarSolicitacao;
    }
}