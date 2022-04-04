namespace ExAgencia
{
    public class Pessoa
    {
        public string Nome { get; set; }
        public string CPF {get; set;}
        public DateTime DataNascimento {get; set;}
        public Pessoa(string nome, string cpf, DateTime dataNascimento)
        {
            Nome = nome;
            CPF = cpf;
            DataNascimento = dataNascimento;
        }
        public string PrimeiroNome(){
            string[] primeiroNome = Nome.Split(' ');
            return primeroNome[0];
        }
    }
}