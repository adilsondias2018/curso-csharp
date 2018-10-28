﻿using System;
using tabuleiro;
using xadrez;


namespace XadrezConsole
{
    class Program
    {
        static void Main(string[] args)
        {
       
            try
            {
                PartidaDeXadrez partida = new PartidaDeXadrez();
                

                while (!partida.terminada)
                {
                    Console.Clear();
                    Tela.imprimirTabuleiro(partida.tab);
                    Console.WriteLine("Origem: ");
                    Posicao origem = Tela.lerPosicaoXadrez().toPosicao();
                    Console.WriteLine("Destino: ");
                    Posicao destino = Tela.lerPosicaoXadrez().toPosicao();

                    partida.executaMovimento(origem, destino);


                }

             
            

            }catch(TabuleiroException e)
            {
                Console.WriteLine(e.Message);
               
            }

            Console.ReadLine();


        }
    }
}
