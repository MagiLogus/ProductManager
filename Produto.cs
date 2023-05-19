using ProductManager;

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
            Produto produto = new Produto();

            Console.WriteLine($"Insira o codigo do produto: ");
            produto.Codigo = int.Parse(Console.ReadLine());

            Console.WriteLine($"Insira o nome do produto: ");
            produto.NomeProduto = Console.ReadLine();

            Console.WriteLine($"Insira o preco do produto: ");
            produto.Preco = float.Parse(Console.ReadLine());

            produto.DataCadastro = DateTime.UtcNow;

            produto.Marca = Marca.Cadastrar();

            produto.CadastradoPor = new Usuario();

            listaDeProdutos.Add(produto);

            Console.WriteLine($"Produto cadastrado com sucesso");

            return "";
        }

        public void Listar()
        {
            Console.WriteLine($"Lista de produtos: ");

            foreach (Produto item in listaDeProdutos)
            {
                Console.WriteLine(@$"
                Codigo: {item.Codigo}
                Nome: {item.NomeProduto}
                Preco: {item.Preco:C}
                Cadastrado em : {item.DataCadastro}
                ");
            }

        }

        public string Deletar(int Codigo)
        {
            return $"O produto xxxx foi deletado";
            ;
        }

    }
}