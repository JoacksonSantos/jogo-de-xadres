using System.Security.Cryptography.X509Certificates;
using xadres_console.Tabuleiro;
using xadres;
using tabuleiro;
using xadres_console.xadres;

namespace xadres_console

{
    internal class Program
    {
        static void Main(string[] args)
        {
            PosicaoXadres pos = new PosicaoXadres('c', 7);
            Console.WriteLine(pos);
            Console.WriteLine(pos.toPosica());
            Console.ReadLine();
        }
    }
}