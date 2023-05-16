namespace MSIF
{
    partial class frmTelaMenuPrincipal
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
            tabControlMenuPrincipal = new TabControl();
            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
            tabPage3 = new TabPage();
            tabPage4 = new TabPage();
            tabPage5 = new TabPage();
            tabControlMenuPrincipal.SuspendLayout();
            SuspendLayout();
            // 
            // tabControlMenuPrincipal
            // 
            tabControlMenuPrincipal.Controls.Add(tabPage1);
            tabControlMenuPrincipal.Controls.Add(tabPage2);
            tabControlMenuPrincipal.Controls.Add(tabPage3);
            tabControlMenuPrincipal.Controls.Add(tabPage4);
            tabControlMenuPrincipal.Controls.Add(tabPage5);
            tabControlMenuPrincipal.Location = new Point(1, 1);
            tabControlMenuPrincipal.Name = "tabControlMenuPrincipal";
            tabControlMenuPrincipal.SelectedIndex = 0;
            tabControlMenuPrincipal.Size = new Size(797, 447);
            tabControlMenuPrincipal.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Location = new Point(4, 34);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(789, 409);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Contatos";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 34);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(789, 409);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Mensagens";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            tabPage3.Location = new Point(4, 34);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(789, 409);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Solicitações";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            tabPage4.Location = new Point(4, 34);
            tabPage4.Name = "tabPage4";
            tabPage4.Size = new Size(789, 409);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "Pesquisar";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            tabPage5.Location = new Point(4, 34);
            tabPage5.Name = "tabPage5";
            tabPage5.Size = new Size(789, 409);
            tabPage5.TabIndex = 4;
            tabPage5.Text = "Meu perfil";
            tabPage5.UseVisualStyleBackColor = true;
            // 
            // MenuPrincipal
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControlMenuPrincipal);
            Name = "MenuPrincipal";
            Text = "MenuPrincipal";
            tabControlMenuPrincipal.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControlMenuPrincipal;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private TabPage tabPage4;
        private TabPage tabPage5;
    }
}