using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using xadres_console.Tabuleiro;

namespace xadres
{
    internal class Torre : Peca
    {
        public Torre(TabuleiroC tab, Cor cor) : base(tab, cor)
        {

        }

        public override string ToString()
        {
            return "T ";
        }
    }
}

