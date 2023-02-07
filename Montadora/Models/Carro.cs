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
                PercentualCombustivel = PercentualCombustivel - 3;
                Ligado = true;
                if (PercentualCombustivel <= 0)
                {
                    PercentualCombustivel = 0;
                    Desligar();
                }

            }

        }

        public void Desligar()
        {
            Ligado = false;
            Parar();
        }
        public void Acelerar(int _impulso)
        {
            if (Ligado == true && _impulso > 0)
            {
                Odometro += 18; 
                PercentualCombustivel = PercentualCombustivel - 8;

                if(PercentualCombustivel <= 0)
                {
                    PercentualCombustivel = 0;
                    Desligar();
                    return;
                }

                VelocidadeAtual = VelocidadeAtual + _impulso; // VelocidadeAtual = VelocidadeAtual + _impulso; 
                PneuDianteiroDireito.Girar(_impulso);
                PneuDianteiroEsquerdo.Girar(_impulso);
                PneuTraseiroDireito.Girar(_impulso);
                PneuTraseiroEsquerdo.Girar(_impulso);
                if (PneuDianteiroDireito.Estourado || PneuDianteiroEsquerdo.Estourado || PneuTraseiroDireito.Estourado || PneuTraseiroEsquerdo.Estourado)
                {
                    Parar();
                }

            }
        }

        private void Parar()
        {
            VelocidadeAtual = 0;
            PneuDianteiroDireito.VelocidadeAtual = 0;
            PneuDianteiroEsquerdo.VelocidadeAtual = 0;
            PneuTraseiroDireito.VelocidadeAtual = 0;
            PneuTraseiroEsquerdo.VelocidadeAtual = 0;

        }

        public void Frear(int _reduzir)
        {
            VelocidadeAtual = VelocidadeAtual - _reduzir;

            if (VelocidadeAtual < 0)
                VelocidadeAtual = 0;

            PneuDianteiroDireito.Frear(_reduzir);
            PneuDianteiroEsquerdo.Frear(_reduzir);
            PneuTraseiroDireito.Frear(_reduzir);
            PneuTraseiroEsquerdo.Frear(_reduzir);

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
        public void Exibir()
        {
            Console.Clear();

            Console.WriteLine("Marca: " + Marca);
            Console.WriteLine("Cor: " + Cor);
            Console.WriteLine("Tipo: " + Tipo);
            Console.WriteLine("Combustivel: " + Combustivel);
            Console.WriteLine("Quantidade de Rodas: " + QuantidadeRodas);
            Console.WriteLine("Ano: " + Ano);
            Console.WriteLine("Odometro: " + Odometro);
            Console.WriteLine("Velocidade Máxima: " + VelocidadeMaxima);
            Console.WriteLine("Velocidade Atual: " + VelocidadeAtual);
            Console.WriteLine("Placa: " + Placa);
            Console.WriteLine("Modelo: " + Modelo);
            Console.WriteLine("Ligado: " + Ligado);
            Console.WriteLine("PercentualCombustivel: " + PercentualCombustivel);

            Console.WriteLine("\nPneuDianteiroEsquerdo");
            PneuDianteiroEsquerdo.Exibir();
            Console.WriteLine("\nPneuDianteiroDireito");
            PneuDianteiroDireito.Exibir();
            Console.WriteLine("\nPneuTraseiroEsquerdo");
            PneuTraseiroEsquerdo.Exibir();
            Console.WriteLine("\nPneuTraseiroDireito");
            PneuTraseiroDireito.Exibir();

        }
    }
}
