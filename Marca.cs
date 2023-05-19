namespace ProductManager
{
    public class Marca
    {
        public int Codigo { get; private set; }
        public string NomeMarca { get; private set; }
        public DateTime DataCadastro { get; private set; }
        public static List<Marca> listaDeMarcas = new List<Marca>();

        public Marca Cadastrar()
        {
            Marca marca = new Marca();

            Console.WriteLine($"insira o codigo da marca: ");
            marca.Codigo = int.Parse(Console.ReadLine());

            Console.WriteLine($"Insira a marca que deseja cadastrar:");
            marca.NomeMarca = Console.ReadLine();

            marca.DataCadastro = DateTime.UtcNow;

            listaDeMarcas.Add(marca);

            return marca;

        }

        public void Listar()
        {
            Console.WriteLine($"Lista de marcas: ");

            foreach (Marca item in listaDeMarcas)
            {
                Console.WriteLine(@$"
                Codigo: {item.Codigo}
                Nome: {item.NomeMarca}
                Cadastrado em : {item.DataCadastro}
                ");
            }

        }

        public string Deletar()
        {
            return "Marca deletada com sucesso !";
        }
    }
}



