using System;
using System.Collections.Generic;

namespace ProjetoBolao
{
    public static class Ordenar
    {
        public static void OrdenarJogadores(List<Jogador> jogadores)
        {
            Console.Clear();
            jogadores.Sort((j1, j2) => j2.Pontos.CompareTo(j1.Pontos));

            Console.WriteLine("Jogadores ordenados por pontuação!");

            Limpar.LimparTela();
        }
    }
}