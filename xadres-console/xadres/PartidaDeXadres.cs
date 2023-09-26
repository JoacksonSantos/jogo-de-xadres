using System;
using xadres;
using xadres_console.Tabuleiro;
using tabuleiro;
using System.Data;

namespace xadres_console.xadres
{
    public class PartidaDeXadres
    {
        public TabuleiroC tab { get; private set; }
        public int turno { get; private set; }
        public Cor jogadorAtual { get; private set; }
        public bool terminada { get; private set; }

        public PartidaDeXadres()
        {
           tab = new TabuleiroC(8,8);
            turno = 1;
            jogadorAtual = Cor.Branca;
            terminada = false;
            colocarPecas();
            
        }
       

        public void executaMovimento(Posicao origem, Posicao destino)
        {
            Peca p = tab.RetirarPeca(origem);
           // p.incrementarQtdMovimentos();
            Peca pecaCapturada = tab.RetirarPeca(destino);
            tab.colocarPeca(p, destino);
        }
        public void realizaJogada(Posicao origem,Posicao destino)
        {
            executaMovimento(origem,destino);
            turno++;
            mudaJogador();
        }
        public void validaPosicaoDeOrigem(Posicao pos)
        {
            if(tab.peca(pos) == null)
            {
                throw new TabuleiroException("Não existe peça na posição de origem escolhida");
            }
            if(jogadorAtual != tab.peca(pos).cor)
            {
                throw new TabuleiroException("A peca de origem escolhida não é sua!");
            }
            if (!tab.peca(pos).existeMovimentsPossiveis())
            {
                throw new TabuleiroException("Não há movimentos possiveis para a peca de origem escolhida");
            }
            {

            }
        } 

        public void validarPosicaoDeDestino(Posicao origem, Posicao destino)
        {
            if (!tab.peca(origem).podeMoverPara(destino))
            {
                throw new TabuleiroException("Posição de destino invalida");
            }
        }
        private void mudaJogador()
        {
            if(jogadorAtual == Cor.Branca)
            {
                jogadorAtual = Cor.Preta;
            }
            else
            {
                jogadorAtual= Cor.Branca;
            }
        }

        private void colocarPecas()
        {
            tab.colocarPeca(new Torre(tab, Cor.Branca), new PosicaoXadres('c',1).toPosica());
            tab.colocarPeca(new Torre(tab, Cor.Branca), new PosicaoXadres('c', 2).toPosica());
            tab.colocarPeca(new Torre(tab, Cor.Branca), new PosicaoXadres('d', 2).toPosica());
            tab.colocarPeca(new Torre(tab, Cor.Branca), new PosicaoXadres('e', 2).toPosica());
            tab.colocarPeca(new Torre(tab, Cor.Branca), new PosicaoXadres('e', 1).toPosica());
            tab.colocarPeca(new Rei(tab, Cor.Branca), new PosicaoXadres('d', 1).toPosica());


            tab.colocarPeca(new Torre(tab, Cor.Preta), new PosicaoXadres('c', 7).toPosica());
            tab.colocarPeca(new Torre(tab, Cor.Preta), new PosicaoXadres('c', 8).toPosica());
            tab.colocarPeca(new Torre(tab, Cor.Preta), new PosicaoXadres('d', 7).toPosica());
            tab.colocarPeca(new Torre(tab, Cor.Preta), new PosicaoXadres('e', 7).toPosica());
            tab.colocarPeca(new Torre(tab, Cor.Preta), new PosicaoXadres('e', 8).toPosica());
            tab.colocarPeca(new Rei(tab, Cor.Preta), new PosicaoXadres('d', 8).toPosica());
        }


    }
    
}
