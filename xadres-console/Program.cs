using System.Security.Cryptography.X509Certificates;
using xadres_console.Tabuleiro;
using xadres;
using tabuleiro;

namespace xadres_console

{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                TabuleiroC tab = new TabuleiroC(8, 8);
                tab.colocarPeca(new Torre(tab, Cor.Preta), new Posicao(0, 0));
                tab.colocarPeca(new Torre(tab, Cor.Preta), new Posicao(1, 3));
                tab.colocarPeca(new Rei(tab, Cor.Preta), new Posicao(0, 2));

                tab.colocarPeca(new Torre(tab, Cor.Branca), new Posicao(3, 5));
                Tela.imprimirTabuleiro(tab);
              
            }
            catch(TabuleiroException e){
                Console.WriteLine(e.Message);
            }
            Console.ReadLine();
        }
    }
}