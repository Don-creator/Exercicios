using System;
using EscolaDeRock.Models;

namespace EscolaDeRock {
    enum FormacaoEnum : int {
        TRIO = 3,
        QUARTETO
    }
    enum InstrumentoMusical : int {
        BAIXO,
        BATERIA,
        CONTRABAIXO,
        GUITARRA,
        TECLADO,
        TAMBORES,
        Violao
    }

    enum CategoriasEnum : int {
        HARMONIA,
        PERCURSSAO,
        MELODIA
    }
    class Program {
        static void Main (string[] args) {
            bool querSair = true;

            string[] itensMenuPrincipal = Enum.GetNames (typeof (FormacaoEnum));
            string[] itensMenuCategoria = Enum.GetNames (typeof (CategoriasEnum));

            var opçoesFormacao = new List<string> () {
                "     -0                         ",
                "     -1                     "
            };

            int opçoesFormacaoSelecionada = 0;
            string menuBar = "==============================";

            do {
                bool formacaoEscolhida = false;

                do {
                    #region Area do Menu
                    Console.WriteLine (menuBar);
                    Console.BackgroundColor = ConsoleColor.DarkCyan;
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.WriteLine ("      Seja bem-vinda@!    ");
                    Console.WriteLine ("     Escolha uma formação:      ");
                    Console.ResetColor ();
                    Console.WriteLine (menuBar);

                    for (int i = 0; i < opçoesFormacao.Count; i++) {
                        string Titulo = itensMenuPrincipal[i];
                        if (opcaoFormacaoSelecionada == i) {
                            Console.BackgroundColor = ConsoleColor.DarkRed;
                            Console.WriteLine (opçoesFormacao[opçoesFormacaoSelecionada].Replace ("-", ">").Replace (i.ToString (), Titulo));
                            Console.ResetColor;
                        } else {
                            Console.WriteLine (opçoesFormacao[i].Replace (i.ToString (), Titulo));
                        }
                    }
                    var key = Console.ReadKey (true).Key;
                    switch (key) {
                        case ConsoleKey.UpArrow:
                            opçoesFormacaoSelecionada = opçoesFormacaoSelecionada == 0 ? opçoesFormacaoSelecionada : --opçoesFormacaoSelecionada;
                            break;
                        case ConsoleKey.DownArrow:
                            opçoesFormacaoSelecionada = opçoesFormacaoSelecionada == opçoesFormacao.Count - 1 ? opçoesFormacaoSelecionada : ++opçoesFormacaoSelecionada;
                            break;
                        case ConsoleKey.Enter:
                        formacaoEscolhida = true;
                        break;        
                    }

                    #endregion

                } while (formacaoEscolhida);
            } while (!querSair);
        }
    }
}