namespace tabuleiro
{
    class Tabuleiro
    {
        public int Linhas { get; set; }
        public int Colunas { get; set; }

        private Peca[,] Pecas;

        public Tabuleiro() { }

        public Tabuleiro(int linhas, int colunas)
        {
            Linhas = linhas;
            Colunas = colunas;
            Pecas = new Peca[linhas, colunas];
        }

        public Peca PegarPeca(int linha, int coluna)
        {
            return Pecas[linha, coluna];
        }

        public Peca PegarPeca(Posicao pos)
        {
            return Pecas[pos.Linha, pos.Coluna];
        }

        public void PosicionarPeca(Peca p, Posicao pos)
        {
            if (ExistePeca(pos))
                throw new TabuleiroException("Já existe uma peça nessa posição!");

            Pecas[pos.Linha, pos.Coluna] = p;
            p.Posicao = pos;
        }

        public Peca RetirarPeca(Posicao pos)
        {
            if (PegarPeca(pos) == null) return null;
            Peca aux = PegarPeca(pos);
            Pecas[pos.Linha, pos.Coluna] = null;
            return aux;
        }

        public bool ExistePeca(Posicao pos)
        {
            ValidarPosicao(pos);
            return PegarPeca(pos) != null;
        }

        public bool PosicaoValida(Posicao pos)
        {
            return !(pos.Linha < 0 || pos.Linha >= Linhas || pos.Coluna < 0 || pos.Coluna >= Colunas);
        }

        public void ValidarPosicao(Posicao pos)
        {
            if(!PosicaoValida(pos))
                throw new TabuleiroException("Posição Inválida!");
        }
    }
}
