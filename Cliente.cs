namespace ProjetoBiblioteca
{
    public class Cliente : Usuario
    {
        public string Curso { get; private set; }
        public DateOnly DataInicio { get; private set; }
        public DateOnly DataFimPrevista { get; private set; }
        public List<Emprestimo> MeusEmprestimos { get; private set; }
        public Cliente(string nome, string curso, DateOnly dataInicio, DateOnly dataFimPrevista) : base(nome)
        {
            Curso = curso;
            DataInicio = dataInicio;
            DataFimPrevista = dataFimPrevista;
            MeusEmprestimos = new List<Emprestimo>();
        }
        public void SolicitarNovoEmprestimo(Emprestimo novoEmprestimo)
        {
            MeusEmprestimos.Add(novoEmprestimo);
        }
        public void RemoverEmprestimoDaLista(Emprestimo emprestimoARemover)
        {
            MeusEmprestimos.RemoveAll(emprestimo => emprestimo.LivroEmprestado.Titulo == emprestimoARemover.LivroEmprestado.Titulo);
        }
        public void AlterarDataFimPrevista(DateOnly novaDataFimPrevista)
        {
            DataFimPrevista = novaDataFimPrevista;
        }
    }
}