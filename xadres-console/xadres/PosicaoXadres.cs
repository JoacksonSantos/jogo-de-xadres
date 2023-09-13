using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using xadres_console.Tabuleiro;

namespace xadres_console.xadres
{
    internal class PosicaoXadres
    {
        public char coluna { get; set; }
        public int linha { get; set; }

        public PosicaoXadres(char coluna, int linha)
        {
            this.coluna = coluna;
            this.linha = linha;
        }
        public Posicao toPosica()
        {
            return new Posicao(8-linha, coluna - 'a');
        }
        public override string ToString()
        {
            return "" + coluna + linha;
           
        }
    }
}
