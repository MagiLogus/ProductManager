namespace ProductManager
{
    public class Marca
    {
        public int Codigo { get; private set; }

        public string NomeMarca { get; private set; }

        public DateTime DataCadastro { get; private set; }

        List<Marca> listaDeMarcas = new List<Marca>();

        public string Cadastrar(Marca marca)
        {
            return "0";
        }

        public void Listar()
        {

        }



        public string Deletar(Marca marca)
        {
            return "0";
        }

        public Marca Cadastrar(Marca marca)
        {
            return marca;
        }
    }
}



