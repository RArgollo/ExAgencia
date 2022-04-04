namespace ExAgencia
{
    public class Pedido
    {
        public List<Passagem> Passagens { get; set; }
        public List<Pacote> Pacotes { get; set; }
        public Pessoa TitularPassagem { get; set; }
        public string FormaPagamento { get; set; }
        public double ValorTotal { get; set; }


        public Pedido()
        {
            Passagens = new List<passagens>();
            pacotes = new List<pacotes>();
        }


        public void CadastrarPedido() {
            Console.WriteLine("Bem vindo a melhor agencia de turismo da vila formosa!");
            TitularPassagem = DadosCliente();
            Preferencias();
            FecharVenda();
         }


         public Pessoa DadosCliente(){
            Console.WriteLine("Digite seu nome.")
             string nome = Console.ReadLine();
             Console.WriteLine("Digite seu CPF (apenas números).")
             string cpf = Console.ReadLine();
             Console.WriteLine("Informe sua data de nascimento (dd/MM/yy)");
             var dataNascimento = DateTime.Parse(Console.ReadLine());
             return new Pessoa(nome,cpf,dataNascimento);
         }


         public void Preferencias(){
             var continuarAdd = 0;
             do{
                 Console.WriteLine("Deseja adicionar ao carrinho uma passagem ou um pacote de viagem? 1-passgem ou 2-pacote.");
                 var opcao = Console.ReadLine();
                 if(opcao=="1"){
                     Passagens.Add(AddPassagem());
                 }
                 else if (opcao=="2"){
                     Pacotes.Add(AddPacote());
                 }
                 else{
                     Console.WriteLine("opcao invalida!");
                 }
                 Console.WriteLine("Deseja adicionar mais itens? 1-sim ou 2-nao");
                 continuarAdd=int.Parse(Console.ReadLine());
             }while(continuarAdd==1);
         }


         public Passagem AddPassagem(){
             Console.WriteLine("Deseja assento na 1ª classe ou classe econômica? 1- 1ª classe ou 2- classe economica")
             var classe = int.Parse(Console.ReadLine());
             ConsoleWriteLine("Escolha o assento desejado")
             var poltrona = int.Parse(Console.ReadLine());
             return new Passagem(1, poltrona, 800, TitularPassagem);
         }


            public Pacote AddPacote(){
             Console.WriteLine("Escolha as preferencias da passagem de ida")
            var passagemIda = AddPassagem();
             Console.WriteLine("Escolha as preferencias da passagem de volta")
            var passagemVolta = AddPassagem();
            return new Pacote(passagemIda,passagemVolta);
         }


         public void FecharVenda(){
             Console.WriteLine("Os itens escolhidos foram: ")
             ResumoItens();
             EscolherFormaPagamento();
             Console.WriteLine($"E será pago com {FormaPagamento}");
         }


         public void ResumoItens(){
             for int contador = 0; contador<Passagens.Length; contador++)
             {
                 Console.WriteLine(Passagens[contador].ResumoPassagem());
             }
              for int contador = 0; contador<Pacotes.Length; contador++)
             {
                 Console.WriteLine(Pacotes[contador].ResumoPacotes());
             }
             ValorTotal = CalcularTotal();
             Console.WriteLine($"O valor total da sua compra é de R${ValorTotal}.");
             Desconto();
         }


         public void EscolherFormaPagamento(){
             Console.WriteLine("Escolha a forma de pagamento desejada.")
             Console.WriteLine("vista, credito ou debito?");
             FormaPagamento = Console.ReadLine();
         }


         public double CalcularTotal(){
             double total = 0;
             for (var contador = 1; contador <Pacotes.Length; contador++)
             {
                total = total + Pacotes[contador].ValorPacote;
             }
             for (var contador = 1; contador <Passagens.Length; contador++)
             {
                total = total + Passagens[contador].ValorPassagem;FF
             }
             return Math.Abs(total);
         }

         public void Desconto(){
             if (ValorTotal > 5000){
                 ValorTotal = ValorTotal * 0.9;
                 Console.WriteLine($"O valor final com desconto é de R${ValorTotal}");
             }
             else if (ValorTotal > 500){
                 ValorTotal = ValorTotal * 0.95;
                 Console.WriteLine($"O valor final com desconto é de R${ValorTotal}");
             }
         }
    }
}
