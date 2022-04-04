namespace ExAgencia
{
    public class Voo
    {
        public int NumeroVoo { get; set; }
        public string Origem { get; set; }
        public string Destino { get; set; }
        public DateTime HorarioEmbarque { get; set; }
        public DateTime DataPassagem { get; set; }
        public string Agencia { get; set; }

        public Voo(int numeroVoo, string origem, string destino, DateTime horarioEmbarque, DateTime DataPassagem, string agencia)
        {
            NumeroVoo = numeroVoo;
            Origem = origem;
            Destino = destino;
            HorarioEmbarque = horarioEmbarque;
            DataPassagem = dataPassagem;
            Agencia = agencia;
        }
    }
}
