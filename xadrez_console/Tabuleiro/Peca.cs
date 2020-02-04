namespace Tabuleiro
{
    class Peca
    {

        public Posicao Posicao { get; set; }
        public Cor Cor { get; protected set; }
        public int QtdMovimentos { get; protected set; }
        public Tabuleiros Tab { get; protected set; }

        public Peca(Posicao posicao, Cor cor, Tabuleiros tab)
        {
            Posicao = posicao;
            Cor = cor;
            Tab = tab;
            QtdMovimentos = 0;
        }
    }
}
