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
                    try
                    {
                        Console.Clear();
                        Tela.imprimirPartida(partida);
                        
                      

                        Console.WriteLine();
                        Console.Write("Origem: ");
                        Posicao origem = Tela.lerPosicaoXadres().toPosica();
                        partida.validaPosicaoDeOrigem(origem);


                        bool[,] posicoesPossiveis = partida.tab.peca(origem).movimentosPossiveis();
                        Console.Clear();

                        Tela.imprimirTabuleiro(partida.tab, posicoesPossiveis);
                        Console.Write("Destino:");
                        Posicao destino = Tela.lerPosicaoXadres().toPosica();
                        partida.validarPosicaoDeDestino(origem, destino);

                        partida.realizaJogada(origem, destino);

                    }
                    catch(TabuleiroException e) { 
                            Console.WriteLine(e.Message);
                        Console.ReadLine();
                    
                    }
                }
         
              
            }
            catch(TabuleiroException e){
                Console.WriteLine(e.Message);
            }
            Console.ReadLine();
        }
    }
}