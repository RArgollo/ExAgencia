namespace ExAgencia
{
    public class Pedido
    {
        public List<Passagem> Passagens { get; set; }
        public List<Pacote> Pacotes { get; set; }
        public int FormaPagamento { get; set; }

        public Pedido(List<Passagem> passagens, List<Pacote> pacotes)
        {
            Passagens = passagens;
            pacotes = pacotes;
        }
        public void CadastrarPedido()
        {
            do
            {
                Console.WriteLine("Deseja adicionar um novo pacote? 1-sim ou 2-nao");
                int opçao = int.Parse(Console.ReadLine());
                if(opçao==1){
                    
                }
            } while (true);
        }
    }
}