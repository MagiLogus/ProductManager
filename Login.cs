using ProductManager;

namespace ProductManager
{
    public class Login
    {
        public bool Logado { get; private set; }

        Usuario user = new Usuario();

        public Login()
        {
            Logar(user);

            if (Logado)
            {
                Menu();
            }
        }

        public string Logar(Usuario usuario)
        {
            Console.WriteLine($"Insira seu Email: ");
            string email = Console.ReadLine();

            Console.WriteLine($"Insira sua senha: ");
            string senha = Console.ReadLine();

            if (usuario != null && user.Email == email && user.Senha == senha)
            {
                Logado = true;
                Console.WriteLine($"Usuario Logado !");
            }
            else
            {
                Logado = false;
                Console.WriteLine($"nenhum usuario encontrado");
            }

            return "";
        }

        public void Menu()
        {
            Produto produto = new Produto();
            Marca marca = new Marca();

            int opcao;

            do
            {
                Console.WriteLine($"Menu");
                Console.WriteLine(@$"
                1-Cadastrar Produtos 
                2-Listar Produtos 
                3-Remover produtos 
                4-Cadastrar marcas
                5-Listar marcas
                6-Remover marcas 
                0-Sair 
                ");

                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        produto.Cadastrar();
                        break;

                    case 2:
                        break;

                    case 3:
                        break;

                    case 4:
                        break;

                    case 5:
                        break;

                    case 6:
                        break;

                    case 0:
                        Deslogar();
                        break;

                    default:
                        Console.WriteLine($"opcao invalida");
                        break;
                }

            } while (opcao != 0);
        }

        public string Deslogar()
        {
            Logado = false;
            Console.WriteLine($"Usuário deslogado !");
            return $"";
        }
    }
}