﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using xadres_console.Tabuleiro;
using xadres_console.xadres;


namespace xadres_console
{
    internal class Tela
    {
        
        public static void imprimirTabuleiro(TabuleiroC tab)
        {
            for(int i =0; i< tab.linhas; i++)
            {
                Console.Write(8- i + " ");
                for (int j = 0; j< tab.colunas; j++)
                {
                        Tela.imprimirPeca(tab.peca(i, j)); 
                }
                Console.WriteLine();
            }
            Console.WriteLine("  a b c d e f g h ");
            
        }

        public static void imprimirTabuleiro(TabuleiroC tab, bool[,] posicoesPossiveis)
        {

            ConsoleColor fundoOriginal = Console.BackgroundColor;
            ConsoleColor fundoAlterado = ConsoleColor.DarkGray;
            for (int i = 0; i < tab.linhas; i++)
            {
                Console.Write(8 - i + " ");
                for (int j = 0; j < tab.colunas; j++)
                {
                    if (posicoesPossiveis[i,j])
                    {
                        Console.BackgroundColor = fundoAlterado;
                    }
                    else
                    {
                        Console.BackgroundColor = fundoOriginal;
                    }
                    imprimirPeca(tab.peca(i, j));
                    Console.BackgroundColor = fundoOriginal;
                }
                Console.WriteLine();
            }
            Console.WriteLine("  a b c d e f g h ");
            Console.BackgroundColor = fundoOriginal;
        }

        public static void imprimirPeca(Peca peca)
        {

            if (peca == null)
            {
                Console.Write("- ");
            }
            else
            {

                if (peca.cor == Cor.Branca)
                {
                    Console.Write(peca);
                }
                else
                {
                    ConsoleColor aux = Console.ForegroundColor;
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write(peca);
                    Console.ForegroundColor = aux;
                }
                Console.Write(" ");
            }
        }
        public static PosicaoXadres lerPosicaoXadres()
        {
            string s = Console.ReadLine();
            char coluna = s[0];
            int linha = int.Parse(s[1]+"");
            return new PosicaoXadres(coluna, linha);
        }
        
         
        
    }
}
