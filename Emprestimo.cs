namespace ProjetoBiblioteca
{
    public class Emprestimo
    {
        public Livro LivroEmprestado { get; private set; }
        public DateOnly DataEmprestimo { get; private set; }
        public Emprestimo(Livro livroEmprestado, DateOnly dataEmprestimo)
        {
            LivroEmprestado = livroEmprestado;
            DataEmprestimo = dataEmprestimo;
        }
    }
}