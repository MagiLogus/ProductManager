namespace ProductManager
{
    public class Usuario
    {
        public int Codigo { get; private set; }
        public string Nome { get; private set; }
        public string Email { get; private set; }
        public string Senha { get; private set; }
        public DateTime DataCadastro { get; private set; }

        public Usuario()
        {
            Cadastrar();
        }

        public string Cadastrar()
        {
            Nome = "Paulo";
            Email = "paulo";
            Senha = "123";
            return "Usuario Cadastrado com Sucesso !";
        }

        public string Deletar()
        {
            Nome = "";
            Email = "";
            Senha = "";
            return "usuario deletado !";
        }
    }
}