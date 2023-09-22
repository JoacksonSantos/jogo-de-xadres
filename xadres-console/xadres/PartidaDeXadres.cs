using System;
using xadres;
using xadres_console.Tabuleiro;
using tabuleiro;
namespace xadres_console.xadres
{
    public class PartidaDeXadres
    {
        public TabuleiroC tab { get; private set; }
        private int turno;
        private Cor jogadorAtual;
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
