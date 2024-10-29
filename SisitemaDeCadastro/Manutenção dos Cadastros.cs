namespace SisitemaDeCadastro
{
    public partial class Manutenção_dos_Cadastros : Form
    {
        public Manutenção_dos_Cadastros()
        {
            InitializeComponent();
        }

        private void HabilitaBotoesMenu(bool habilitar)
        {
            barBtnNovo.Enabled = habilitar;
            barBtnditar.Enabled = habilitar;
            barBtnExcluir.Enabled = habilitar;
            barBtnSalvar.Enabled = !habilitar; //exclamação para inverte, ficar desabilitado quando...
            barBtnCancelar.Enabled = !habilitar;
            barBtnSair.Enabled = habilitar;
        }

        private void HabilitaCamposM(bool habilitar)
        {
            TxtNome.Enabled = habilitar;
            TxtSigla.Enabled = habilitar;
            GrdDadosClientes.Enabled = !habilitar;
        }

        private void LimpaCamposDados()
        {
            TxtNome.Text = "";
            TxtSigla.Text = "";
        }

        private bool verificaDadosObrigatorios()
        {
            bool restultado = true;
            //verificando dados nome
            if (TxtNome.Text.Trim().Length < 5)
            {
                restultado = false;
            }
            //verificando Sigla
            if (TxtSigla.Text.Trim().Length != 2)
            {
                restultado = false;
            }


            return restultado;
        }

        private void InsereClieten()
        {
            HabilitaBotoesMenu(false);
            HabilitaCamposM(true);
            LimpaCamposDados();
        }

        private void AlteraCliente()
        {
            HabilitaBotoesMenu(false);
            HabilitaCamposM(true);


        }

        private void ExcluiCliente()
        {
            DialogResult retorno = MessageBox.Show("Deseja Excluir o cliente??", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (retorno == DialogResult.Yes)
            {
                LimpaCamposDados();

            }

        }

        private void SalvaCliente()
        {
            if (verificaDadosObrigatorios() == true)
            {
                HabilitaBotoesMenu(true);
                HabilitaCamposM(false);
                LimpaCamposDados();
            }
            else
            {
                MessageBox.Show("Dados obrigatorios Invalidos", "Urgente!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


        }

        private void Cancelar()
        {

            var retorno = MessageBox.Show("Deseja Cancelar?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (retorno == DialogResult.Yes)
            {
                HabilitaBotoesMenu(true);
                HabilitaCamposM(false);
                LimpaCamposDados();
            }




        }

        private void Sair()
        {
            this.Close();
        }

        private void LblNome_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Manutenção_dos_Cadastros_Load(object sender, EventArgs e)
        {
            HabilitaBotoesMenu(true);
            HabilitaCamposM(false);
        }

        private void GrdDadosClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void barBtnNovo_Click(object sender, EventArgs e)
        {
            InsereClieten();
        }

        private void barBtnditar_Click(object sender, EventArgs e)
        {
            AlteraCliente();
        }

        private void barBtnExcluir_Click(object sender, EventArgs e)
        {
            ExcluiCliente();
        }

        private void barBtnSalvar_Click(object sender, EventArgs e)
        {
            SalvaCliente();
        }

        private void barBtnCancelar_Click(object sender, EventArgs e)
        {
            Cancelar();
        }

        private void barBtnSair_Click(object sender, EventArgs e)
        {
            Sair();
        }
    }
}
