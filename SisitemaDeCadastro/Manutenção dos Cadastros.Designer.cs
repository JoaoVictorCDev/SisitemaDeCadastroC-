namespace SisitemaDeCadastro
{
    partial class Manutenção_dos_Cadastros
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Manutenção_dos_Cadastros));
            BarManutencao = new ToolStrip();
            barBtnNovo = new ToolStripButton();
            barBtnditar = new ToolStripButton();
            barBtnExcluir = new ToolStripButton();
            barBtnSalvar = new ToolStripButton();
            barBtnCancelar = new ToolStripButton();
            barBtnSair = new ToolStripButton();
            GrdDadosClientes = new DataGridView();
            LblNome = new Label();
            TxtNome = new TextBox();
            LblSigla = new Label();
            TxtSigla = new TextBox();
            BarManutencao.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)GrdDadosClientes).BeginInit();
            SuspendLayout();
            // 
            // BarManutencao
            // 
            BarManutencao.ImageScalingSize = new Size(25, 25);
            BarManutencao.Items.AddRange(new ToolStripItem[] { barBtnNovo, barBtnditar, barBtnExcluir, barBtnSalvar, barBtnCancelar, barBtnSair });
            BarManutencao.Location = new Point(0, 0);
            BarManutencao.Name = "BarManutencao";
            BarManutencao.Size = new Size(648, 32);
            BarManutencao.TabIndex = 0;
            BarManutencao.Text = "toolStrip1";
            // 
            // barBtnNovo
            // 
            barBtnNovo.DisplayStyle = ToolStripItemDisplayStyle.Image;
            barBtnNovo.Image = (Image)resources.GetObject("barBtnNovo.Image");
            barBtnNovo.ImageTransparentColor = Color.Magenta;
            barBtnNovo.Name = "barBtnNovo";
            barBtnNovo.Size = new Size(29, 29);
            barBtnNovo.Text = "Novo";
            barBtnNovo.Click += barBtnNovo_Click;
            // 
            // barBtnditar
            // 
            barBtnditar.DisplayStyle = ToolStripItemDisplayStyle.Image;
            barBtnditar.Image = (Image)resources.GetObject("barBtnditar.Image");
            barBtnditar.ImageTransparentColor = Color.Magenta;
            barBtnditar.Name = "barBtnditar";
            barBtnditar.Size = new Size(29, 29);
            barBtnditar.Text = "Editar";
            barBtnditar.Click += barBtnditar_Click;
            // 
            // barBtnExcluir
            // 
            barBtnExcluir.DisplayStyle = ToolStripItemDisplayStyle.Image;
            barBtnExcluir.Image = (Image)resources.GetObject("barBtnExcluir.Image");
            barBtnExcluir.ImageTransparentColor = Color.Magenta;
            barBtnExcluir.Name = "barBtnExcluir";
            barBtnExcluir.Size = new Size(29, 29);
            barBtnExcluir.Text = "Excuir";
            barBtnExcluir.Click += barBtnExcluir_Click;
            // 
            // barBtnSalvar
            // 
            barBtnSalvar.DisplayStyle = ToolStripItemDisplayStyle.Image;
            barBtnSalvar.Image = (Image)resources.GetObject("barBtnSalvar.Image");
            barBtnSalvar.ImageTransparentColor = Color.Magenta;
            barBtnSalvar.Name = "barBtnSalvar";
            barBtnSalvar.Size = new Size(29, 29);
            barBtnSalvar.Text = "Salvar";
            barBtnSalvar.Click += barBtnSalvar_Click;
            // 
            // barBtnCancelar
            // 
            barBtnCancelar.DisplayStyle = ToolStripItemDisplayStyle.Image;
            barBtnCancelar.Image = (Image)resources.GetObject("barBtnCancelar.Image");
            barBtnCancelar.ImageTransparentColor = Color.Magenta;
            barBtnCancelar.Name = "barBtnCancelar";
            barBtnCancelar.Size = new Size(29, 29);
            barBtnCancelar.Text = "Cancelar";
            barBtnCancelar.Click += barBtnCancelar_Click;
            // 
            // barBtnSair
            // 
            barBtnSair.DisplayStyle = ToolStripItemDisplayStyle.Image;
            barBtnSair.Image = (Image)resources.GetObject("barBtnSair.Image");
            barBtnSair.ImageTransparentColor = Color.Magenta;
            barBtnSair.Name = "barBtnSair";
            barBtnSair.Size = new Size(29, 29);
            barBtnSair.Text = "Fechar";
            barBtnSair.Click += barBtnSair_Click;
            // 
            // GrdDadosClientes
            // 
            GrdDadosClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            GrdDadosClientes.Location = new Point(12, 50);
            GrdDadosClientes.Name = "GrdDadosClientes";
            GrdDadosClientes.Size = new Size(260, 383);
            GrdDadosClientes.TabIndex = 1;
            GrdDadosClientes.CellContentClick += GrdDadosClientes_CellContentClick;
            // 
            // LblNome
            // 
            LblNome.AutoSize = true;
            LblNome.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LblNome.Location = new Point(282, 50);
            LblNome.Name = "LblNome";
            LblNome.Size = new Size(50, 20);
            LblNome.TabIndex = 2;
            LblNome.Text = "Nome";
            LblNome.Click += LblNome_Click;
            // 
            // TxtNome
            // 
            TxtNome.Location = new Point(282, 73);
            TxtNome.Name = "TxtNome";
            TxtNome.Size = new Size(321, 23);
            TxtNome.TabIndex = 3;
            TxtNome.TextChanged += textBox1_TextChanged;
            // 
            // LblSigla
            // 
            LblSigla.AutoSize = true;
            LblSigla.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LblSigla.Location = new Point(282, 107);
            LblSigla.Name = "LblSigla";
            LblSigla.Size = new Size(42, 20);
            LblSigla.TabIndex = 4;
            LblSigla.Text = "Sigla";
            // 
            // TxtSigla
            // 
            TxtSigla.Location = new Point(282, 130);
            TxtSigla.MaxLength = 2;
            TxtSigla.Name = "TxtSigla";
            TxtSigla.Size = new Size(50, 23);
            TxtSigla.TabIndex = 5;
            // 
            // Manutenção_dos_Cadastros
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Plum;
            ClientSize = new Size(648, 453);
            Controls.Add(TxtSigla);
            Controls.Add(LblSigla);
            Controls.Add(TxtNome);
            Controls.Add(LblNome);
            Controls.Add(GrdDadosClientes);
            Controls.Add(BarManutencao);
            Name = "Manutenção_dos_Cadastros";
            Text = "Manutenção dos Cadastros";
            Load += Manutenção_dos_Cadastros_Load;
            BarManutencao.ResumeLayout(false);
            BarManutencao.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)GrdDadosClientes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip BarManutencao;
        private ToolStripButton barBtnNovo;
        private ToolStripButton barBtnditar;
        private ToolStripButton barBtnExcluir;
        private ToolStripButton barBtnSalvar;
        private ToolStripButton barBtnCancelar;
        private ToolStripButton barBtnSair;
        private DataGridView GrdDadosClientes;
        private Label LblNome;
        private TextBox TxtNome;
        private Label LblSigla;
        private TextBox TxtSigla;
    }
}