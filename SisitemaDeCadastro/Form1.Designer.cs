namespace SisitemaDeCadastro
{
    partial class FormularioPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            cadastroToolStripMenuItem = new ToolStripMenuItem();
            básicoToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripSeparator();
            fecharToolStripMenuItem = new ToolStripMenuItem();
            MnuUsuarios = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { cadastroToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1036, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // cadastroToolStripMenuItem
            // 
            cadastroToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { básicoToolStripMenuItem, toolStripMenuItem1, fecharToolStripMenuItem });
            cadastroToolStripMenuItem.Name = "cadastroToolStripMenuItem";
            cadastroToolStripMenuItem.Size = new Size(66, 20);
            cadastroToolStripMenuItem.Text = "Cadastro";
            // 
            // básicoToolStripMenuItem
            // 
            básicoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { MnuUsuarios });
            básicoToolStripMenuItem.Name = "básicoToolStripMenuItem";
            básicoToolStripMenuItem.Size = new Size(180, 22);
            básicoToolStripMenuItem.Text = "Básico";
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(177, 6);
            // 
            // fecharToolStripMenuItem
            // 
            fecharToolStripMenuItem.Name = "fecharToolStripMenuItem";
            fecharToolStripMenuItem.Size = new Size(180, 22);
            fecharToolStripMenuItem.Text = "Fechar";
            // 
            // MnuUsuarios
            // 
            MnuUsuarios.Name = "MnuUsuarios";
            MnuUsuarios.Size = new Size(180, 22);
            MnuUsuarios.Text = "Usuarios";
            MnuUsuarios.Click += MnuUsuarios_Click;
            // 
            // FormularioPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Orchid;
            ClientSize = new Size(1036, 475);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "FormularioPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Formulario Principal";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem cadastroToolStripMenuItem;
        private ToolStripMenuItem básicoToolStripMenuItem;
        private ToolStripSeparator toolStripMenuItem1;
        private ToolStripMenuItem fecharToolStripMenuItem;
        private ToolStripMenuItem MnuUsuarios;
    }
}
