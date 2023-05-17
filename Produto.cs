namespace ProductManager
{
    public class Produto
    {
        public int Codigo { get; private set; }
        public string NomeProduto { get; private set; }
        public float Preco { get; private set; }
        public DateTime DataCadastro { get; private set; }
        public Marca Marca = new Marca();
        public Usuario CadastradoPor { get; private set; }
        List<Produto> listaDeProdutos = new List<Produto>();

        public string Cadastrar()
        {
            return "0";
            //aqui vai a logica usando as variaveis 
        }

        public string Deletar() //codigo ou produto 
        {
            return "0";
        }

    }
}