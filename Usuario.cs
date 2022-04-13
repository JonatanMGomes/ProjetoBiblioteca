namespace ProjetoBiblioteca
{
    public class Usuario
    {
        public string Nome { get; protected set; }
        public Usuario(string nome)
        {
            Nome = nome;
        }
    }
}