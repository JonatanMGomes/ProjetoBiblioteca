namespace ProjetoBiblioteca
{
    public class Livro
    {
        public string Titulo { get; private set; }
        public int AnoPublicacao { get; private set; }
        public int Edicao { get; private set; }
        public Editora Editora { get; private set; }
        public string Autor { get; private set; }
        public string Classificacao { get; private set; }
        public string Idioma { get; private set; }
        public bool Disponibilidade { get; private set; }
        public Livro(string titulo, int anoPublicacao, int edicao, Editora editora, string autor, string classificacao, string idioma)
        {
            Titulo = titulo;
            AnoPublicacao = anoPublicacao;
            Edicao = edicao;
            Editora = editora;
            Autor = autor;
            Classificacao = classificacao;
            Idioma = idioma;
            Disponibilidade = true;
        }
        public void AtualizarDisponibilidade(bool novoStatus)
        {
            Disponibilidade = novoStatus;
        }
    }
}