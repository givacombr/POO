namespace Models
{
    public class Pneu //classe
    {   //logo abaixo sao os atributos
        public int Aro { get; set; }//metodos e atributos ou propriedade get compara e set atribui
        public bool TWI { get; set; }
        public string? Cor { get; set; }
        public string? Marca { get; set; }
        public int VelocidadeMaxima { get; set; }
        public int VelocidadeAtual { get; set; }
        public bool Estepe { get; set; }
        public bool Estourado { get; set; }
        public bool Furado { get; set; }
        public string? Tipo { get; set; }
        public int PercentualBorracha { get; set; }

        public Pneu(int _aro, string _tipo, string _marca, bool _estepe, int _velocidadeMaxima)
        {
            Aro = _aro;
            Tipo = _tipo;
            Marca = _marca;
            Estepe = _estepe;
            VelocidadeMaxima = _velocidadeMaxima;
            Cor = "Preto";
            Furado = false;
            Estourado = false;
            VelocidadeAtual = 0;
            PercentualBorracha = 100;
            TWI = false;
        }

        public void Girar(int _velocidade)//acoes ou metodos
        {
            if (Estourado == true)
            {
                Console.WriteLine("O pneu está estourado.");
                return;
            }
            if (Furado == true)
            {
                Console.WriteLine("O pneu está furado.");
                return;
            }

            VelocidadeAtual = VelocidadeAtual + _velocidade;//_velocidade é parametro passando a informacao para o metodo
            //VelocidadeAtual += _velocidade (forma resumida de escrever)
            PercentualBorracha = PercentualBorracha - 3;
            //PercentualBorracha -= 3; (forma resumida de escrever)

            if (VelocidadeAtual > VelocidadeMaxima || PercentualBorracha <=30)
            {
                EstourarPneu();
            }

        }
        public void Frear(int _reducao)
        {
            VelocidadeAtual = VelocidadeAtual - _reducao;
            PercentualBorracha = PercentualBorracha - 5;

            if (VelocidadeAtual < 0)
            {
                VelocidadeAtual = 0;
            }

            if (PercentualBorracha < 0)
            {
                PercentualBorracha = 0;
            }

            if (PercentualBorracha <= 30)
            {
                EstourarPneu();
            }

        }

        private void EstourarPneu()
        {
            Estourado = true;
            VelocidadeAtual = 0;
        }

        public void Exibir()
        {
            Console.WriteLine("Cor: " + Cor);
            Console.WriteLine("Tipo: " + Tipo);
            Console.WriteLine("Marca: " + Marca);
            Console.WriteLine("Aro: " + Aro);
            Console.WriteLine("Furado: " + Furado);
            Console.WriteLine("Estourado: " + Estourado);
            Console.WriteLine("Estepe: " + Estepe);
            Console.WriteLine("Velocidade Atual: " + VelocidadeAtual);
            Console.WriteLine("Velocidade Máxima: " + VelocidadeMaxima);
            Console.WriteLine("Percentual Borracha: " + PercentualBorracha);
            Console.WriteLine("TWI: " + TWI);
        }
    }
}