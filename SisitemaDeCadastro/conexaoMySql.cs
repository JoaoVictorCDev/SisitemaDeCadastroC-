using MySql.Data.MySqlClient;

namespace SisitemaDeCadastro
{
    internal class conexaoMySql
    {
        private MySqlConnection? conexao;



        public void conectarBaseDados()
        {
            conexao = new MySqlConnection("server=localhost;uid=root;database=clientes;pwd=teste123@");

            try
            {
                conexao.Open();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }



        }

        public void desconcetaBaseDados()
        {
            conexao?.Close();
        }

        public void executaSql(string instrucaoSQL)
        {
            conectarBaseDados();

            MySqlCommand comand = new MySqlCommand(instrucaoSQL, conexao);
            comand.ExecuteNonQuery();

            desconcetaBaseDados();
        }

        public MySqlDataAdapter retonaSQL(string instrucaoSQL)
        {
            conectarBaseDados();

            MySqlDataAdapter adapter = new MySqlDataAdapter(instrucaoSQL, conexao); //

            desconcetaBaseDados();

            return adapter;
        }
    }
}
