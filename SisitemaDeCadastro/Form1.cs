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
            Manuten��o_dos_Cadastros frmCadastro = new Manuten��o_dos_Cadastros();
            frmCadastro.MdiParent = this;
            frmCadastro.Show();
        }
    }
}
