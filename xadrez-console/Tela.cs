using System;
using tabuleiro;
using xadrez;

namespace xadrez_console
{
    class Tela
    {
        public static void ImprimindoTabuleiro(Tabuleiro tab)
        {
            for(int i=0; i<tab.Linhas; i++)
            {
                Console.Write(8-i+" ");
                for (int j = 0; j < tab.Colunas; j++)
                {
                    //Console.Write((tab.PegarPeca(i, j) == null ? "-" : ImprimirPeca(tab.PegarPeca(i, j))) + " ");
                    if(tab.PegarPeca(i, j) == null)
                    {
                        Console.Write("- ");
                    }
                    else
                    {
                        ImprimirPeca(tab.PegarPeca(i, j));
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine("  a b c d e f g h");
        }

        public static void ImprimirPeca(Peca peca)
        {
            if (peca.Cor == Cor.Branca) Console.Write(peca);
            else
            {
                var aux = Console.ForegroundColor;
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write(peca);
                Console.ForegroundColor = aux;
            }
        }

        public static PosicaoXadrez LerPosicaoXadrez()
        {
            string s = Console.ReadLine();
            char coluna = s[0];
            int linha = int.Parse(s[1]+"");
            return new PosicaoXadrez(coluna, linha);
        }
    }
}
