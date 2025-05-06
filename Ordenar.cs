using System;
using System.Collections.Generic;

namespace ProjetoBolao
{
    public static class Ordenar
    {
        public static void OrdenarJogadores(List<Jogador> jogadores)
        {
            Console.Clear();
            if (jogadores == null || jogadores.Count == 0)
            {
                Console.WriteLine("A lista está vazia!");
                Limpar.LimparTela();
                return;
            }

            try
            {
                jogadores.Sort((j1, j2) => j2.Pontos.CompareTo(j1.Pontos));
                Console.WriteLine("Jogadores ordenados por pontuação!");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Erro ao ordenar jogadores: {ex.Message}");
                Limpar.LimparTela();
                return;
            }

            Limpar.LimparTela();
        }
    }
}