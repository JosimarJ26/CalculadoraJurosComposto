namespace Calculadora.Model
{
    struct Investimento
    {
        public double cap_inicial { get; set; }
        public double taxa_juros { get; set; }
        public int tempo { get; set; }
        public double aporte { get; set; }
        public double cap_futuro { get; set; }
        public double totalJuros { get; set; }
        public double totalAporte { get; set; }

    }
}
