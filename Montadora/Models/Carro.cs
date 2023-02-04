namespace Models
{
    public class Carro
    {
        public string? Marca { get; set; }
        public string? Cor { get; set; }
        public string? Tipo { get; set; }
        public string? Combustivel { get; set; }
        public int QuantidadeRodas { get; set; }
        public int Ano { get; set; }
        public int Odometro { get; set; }
        public int VelocidadeMaxima { get; set; }
        public int VelocidadeAtual { get; set; }
        public string Placa { get; set; }
        public string? Modelo { get; set; }
        public bool Ligado { get; set; }
        public int PercentualCombustivel { get; set; }
        public Pneu PneuDianteiroEsquerdo { get; set; }
        public Pneu PneuDianteiroDireito { get; set; }
        public Pneu PneuTraseiroEsquerdo { get; set; }
        public Pneu PneuTraseiroDireito { get; set; }
        public Pneu PneuEstepe { get; set; }



        public Carro(string _marca, string cor, string? tipo, string? combustivel, int quantidadeRodas, int _ano, int odometro, int _velocidadeMaxima, string placa, string? _modelo, bool ligado)
        {
            Marca = _marca;
            Modelo = _modelo;
            Ano = _ano;
            VelocidadeMaxima = _velocidadeMaxima;
            VelocidadeAtual = 0;
            Odometro = 0;
            Ligado = false;
            PercentualCombustivel = 0;
            PneuDianteiroDireito = new Pneu(16, 150, "Carro de passeio");
            PneuDianteiroEsquerdo = new Pneu(16, 150, "Carro de passeio");
            PneuTraseiroDireito = new Pneu(16, 150, "Carro de passeio");
            PneuTraseiroEsquerdo = new Pneu(16, 150, "Carro de passeio");
            PneuEstepe = new Pneu(16, 70, "Estepe", true);

            Cor = cor;
            Tipo = tipo;
            QuantidadeRodas = quantidadeRodas;
            Placa = placa;
        }

        public void Ligar()
        {
            if (PercentualCombustivel > 0)
            {
                Ligado = true;

            }
            
        }

        public void Desligar()
        {
            Ligado = false;
            VelocidadeAtual = 0;
            PneuDianteiroDireito.VelocidadeAtual = 0;
            PneuDianteiroEsquerdo.VelocidadeAtual = 0;
            PneuTraseiroDireito.VelocidadeAtual = 0;
            PneuTraseiroEsquerdo.VelocidadeAtual = 0;
        }
        public void Acelerar()
        {

        }
        public void Frear() 
        {

        }
        public void Abastecer()
        {

        }


    }
}
