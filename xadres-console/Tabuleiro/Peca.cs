﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using xadres_console.xadres;
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
         public void incrementarQtdMovimentos()
         {
           qteMovimentos++;
         }
        public void decrementarQtdMovimentos()
        {
            qteMovimentos--;
        }


        public bool existeMovimentsPossiveis(){
            bool[,] mat = movimentosPossiveis();
            for( int i = 0; i< tab.linhas;  i++)
            {
                for( int j = 0; j<tab.colunas; j++)
                {
                    if (mat[i, j])
                    {
                        return true;
                    }
                   
                }
            }
            return false;
        }

        public bool MovimentoPossivel(Posicao pos)
        {
            return movimentosPossiveis()[pos.linha, pos.coluna];
        }
        public abstract bool[,] movimentosPossiveis();

    }
}
