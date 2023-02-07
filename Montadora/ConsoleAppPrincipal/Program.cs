using Models;

namespace ConsoleAppPrincipal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pneu pneu1 = new Pneu(16, 150, "Carro de passeio");//classe e objeto
            //pneu1.Girar(6);
            //pneu1.Exibir();

            //Console.WriteLine();

            Pneu pneu2 = new Pneu(16, 70, "Pneu de estepe", true);//classe e objeto
            //Carro corcel = new Carro();
            //pneu2.Girar(6);
            //pneu2.Exibir();


            /*pneu1.Girar(6);
            pneu2.Girar(15);
            pneu2.Girar(10);
            pneu2.Frear(5);
            pneu2.Girar(20);
            pneu2.Girar(20);
            pneu2.Girar(5);
            pneu1.Exibir();*/

            //Console.WriteLine();

            Carro carro1 = new Carro("FUSION", "VERMELHO", "ESPORTE", 4, 2023, 230, "AJ01N23", "SEDAN");
            carro1.Abastecer(80);
            carro1.Ligar();
            carro1.Acelerar(15);
            carro1.Acelerar(5);
            carro1.Acelerar(22);
            carro1.Frear(8);
            carro1.Acelerar(3);
            carro1.Frear(4);
            carro1.Desligar();
            carro1.PneuDianteiroEsquerdo = carro1.PneuEstepe;
            carro1.Ligar();
            carro1.Ligar();
            carro1.Acelerar(15);
            carro1.Acelerar(5);
            carro1.Acelerar(22);
            carro1.Frear(8);
            carro1.Acelerar(3);
            carro1.Acelerar(3);
            carro1.Acelerar(3);
            carro1.Abastecer(80);
            carro1.Ligar();
            carro1.Acelerar(40);
            carro1.Acelerar(29);
            carro1.Acelerar(1);
            carro1.Acelerar(2);
            carro1.Frear(4);
            carro1.Exibir();

            Console.WriteLine();
        }
    }
}