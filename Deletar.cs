using System;
using System.Collections.Generic;

namespace ProjetoBolao
{
    public static class Deletar
    {
        public static void DeletarJogador(List<Jogador> jogadores)
        {
            Console.Clear();
            if (jogadores == null || jogadores.Count == 0)
            {
                Console.WriteLine("A lista está vazia!");
                Limpar.LimparTela();
                return;
            }

            Console.WriteLine("Informe o nome do jogador a ser deletado:");
            string nomeExcluir = Console.ReadLine();

            var jogadorEncontrado = jogadores.FindIndex(jogador => jogador.Nome.Equals(nomeExcluir, StringComparison.OrdinalIgnoreCase));

            if (jogadorEncontrado == -1)
            {
                Console.WriteLine("Jogador não encontrado!");
                Limpar.LimparTela();
                return;
            }

            Console.WriteLine($"Você realmente deseja remover o jogador {nomeExcluir}?");
            string opcao = Console.ReadLine();

            while (!string.Equals(opcao, "Sim", StringComparison.OrdinalIgnoreCase) && !string.Equals(opcao, "Não", StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("Por favor, responda com sim ou não!");
                opcao = Console.ReadLine();
            }

            try
            {
                if (string.Equals(opcao, "Sim", StringComparison.OrdinalIgnoreCase))
                {
                    jogadores.RemoveAt(jogadorEncontrado);
                    Console.WriteLine("Jogador removido com sucesso!");
                }
                else
                {
                    Console.WriteLine("Operação cancelada!");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao remover jogador: {ex.Message}");
                return;
            }
            Limpar.LimparTela();
        }
    }
}