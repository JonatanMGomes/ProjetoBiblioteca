namespace ProjetoBiblioteca
{
    public class Editora
    {
        public string Nome { get; set; }
        public string Cidade { get; set; }
        public Editora(string nome, string cidade)
        {
            Nome = nome;
            Cidade = cidade;
        }
    }
}