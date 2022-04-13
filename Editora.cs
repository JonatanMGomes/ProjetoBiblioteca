namespace ProjetoBiblioteca
{
    public class Editora
    {
        public string Nome { get; private set; }
        public string Cidade { get; private set; }
        public Editora(string nome, string cidade)
        {
            Nome = nome;
            Cidade = cidade;
        }
    }
}