namespace ProductManager
{
    public class Produto
    {
        public int Codigo { get; private set; }

        public string NomeProduto { get; private set; }

        public float Preco { get; set; }

        public DateTime DataCadastro { get; private set; }

        public string Cadastrar()
        {
            return "0";
        }

        public string Deletar()
        {
            return "0";
        }

    }
}