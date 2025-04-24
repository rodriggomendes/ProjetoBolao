using System;
using System.Collections.Generic;

namespace ProjetoBolao
{
    public static class Inserir
    {
        public static void AdicionarJogador(List<Jogador> jogadores)
        {
            Console.Clear();
            Console.WriteLine("Insira o nome do jogador");
            string nome = Console.ReadLine();

            Console.WriteLine("Insira a pontuação inicial do jogador:");
            string entradaPontuação = Console.ReadLine();

            if (int.TryParse(entradaPontuação, out int pontos))
            {
                try
                {
                    jogadores.Add(new Jogador { Nome = nome, Pontos = pontos });
                    Console.WriteLine("Jogador adicionado com sucesso!");
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                    Console.WriteLine("Retornando ao menu principal...");
                    Limpar.LimparTela();
                    return;
                }
            }
            else
            {
                Console.WriteLine("Pontuação inválida, refaça o cadastro!");
            }

            Limpar.LimparTela();
        }
    }
}