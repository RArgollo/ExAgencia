namespace ExAgencia
{
    public class Pedido
    {
        public List<Passagem> Passagens { get; set; }
        public List<Pacote> Pacotes { get; set; }
        public int FormaPagamento { get; set; }
    }
}