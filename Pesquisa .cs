Marca 

-codigo: int 
-NomeMarca: string
-DataCadastro: DateTime 

+Cadastrar(marca): string 
+Listar(): List<Marca>
+Deletar(Marca): string


Produto 

-Codigo:int 
-NomeProduto: string
-Preco:float
-DataCadastro: DateTime
-Marca:Marca
-CadastradoPor:usuario 
-ListaDeProdutos: List<Produto>

+Cadastrar(Produto):string
+Listar(): list<Produto>
+Deletar(Produto):string


Usuario 

-codigo: int
-Nome: string
-email:string 
-senha:string
-DataCadastro: DateTime

+Cadastrar(usuario):string
+Deletar(usuario): string


Login

-Logado:bool

+login():void-construtor 
+Logar(usuario):string
+deslogar(usuario): string


public class Marca
{
    public int Codigo { get; set; }
    public string NomeMarca { get; set; }
    public DateTime DataCadastro { get; set; }
}

public class MarcaController
{
    private List<Marca> marcas;

    public MarcaController()
    {
        marcas = new List<Marca>();
    }

    public string Cadastrar(Marca marca)
    {
        marcas.Add(marca);
        return "Marca cadastrada com sucesso.";
    }

    public List<Marca> Listar()
    {
        return marcas;
    }

    public string Deletar(Marca marca)
    {
        if (marcas.Contains(marca))
        {
            marcas.Remove(marca);
            return "Marca removida com sucesso.";
        }
        else
        {
            return "Marca não encontrada.";
        }
    }
}

public class Produto
{
    public int Codigo { get; set; }
    public string NomeProduto { get; set; }
    public float Preco { get; set; }
    public DateTime DataCadastro { get; set; }
    public Marca Marca { get; set; }
    public Usuario CadastradoPor { get; set; }
}

public class ProdutoController
{
    private List<Produto> produtos;

    public ProdutoController()
    {
        produtos = new List<Produto>();
    }

    public string Cadastrar(Produto produto)
    {
        produtos.Add(produto);
        return "Produto cadastrado com sucesso.";
    }

    public List<Produto> Listar()
    {
        return produtos;
    }

    public string Deletar(Produto produto)
    {
        if (produtos.Contains(produto))
        {
            produtos.Remove(produto);
            return "Produto removido com sucesso.";
        }
        else
        {
            return "Produto não encontrado.";
        }
    }
}

public class Usuario
{
    public int Codigo { get; set; }
    public string Nome { get; set; }
    public string Email { get; set; }
    public string Senha { get; set; }
    public DateTime DataCadastro { get; set; }
}

public class UsuarioController
{
    private List<Usuario> usuarios;

    public UsuarioController()
    {
        usuarios = new List<Usuario>();
    }

    public string Cadastrar(Usuario usuario)
    {
        usuarios.Add(usuario);
        return "Usuário cadastrado com sucesso.";
    }

    public string Deletar(Usuario usuario)
    {
        if (usuarios.Contains(usuario))
        {
            usuarios.Remove(usuario);
            return "Usuário removido com sucesso.";
        }
        else
        {
            return "Usuário não encontrado.";
        }
    }
}


public class Login
{
    public bool Logado { get; private set; }
    public Usuario UsuarioLogado { get; private set; }

    public Login()
    {
        Logado = false;
        UsuarioLogado = null;
    }

    public void Logar(Usuario usuario)
    {
        if (!Logado)
        {
            // Verificar se o usuário e senha correspondem
            // Aqui você pode implementar a lógica de autenticação, como consultar um banco de dados, verificar credenciais, etc.
            // Vamos supor que o usuário seja considerado autenticado se o objeto de usuário for válido e a senha estiver correta
            if (usuario != null && usuario.Senha == "senha_correta")
            {
                Logado = true;
                UsuarioLogado = usuario;
                Console.WriteLine("Usuário logado com sucesso.");
            }
            else
            {
                Console.WriteLine("Usuário ou senha incorretos.");
            }
        }
        else
        {
            Console.WriteLine("Já existe um usuário logado.");
        }
    }

    public void Deslogar()
    {
        if (Logado)
        {
            Logado = false;
            UsuarioLogado = null;
            Console.WriteLine("Usuário deslogado com sucesso.");
        }
        else
        {
            Console.WriteLine("Nenhum usuário logado.");
        }
    }
}



