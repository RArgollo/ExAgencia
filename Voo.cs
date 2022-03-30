namespace ExAgencia
{
    public class Voo
    {
        public int NumeroVoo { get; set; }
        public DateTime HorarioVoo { get; set; }    
        public string Destino { get; set; }
        public string Origem { get; set; }
        public Voo(int numeroVoo, string destino, string origem)
        {
            NumeroVoo = numeroVoo;
            Destino = destino;
            Origem = origem;
        }
    }
}