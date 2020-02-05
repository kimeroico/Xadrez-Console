using System;
using Tabuleiro;

namespace Xadrez
{
    class PartidaDeXadrez
    {

        public Tabuleiros tab { get; private set; }
        private int turno;
        private Cor jogadorAtual;
        public bool terminada { get; private set; }

        public PartidaDeXadrez()
        {
            tab = new Tabuleiros(8, 8);
            turno = 1;
            jogadorAtual = Cor.Branca;
            terminada = false;
            colocarPecas();
        }

        public void executaMovimento(Posicao origem, Posicao destino)
        {
            Peca p = tab.RetiraPeca(origem);
            p.incrementarQteMovimentos();
            Peca pecaCapturada = tab.RetiraPeca(destino);
            tab.ColocarPeca(p, destino);
        }

        private void colocarPecas()
        {
            tab.ColocarPeca(new Torre(Cor.Branca, tab), new PosicaoXadrez('c', 1).toPosicao());
            tab.ColocarPeca(new Torre(Cor.Branca, tab), new PosicaoXadrez('c', 2).toPosicao());
            tab.ColocarPeca(new Torre(Cor.Branca, tab), new PosicaoXadrez('d', 2).toPosicao());
            tab.ColocarPeca(new Torre(Cor.Branca, tab), new PosicaoXadrez('e', 2).toPosicao());
            tab.ColocarPeca(new Torre(Cor.Branca, tab), new PosicaoXadrez('e', 1).toPosicao());
            tab.ColocarPeca(new Rei(Cor.Branca, tab), new PosicaoXadrez('d', 1).toPosicao());

            tab.ColocarPeca(new Torre(Cor.Preta, tab), new PosicaoXadrez('c', 7).toPosicao());
            tab.ColocarPeca(new Torre(Cor.Preta, tab), new PosicaoXadrez('c', 8).toPosicao());
            tab.ColocarPeca(new Torre(Cor.Preta, tab), new PosicaoXadrez('d', 7).toPosicao());
            tab.ColocarPeca(new Torre(Cor.Preta, tab), new PosicaoXadrez('e', 8).toPosicao());
            tab.ColocarPeca(new Torre(Cor.Preta, tab), new PosicaoXadrez('e', 7).toPosicao());
            tab.ColocarPeca(new Rei(Cor.Preta, tab), new PosicaoXadrez('d', 8).toPosicao());
        }

    }
}
