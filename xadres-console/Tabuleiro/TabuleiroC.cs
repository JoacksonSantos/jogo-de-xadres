﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tabuleiro;

namespace xadres_console.Tabuleiro
{
    internal class TabuleiroC
    {
        public int linhas { get; set; }
        public int colunas { get; set; }
        private Peca[,] pecas;

        public TabuleiroC(int linhas, int colunas)
        {
            this.linhas = linhas;
            this.colunas = colunas;
            pecas = new Peca[linhas, colunas];
        }

        public Peca peca(int linhas, int coluna)
        {
            return pecas[linhas, coluna];
        }

        public Peca peca(Posicao pos)
        {
            return pecas[pos.linha, pos.coluna];
        }

        public void colocarPeca(Peca p, Posicao pos)
        {
            if(existePeca(pos))
            {
                throw new TabuleiroException("já existe uma peça nessa posição");
                
            }
            pecas[pos.linha, pos.coluna] =p;
            p.posicao = pos;
        }

        public bool posicaoValida(Posicao pos)
        {
            if(pos.linha < 0 || pos.linha>= linhas || pos.coluna <0 || pos.coluna >= colunas)
            {
                return false;
            }
            return true;
        }


        public bool existePeca(Posicao pos)
        {   

            validarPosicao(pos);
            return peca(pos) != null;
        }
        public void validarPosicao(Posicao pos)
        {
            if(!posicaoValida(pos))
            {
                throw new TabuleiroException("Posição invalida");
            }
        }
    }
}
