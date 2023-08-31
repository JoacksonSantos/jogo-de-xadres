using System.Security.Cryptography.X509Certificates;
using xadres_console.Tabuleiro;

namespace xadres_console

{
    internal class Program
    {
        static void Main(string[] args)
        {
            Posicao P;
            P = new Posicao(3,4);

            Console.WriteLine("Posição: "+P);
        }
    }
}