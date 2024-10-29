using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace SisitemaDeCadastro
{
    internal class conexaoMySql
    {
        private MySqlConnection conexao;



        public void conectarBaseDados()
        {
            conexao = new MySqlConnection("server=localhost;uid=root;database=cliente;pwd=");

            try
            {
                conexao.Open();
            }

            catch (Exception ex) {
                MessageBox.Show(ex.Message.ToString());
            }
            
            
            
        }

        public void desconcetaBaseDados()
        {
            conexao.Close();
        }

        public void executaSql(string instrucaoSQL)
        {
            conectarBaseDados();



            desconcetaBaseDados();
        }

        public MySqlDataAdapter retonaSQL(string instrucaoSQL)
        {
            conectarBaseDados();
            desconcetaBaseDados ();
            return true;
        }
    }
}
