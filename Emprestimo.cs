namespace ProjetoBiblioteca
{
    public class Emprestimo
    {
        public Livro LivroEmprestado { get; set; }
        public DateOnly DataEmprestimo { get; set; }
        public Emprestimo(Livro livroEmprestado, DateOnly dataEmprestimo)
        {
            LivroEmprestado = livroEmprestado;
            DataEmprestimo = dataEmprestimo;
        }
    }
}