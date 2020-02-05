using Tabuleiro;

namespace Xadrez
{
    class Torre : Peca
    {
        public Torre(Cor cor, Tabuleiros tab) : base(cor, tab)
        {
        }

        public override string ToString()
        {
            return "T";
        }
    }
}
