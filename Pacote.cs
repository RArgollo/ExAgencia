namespace ExAgencia
{
    public class Pacote
    {
        public int ValorPacote { get; set; }
        public Passagem PassagemIda { get; set; }
         public Passagem PassagemVolta { get; set; }

        public Pacote(Passagem passagemIda, Passagem passagemVolta)
        {
            PassagemIda = passagemIda;
            PassagemVolta = passagemVolta;
            CadastrarPacote();
        }

        public void CadastrarPacote()
        {
            Console.WriteLine("Selecione 1-sim ou 2-não para os adicionais desejados");
            Console.WriteLine("Café da manhã 1-sim ou 2-não");
            string opçao = Console.ReadLine();
            if (opçao == "1")
            {
                ValorPacote = ValorPacote + 15;
            }
            Console.WriteLine("Almoço 1-sim ou 2-não");
            opçao = Console.ReadLine();
            if (opçao == "1")
            {
                ValorPacote = ValorPacote + 20;
            }
            Console.WriteLine("Janta 1-sim ou 2-não");
            opçao = Console.ReadLine();
            if (opçao == "1")
            {
                ValorPacote = ValorPacote + 25;
            }
            Console.WriteLine("Passeios locias 1-sim ou 2-não");
            opçao = Console.ReadLine();
            if (opçao == "1")
            {
                ValorPacote = ValorPacote + 40;
            }
        }
        public double CalcularTotal(){
            ValorPacote = PassagemIda.Valor + PassagemVolta.Valor + ValorPacote;
        }
        public string ResumoPacote(){
            return Console.WriteLine($"Cliente {Passageiro.PrimeiroNome()} e o valor do pacote é de R${ValorPacote}.")
        }
    }
}
