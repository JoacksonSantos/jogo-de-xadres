using System.Security.Cryptography.X509Certificates;
using tabuleiro;
using xadres_console.Tabuleiro;
using xadres_console.xadres;

namespace xadres_console

{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                PartidaDeXadres partida = new PartidaDeXadres();
                while (!partida.terminada)
                {
                    Console.Clear();
                    Tela.imprimirTabuleiro(partida.tab);

                    Console.WriteLine();
                    Console.Write("Origem: ");
                    Posicao origem = Tela.lerPosicaoXadres().toPosica();

                    bool[,] posicoesPossiveis = partida.tab.peca(origem).movimentosPossiveis();
                    Console.Clear();

                    Tela.imprimirTabuleiro(partida.tab,posicoesPossiveis);
                    Console.Write("Destino:");
                    Posicao destino = Tela.lerPosicaoXadres().toPosica();

                    partida.executaMovimento(origem, destino);  
                }
         
              
            }
            catch(TabuleiroException e){
                Console.WriteLine(e.Message);
            }
            Console.ReadLine();
        }
    }
}