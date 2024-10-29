namespace SisitemaDeCadastro
{
    internal class cliente
    {
        //atributos da classe
        private int clienteID;
        private string clienteName;
        private string clienteSigla;

        //Método Construtor
        public cliente()
        {

        }

        //Metodos acessores
        public void setId(int id)
        {
            clienteID = id;
        }

        public int getId()
        {
            return clienteID;
        }

        public void setName(string nome)
        {
            clienteName = nome;
        }

        public string getName()
        {
            return clienteName;
        }

        public void setSigla(string sigla) { 
            clienteSigla = sigla;
        }

        public string getSigla() { 
            return clienteSigla;
        }

    }
}
