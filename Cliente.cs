namespace ProjetoBiblioteca
{
    public class Cliente : Usuario
    {
        public string Curso { get; set; }
        public DateOnly DataInicio { get; set; }
        public DateOnly DataFimPrevista { get; set; }
        public Cliente(string nome, string curso, DateOnly dataInicio, DateOnly dataFimPrevista) : base(nome)
        {
            Curso = curso;
            DataInicio = dataInicio;
            DataFimPrevista = dataFimPrevista;
        }
    }
}