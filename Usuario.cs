namespace ProductManager
{
    public class Usuario
    {
        public int Codigo { get; private set; }

        public string Nome { get; private set; }

        public string Email { get; private set; }

        public string Senha { get; private set; }

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