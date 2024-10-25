namespace SisitemaDeCadastro
{
    public partial class FormularioPrincipal : Form
    {
        public FormularioPrincipal()
        {
            InitializeComponent();
        }

        private void MnuUsuarios_Click(object sender, EventArgs e)
        {
            Manutenção_dos_Cadastros frmCadastro = new Manutenção_dos_Cadastros();
            frmCadastro.MdiParent = this;
            frmCadastro.Show();
        }
    }
}
