namespace ProductManager
{
    public class Usuario
    {
        public int Codigo { get; private set; }
        public string Nome { get; private set; }
        public string Email { get; private set; }
        public string Senha { get; private set; }
        public DateTime DataCadastro { get; private set; }
        public static List<Usuario> listaDeUsuarios = new List<Usuario>();

        public Usuario()
        {
            Cadastrar();
        }

        public string Cadastrar()
        {
            Usuario usuario = new Usuario();

            Console.WriteLine($"Cadastro de usuario: ");

            Console.WriteLine($"Digite o codigo que deseja cadstrar:");
            usuario.Codigo = int.Parse(Console.ReadLine());
            
            Console.WriteLine($"Digite o nome que deseja cadstrar: ");
            usuario.Nome = Console.ReadLine();

            Console.WriteLine($"Digite o email que deseja cadstrar:");
            usuario.Email = Console.ReadLine();

            Console.WriteLine($"Digite a senha que deseja cadstrar:");
            usuario.Senha = Console.ReadLine();

            listaDeUsuarios.Add(usuario);

            Console.WriteLine($"Usuario Cadastrado com Sucesso !");

            return "";
        }

        public string Deletar()
        {
            Nome = "";
            Email = "";
            Senha = "";

            Console.WriteLine($"usuario deletado !");

            return "";
        }
    }
}