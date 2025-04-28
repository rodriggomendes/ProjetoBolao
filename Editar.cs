using System;
using System.Collections.Generic;

namespace ProjetoBolao
{
    public static class Editar
    {
        public static void EditarPontuacao(List<Jogador> jogadores)
        {
            Console.Clear();
            Console.WriteLine("Informe o nome do jogador para editarmos a pontuação:");
            string nomeEditar = Console.ReadLine();

            var jogadorEncontrado = jogadores.Find(jogador => jogador.Nome.Equals(nomeEditar, StringComparison.OrdinalIgnoreCase));

            if (jogadorEncontrado == null)
            {
                Console.WriteLine("Jogador não encontrado!");
                Limpar.LimparTela();
                return;
            }

            Console.WriteLine("Informe o número de pontos que deseja adicionar ao jogador: ");
            string adicionarPontos = Console.ReadLine();

            if (int.TryParse(adicionarPontos, out int pontos))
            {
                try
                {
                    jogadorEncontrado.Pontos += pontos;
                    Console.WriteLine("Pontuação atualizada!");
                    Limpar.LimparTela();
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                    Console.WriteLine("Retornando ao menu principal...");
                    Limpar.LimparTela();
                }
            }
            else
            {
                Console.WriteLine("Pontuação inválida! O número deve ser inteiro.");
                Limpar.LimparTela();
            }
        }
    }
}