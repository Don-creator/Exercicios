using System;
using MateODragao.Models;

namespace MateODragao
{
    class Program
    {
        static void Main(string[] args)
        {
            bool JogadorNaoDesistiu = true;
            do
            {

                Console.Clear();
                System.Console.WriteLine("==============================");
                System.Console.WriteLine("        Mate o Dragão!");
                System.Console.WriteLine("==============================");

                System.Console.WriteLine(" 1 - Iniciar jogo");
                System.Console.WriteLine(" 0 - Sair do jogo");

                string opcaoJogador = Console.ReadLine();

                switch (opcaoJogador)
                {
                    case "1":
                        Console.Clear();
                        Guerreiro guerreiro = new Guerreiro();
                        guerreiro.Nome = "SagraDon";
                        guerreiro.Sobrenome = "Divinum";
                        guerreiro.CidadeNatal = "Escandinavia";
                        guerreiro.DataNascimento = DateTime.Parse("16/07/1856");
                        guerreiro.FerramentaAtaque = "Escalibur";
                        guerreiro.FerramentaProteção = "Escudo de Carlos Magno";
                        guerreiro.Forca = 2;
                        guerreiro.Destreza = 3;
                        guerreiro.Inteligencia = 3;
                        guerreiro.Vida = 20;

                        Dragao dragao = new Dragao();
                        dragao.Nome = "Saphira";
                        dragao.Forca = 5;
                        dragao.Destreza = 1;
                        dragao.Inteligencia = 3;
                        dragao = 300;

                        /* INICIO - PRIMEIRO DIÁLOGO */
                        System.Console.WriteLine($"{guerreiro.Nome.ToUpper()}: {dragao.Nome}, seu louco! Vim-lhe derrotar-lhe!");
                        System.Console.WriteLine($"{dragao.Nome.ToUpper()}: {guerreiro.Nome}, Humano tolo. Quem pensas que és?");

                        System.Console.WriteLine();
                        System.Console.WriteLine("Aperte ENTER para prosseguir");
                        Console.ReadLine();

                        /* FIM - PRIMEIRO DIÁLOGO */

                        /* INICIO - SEGUNDO DIÁLOGO */
                        System.Console.WriteLine($"{guerreiro.Nome.ToUpper()}: Eu sou {guerreiro.Nome}! Da casa {guerreiro.Sobrenome}, Ó criatura DEMONIACA");
                        System.Console.WriteLine($"{guerreiro.Nome.ToUpper()} Vim de {guerreiro.CidadeNatal} para derrotar-lhe e mostrar meu valor!":);
                        System.Console.WriteLine($"{dragao.Nome.ToUpper()}: QUEM? DE ONDE? Bom que sejas... fritar-te-ei e devorar-te-ei, humano insolente!");

                        System.Console.WriteLine("ODIN: Está na hora do seu derradeiro suspiro!");

                        System.Console.WriteLine();
                        System.Console.WriteLine("Aperte ENTER para prosseguir");
                        Console.ReadLine();
                        /* FIM - SEGUNDO DIÁLOGO */


                        Console.Clear();

                        bool JogadorAtacaPrimeiro = guerreiro.Destreza > dragao.Destreza ? true : false;


                        int poderAtaqueGuerreiro = guerreiro.Forca > guerreiro.Inteligencia ? guerreiro.Forca + guerreiro.Destreza : guerreiro.Inteligencia + guerreiro.Destreza;
                        bool JogadorNaoCorreu = true;

                        if (JogadorAtacaPrimeiro)
                        {
                            System.Console.WriteLine("*** Turno do Jogador ***");
                            System.Console.WriteLine("Escolha uma ação: ");
                            System.Console.WriteLine(" 1 - Atacar");
                            System.Console.WriteLine(" 2 - Fugir");

                            string opcaoBatalhaJogador = Console.ReadLine();

                            switch (opcaoBatalhaJogador)
                            {
                                case "1":
                                    Random geradorNumeroAleatorio = new Random();
                                    int numeroAleatorioJogador = geradorNumeroAleatorio.Next(0, 5);
                                    int numeroAleatorioDragao = geradorNumeroAleatorio.Next(0, 5);
                                    int guerreiroDestrezaTotal = guerreiro.Destreza + numeroAleatorioJogador;
                                    int dragaoDestrezaTotal = dragao.Destreza + numeroAleatorioDragao;

                                    if (guerreiroDestrezaTotal > dragaoDestrezaTotal)
                                    {
                                        System.Console.WriteLine($"{guerreiro.Nome.ToUpper()}: Toma essa, lagarto Malditoooo! HUUUUU");
                                        dragao.Vida = dragao.Vida - (poderAtaqueGuerreiro + 5);
                                        System.Console.WriteLine($"HP Dragão: {dragao.Vida}");
                                        System.Console.WriteLine($"HP Guerreiro: {guerreiro.Vida}");

                                    }
                                    else
                                    {
                                        System.Console.WriteLine($"{dragao.Nome.ToUpper()}: Isso foi um erro, humano tosco!");
                                    }


                                    break;
                                case "2":
                                    System.Console.WriteLine($"{guerreiro.Nome.ToUpper()}: Tchau");
                                    System.Console.WriteLine($"{dragao.Nome.ToUpper()}: Facil!");
                                    JogadorNaoCorreu = false;
                                    break;
                            }
                        }

                        System.Console.WriteLine();
                        System.Console.WriteLine("aperte ENTER para prosseguir");
                        Console.ReadLine();


                        while (guerreiro.Vida > 0 && dragao.Vida > 0 && JogadorNaoCorreu)
                        {
                            Console.Clear();
                            System.Console.WriteLine("*** Turno Dragão ***");
                            Random geradorNumeroAleatorio = new Random();
                            int numeroAleatorioJogador = geradorNumeroAleatorio.Next(0, 5);
                            int numeroAleatorioDragao = geradorNumeroAleatorio.Next(0, 5);
                            int guerreiroDestrezaTotal = guerreiro.Destreza + numeroAleatorioJogador;
                            int dragaoDestrezaTotal = dragao.Destreza + numeroAleatorioDragao;

                            if (dragaoDestrezaTotal < guerreiroDestrezaTotal)
                            {
                                System.Console.WriteLine($"{guerreiro.Nome.ToUpper()}: se Queimou, foi?");
                                guerreiro.Vida -= dragao.Forca;
                                System.Console.WriteLine($"HP Dragão: {dragao.Vida}");
                                System.Console.WriteLine($"HP Guerreiro: {guerreiro.Vida}");

                            }
                            else
                            {
                                System.Console.WriteLine($"{guerreiro.Nome.ToUpper()}: Isso foi um erro, Desgraçado!");
                            }
                            System.Console.WriteLine();
                            System.Console.WriteLine("aperte ENTER para prosseguir");
                            Console.ReadLine();

                            Console.Clear();

                            System.Console.WriteLine("*** Turno do Jogador ***");
                            System.Console.WriteLine("Escolha uma ação: ");
                            System.Console.WriteLine(" 1 - Atacar");
                            System.Console.WriteLine(" 2 - Fugir");

                            string opcaoBatalhaJogador = Console.ReadLine();

                            switch (opcaoBatalhaJogador) {
                           
                                case "1":
                                    geradorNumeroAleatorio = new Random();
                                    numeroAleatorioJogador = geradorNumeroAleatorio.Next(0, 5);
                                    numeroAleatorioDragao = geradorNumeroAleatorio.Next(0, 5);
                                    guerreiroDestrezaTotal = guerreiro.Destreza + numeroAleatorioJogador;
                                    dragaoDestrezaTotal = dragao.Destreza + numeroAleatorioDragao;

                                    if (guerreiroDestrezaTotal > dragaoDestrezaTotal)
                                    {
                                        System.Console.WriteLine($"{guerreiro.Nome.ToUpper()}: Toma essa, lagarto Malditoooo! HUUUUU");
                                        dragao.Vida = dragao.Vida - (poderAtaqueGuerreiro + 5);
                                        System.Console.WriteLine($"HP Dragão: {dragao.Vida}");
                                        System.Console.WriteLine($"HP Guerreiro: {guerreiro.Vida}");

                                    }
                                    else
                                    {
                                        System.Console.WriteLine($"{dragao.Nome.ToUpper()}: Isso foi um erro, humano tosco!");
                                    }


                                    break;
                                case "2":
                                    System.Console.WriteLine($"{guerreiro.Nome.ToUpper()}: Tchau");
                                    System.Console.WriteLine($"{dragao.Nome.ToUpper()}: Facil!");
                                    JogadorNaoCorreu = false;
                                    break;
                            }



                        }

                    case "0":
                        JogadorNaoDesistiu = false;
                        System.Console.WriteLine("GAME OVER");
                        break;
                    default:
                        System.Console.WriteLine("Comando inválido");
                        break;
                }
            } while (JogadorNaoDesistiu);
        }
    }
}
