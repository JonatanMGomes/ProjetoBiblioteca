namespace ProjetoBiblioteca
{
    public class Funcionario : Usuario
    {
        public string Senha { get; set; }
        public Funcionario(string nome, string senha) : base(nome)
        {
            Senha = senha;
        }
    }
}