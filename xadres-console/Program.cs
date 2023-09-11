using System.Security.Cryptography.X509Certificates;
using xadres_console.Tabuleiro;
using xadres;
namespace xadres_console

{
    internal class Program
    {
        static void Main(string[] args)
        {
            TabuleiroC tab = new TabuleiroC(8,8);
            tab.colocarPeca(new Torre(tab, Cor.Preta), new Posicao(0, 0));
            tab.colocarPeca(new Torre(tab, Cor.Preta), new Posicao(1,3));
            tab.colocarPeca(new Rei(tab, Cor.Preta), new Posicao(2,4));
            Tela.imprimirTabuleiro(tab);
            Console.ReadLine();
        }
    }
}