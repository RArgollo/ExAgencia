namespace ExAgencia
{
    public class Pacote
    {
        public DateTime DataIda { get; set; }
        public DateTime DataVolta { get; set; }
        public int Valor { get; set; }

        public Pacote(string dataIda, string dataVolta, int valor)
        {
            DataIda = DateTime.Parse(dataIda);
            DataVolta = DateTime.Parse(dataVolta);
            Valor = valor;
        }
        public void CadastrarPacote()
        {
            Console.WriteLine("Selecione 1-sim ou 2-não para os adicionais desejados");
            Console.WriteLine("Café da manhã 1-sim ou 2-não");
            string opçao = Console.ReadLine();
            if (opçao == "1")
            {
                Valor = Valor + 15;
            }
            Console.WriteLine("Almoço 1-sim ou 2-não");
            opçao = Console.ReadLine();
            if (opçao == "1")
            {
                Valor = Valor + 20;
            }
            Console.WriteLine("Janta 1-sim ou 2-não");
            opçao = Console.ReadLine();
            if (opçao == "1")
            {
                Valor = Valor + 25;
            }
            Console.WriteLine("Passeios locias 1-sim ou 2-não");
            opçao = Console.ReadLine();
            if (opçao == "1")
            {
                Valor = Valor + 40;
            }
        }
    }
}