using MySql.Data.MySqlClient;

namespace SisitemaDeCadastro
{
    internal class dbClientes
    {
        //criando um objeto connect que erda as funlções da classe conexão sql
        conexaoMySql connect = new conexaoMySql();


        //Cria a instrução sql para insert de dados no db
        public void insereClientesdBase(cliente nomeCliente)
        {
            string sql = "insert into usuario (nome, sigla) value ('" + nomeCliente.getName() + "','" + nomeCliente.getSigla() + "');";
            connect.executaSql(sql);
        }

        //Cria a instrução SQL para update de dados no bd
        public void alteraClientesdBase(cliente nomeCliente)
        {
            string sql = "update clientes set nome = '" + nomeCliente.getName() + "' '" + nomeCliente.getSigla() + "' where id = " + nomeCliente.getId() + ";";
            connect.executaSql(sql);
        }

        //Cria a instrução SQL de deletar dados da bd
        public void excluiClientesdBase(cliente nomeCliente)
        {
            string sql = "delete from clientes where id " + nomeCliente.getId() + ";";
            connect.executaSql(sql);
        }

        //Cria a instrução SQL para retonar dados da bd
        public MySqlDataAdapter selectClientedBase(cliente nomeCliente)
        {

            string sql = "select id,nome,sigla from clientes where id=" + nomeCliente.getId() + ";";
            return connect.retonaSQL(sql);
        }

    }
}
