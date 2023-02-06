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



        public Carro(string _marca, string _cor, string? _tipo, int _quantidadeRodas, int _ano, int _velocidadeMaxima, string _placa, string? _modelo)
        {
            Marca = _marca;
            Cor = _cor;
            Tipo = _tipo;
            QuantidadeRodas = _quantidadeRodas;
            Ano = _ano;
            VelocidadeMaxima = _velocidadeMaxima;
            Placa = _placa;
            Modelo = _modelo;

            VelocidadeAtual = 0;
            Odometro = 0;
            Ligado = false;
            PercentualCombustivel = 0;

            PneuDianteiroDireito = new Pneu(16, 150, "Carro de passeio");
            PneuDianteiroEsquerdo = new Pneu(16, 150, "Carro de passeio");
            PneuTraseiroDireito = new Pneu(16, 150, "Carro de passeio");
            PneuTraseiroEsquerdo = new Pneu(16, 150, "Carro de passeio");
            PneuEstepe = new Pneu(16, 70, "Estepe", true);

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
        public void Acelerar(int _impulso)
        {
            if (Ligado == true && _impulso > 0)
            {

                PneuDianteiroDireito.VelocidadeAtual = //todas irão receber o valor da última linha
                PneuDianteiroEsquerdo.VelocidadeAtual = //
                PneuTraseiroDireito.VelocidadeAtual = //
                PneuTraseiroEsquerdo.VelocidadeAtual = //
                VelocidadeAtual += _impulso;// VelocidadeAtual = VelocidadeAtual + _impulso; 

            }
        }
        public void Frear(int _reduzir)
        {
            VelocidadeAtual = VelocidadeAtual - _reduzir;

            if (VelocidadeAtual < 0)
                VelocidadeAtual = 0;

        }
        /// <summary>
        /// Este método vai abastecer o carro.
        /// </summary>
        /// <param name="_quantidadeCombustivel">Informe o percentual de combustível 
        /// que deseja abastecer, caso informe 0 o método irá completar o tanque.
        /// O valor não pode ser superior a 100</param>
        public void Abastecer(int _quantidadeCombustivel = 0)
        {
            if (_quantidadeCombustivel == 0)
                _quantidadeCombustivel = 100 - PercentualCombustivel;
            {

            }
            if (PercentualCombustivel + _quantidadeCombustivel > 100)
            {
                Console.WriteLine("A quantidade de combustível ultrapassa o limite do tanque:");
                return;
            }

            if (PercentualCombustivel < 100)
                PercentualCombustivel = PercentualCombustivel + _quantidadeCombustivel;

        }


    }
}
