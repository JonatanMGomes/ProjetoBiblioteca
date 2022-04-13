namespace ProjetoBiblioteca
{
    public class Livro
    {
        public string Titulo { get; set; }
        public int AnoPublicacao { get; set; }
        public int Edicao { get; set; }
        public Editora Editora { get; set; }
        public string Autor { get; set; }
        public string Classificacao { get; set; }
        public string Idioma { get; set; }
        public bool Disponibilidade { get; set; }
        public Livro(string titulo, int anoPublicacao, int edicao, Editora editora, string autor, string classificacao, string idioma)
        {
            Titulo = titulo;
            AnoPublicacao = anoPublicacao;
            Edicao = edicao;
            Editora = editora;
            Autor = autor;
            Classificacao = classificacao;
            Idioma = idioma;
        }
    }
}