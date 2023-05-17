namespace ProductManager
{
    public class Usuario
    {
        public int Codigo { get; private set; }
        public string Nome { get; private set; }
        public string Email { get; private set; }
        public string Senha { get; private set; }
        public DateTime DataCadastro { get; private set; } 

        public Usuario ()
        {
        Cadastrar();
        }

        public string Cadastrar(Usuario usuario)
        {
            return "0";
        }

        public string Deletar(Usuario usuario)
        {
            return "0";
        }
    }
}