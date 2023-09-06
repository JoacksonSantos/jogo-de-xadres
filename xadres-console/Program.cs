using System.Security.Cryptography.X509Certificates;
using xadres_console.Tabuleiro;

namespace xadres_console

{
    internal class Program
    {
        static void Main(string[] args)
        {
            TabuleiroC tab = new TabuleiroC(8,8);
            Tela.imprimirTabuleiro(tab);
            Console.ReadLine();
        }
    }
}