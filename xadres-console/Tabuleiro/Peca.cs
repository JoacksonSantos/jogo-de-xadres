using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace xadres_console.Tabuleiro
{
    public abstract class Peca
    {
        public Posicao posicao { get; set; }
        public Cor cor { get; protected set; }
        public int qteMovimentos { get; protected set; }
        public TabuleiroC tab { get; private set; }

        public Peca( TabuleiroC tab, Cor cor)
        {
            this.posicao = null;
            this.cor = cor;
            
            this.tab = tab;
            this.qteMovimentos = 0;
        }
        // public void incrementarQtdMovimentos()
        // {
        //    qteMovimentos++;
        // }
        public abstract bool[,] movimentosPossiveis();

    }
}
