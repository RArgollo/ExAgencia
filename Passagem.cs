namespace ExAgencia
{
    public class Passagem
    {
        public int Classe { get; set; }
        public int Poltrona { get; set; }
        public double Valor { get; set; }
        public Pessoa Passageiro {get; set;}
        public Voo Voo { get; set; }
        
        public Passagem(int classe, int poltrona, double valor, Pessoa passageiro)
        {
            Classe = classe;
            Poltrona = poltrona;
            Valor = CalcularValor(valor);
            Passageiro = passageiro;
            Voo = new Voo (542, "Piauí", "Rio de Janeiro", DateTime.Parse("15:00:00"), DateTime.Parse("15/02/2023"), "GOL");
        }

        public string ResumoPassagem(){
            return Console.WriteLine($"Cliente {Passageiro.PrimeiroNome()}, poltrona número {Poltrona} e o valor da passagem é de R${Valor}.")
        }
        public double CalcularValor(valor){
            if(classe==1){
                return valor = valor*3;
            }
            else{
                return Math.Abs(valor);
            }
        }
    }
}