using tabuleiro;

namespace xadrez
{
    class PartidaXadrez
    {
        public Tabuleiro Tabuleiro { get; private set; }
        private int Turno;
        private Cor JogadorAtual;
        public bool Terminada { get; private set; }

        public PartidaXadrez()
        {
            Tabuleiro = new Tabuleiro(8,8);
            Turno = 1;
            JogadorAtual = Cor.Branca;
            OrganizarPecas();
        }

        public void ExecutarMovimento(Posicao origem, Posicao destino) //realizar jogada
        {
            Peca p = Tabuleiro.RetirarPeca(origem);
            p.IncrementarQtdMovimentos();
            Peca pecaCapturada = Tabuleiro.RetirarPeca(destino);
            Tabuleiro.PosicionarPeca(p, destino);
        }

        public void OrganizarPecas() //colocar pecas
        {
            Tabuleiro.PosicionarPeca(new Torre(Tabuleiro, Cor.Branca), new PosicaoXadrez('c',1).ParaPosicao());
            Tabuleiro.PosicionarPeca(new Torre(Tabuleiro, Cor.Branca), new PosicaoXadrez('c',2).ParaPosicao());
            Tabuleiro.PosicionarPeca(new Torre(Tabuleiro, Cor.Branca), new PosicaoXadrez('d',2).ParaPosicao());
            Tabuleiro.PosicionarPeca(new Torre(Tabuleiro, Cor.Branca), new PosicaoXadrez('e',2).ParaPosicao());
            Tabuleiro.PosicionarPeca(new Torre(Tabuleiro, Cor.Branca), new PosicaoXadrez('e',1).ParaPosicao());
            Tabuleiro.PosicionarPeca(new Rei(Tabuleiro, Cor.Branca), new PosicaoXadrez('d',1).ParaPosicao());

            Tabuleiro.PosicionarPeca(new Torre(Tabuleiro, Cor.Preta), new PosicaoXadrez('c', 7).ParaPosicao());
            Tabuleiro.PosicionarPeca(new Torre(Tabuleiro, Cor.Preta), new PosicaoXadrez('c', 8).ParaPosicao());
            Tabuleiro.PosicionarPeca(new Torre(Tabuleiro, Cor.Preta), new PosicaoXadrez('d', 7).ParaPosicao());
            Tabuleiro.PosicionarPeca(new Torre(Tabuleiro, Cor.Preta), new PosicaoXadrez('e', 7).ParaPosicao());
            Tabuleiro.PosicionarPeca(new Torre(Tabuleiro, Cor.Preta), new PosicaoXadrez('e', 8).ParaPosicao());
            Tabuleiro.PosicionarPeca(new Rei(Tabuleiro, Cor.Preta), new PosicaoXadrez('d', 8).ParaPosicao());
        }
    }
}
