namespace Models
{
    public class Pneu
    {
        public string? Cor { get; set; }
        public int Aro { get; set; }
        public string? Tipo { get; set; }
        public bool TWI { get; set; }
        public int PercentualBorracha { get; set; }
        public bool Estourado { get; set; }
        public int VelocidadeMaxima { get; set; }
        public int VelocidadeAtual { get; set; }
        public bool Estepe { get; set; }

        public void Girar(int _velocidade)
        {
            VelocidadeAtual = VelocidadeAtual + _velocidade;
            PercentualBorracha = PercentualBorracha - 3;

            if (VelocidadeAtual > VelocidadeMaxima || PercentualBorracha <= 30)
            {
                EstourarPneu();
            }
        }

        public void EstourarPneu()
        {
                Estourado = true;
                VelocidadeAtual = 0;
        }
        public void Frear(int _reducao)
        {
            VelocidadeAtual = VelocidadeAtual - _reducao;
            PercentualBorracha = PercentualBorracha - 5;

            if (PercentualBorracha <= 30)
            {
                EstourarPneu();
            }

            if (VelocidadeAtual < 0)
            {
                VelocidadeAtual = 0;
            }
        }
    }
}