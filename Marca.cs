namespace ProductManager
{
    public class Marca
    {
        public int Codigo { get; private set; }

        public string NomeMarca { get; private set; }

        public DateTime DataCadastro { get; private set; }

        List<Marca> listaDeMarcas = new List<Marca>();

        public Marca Cadastrar()
        {
            Marca marca = new Marca();
            return marca;
            
        }

        public void Listar()
        {

        }

        public string Deletar()
        {
            return "Marca deletada com sucesso !";
        }
    }
}



