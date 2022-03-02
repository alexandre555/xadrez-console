using System;
using tabuleiro;
using xadrez;

namespace xadrez_console
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                PartidaXadrez partida = new PartidaXadrez();

                while (!partida.Terminada)
                {
                    Console.Clear();
                    Tela.ImprimindoTabuleiro(partida.Tabuleiro);

                    Console.WriteLine("");

                    Console.Write("Origem: ");
                    Posicao origem = Tela.LerPosicaoXadrez().ParaPosicao();

                    Console.Write("Destino: ");
                    Posicao destino = Tela.LerPosicaoXadrez().ParaPosicao();

                    partida.ExecutarMovimento(origem, destino);
                }

                /*PosicaoXadrez pos = new PosicaoXadrez('c', 7);
                Console.WriteLine(pos);
                Console.WriteLine(pos.ParaPosicao());

                Posicao p = new Posicao(3, 4);
                Tabuleiro tab = new Tabuleiro(8, 8);

                tab.PosicionarPeca(new Torre(tab, Cor.Preta), new Posicao(0, 0));
                tab.PosicionarPeca(new Torre(tab, Cor.Preta), new Posicao(1, 3));
                tab.PosicionarPeca(new Rei(tab, Cor.Preta), new Posicao(2, 4));


                Tela.ImprimindoTabuleiro(tab);*/

                Console.ReadKey();
            }
            catch (TabuleiroException e)
            {
                Console.WriteLine("Error: "+e.Message);
            }

        }
    }
}
