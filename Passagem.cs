namespace ExAgencia
{
    public class Passagem
    {
        public string Empresa { get; set; }
        public string Classe { get; set; }
        public int Poltrona { get; set; }
        public int Valor { get; set; }
        public DateTime HorarioEmbarque { get; set; }
        public DateTime DataPassagem { get; set; }
        public Passagem(string empresa, string classe, int poltrona, int valor, string dataPassagem)
        {
            Empresa = empresa;
            Classe = classe;
            Poltrona = poltrona;
            Valor = valor;
            DataPassagem = DateTime.Parse(dataPassagem);
        }
    }
}