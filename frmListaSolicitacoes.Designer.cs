namespace MSIF
{
    partial class frmListaSolicitacoes
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
            Apelido = new DataGridViewTextBoxColumn();
            btnAceitar = new Button();
            btnRecusar = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Apelido });
            dataGridView1.Location = new Point(12, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowTemplate.Height = 33;
            dataGridView1.Size = new Size(776, 225);
            dataGridView1.TabIndex = 0;
            // 
            // Apelido
            // 
            Apelido.HeaderText = "Apelido";
            Apelido.MinimumWidth = 8;
            Apelido.Name = "Apelido";
            Apelido.Width = 150;
            // 
            // btnAceitar
            // 
            btnAceitar.Location = new Point(12, 252);
            btnAceitar.Name = "btnAceitar";
            btnAceitar.Size = new Size(112, 34);
            btnAceitar.TabIndex = 1;
            btnAceitar.Text = "Aceitar";
            btnAceitar.UseVisualStyleBackColor = true;
            // 
            // btnRecusar
            // 
            btnRecusar.Location = new Point(12, 292);
            btnRecusar.Name = "btnRecusar";
            btnRecusar.Size = new Size(112, 34);
            btnRecusar.TabIndex = 2;
            btnRecusar.Text = "Recusar";
            btnRecusar.UseVisualStyleBackColor = true;
            // 
            // frmListaSolicitacoes
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnRecusar);
            Controls.Add(btnAceitar);
            Controls.Add(dataGridView1);
            Name = "frmListaSolicitacoes";
            Text = "frmListaSolicitacoes";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Apelido;
        private Button btnAceitar;
        private Button btnRecusar;
    }
}