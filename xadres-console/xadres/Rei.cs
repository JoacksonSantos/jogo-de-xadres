using xadres_console.Tabuleiro;

namespace xadres
{
    internal class Rei:Peca
    {
        public Rei(TabuleiroC tab, Cor cor) : base(tab, cor)
        {

        }

        public override string ToString()
        {
            return "R";
        }
    }
}
