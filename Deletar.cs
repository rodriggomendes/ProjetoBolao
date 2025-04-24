using System;
using System.Collections.Generic;

namespace ProjetoBolao
{
    public static class Deletar
    {
        public static void DeletarJogador(List<Jogador> jogadores)
        {
            Console.Clear();
            Console.WriteLine("Informe o nome do jogador a ser deletado:");
            string nomeExcluir = Console.ReadLine();

            var jogadorEncontrado = jogadores.Find(jogador => jogador.Nome.Equals(nomeExcluir, StringComparison.OrdinalIgnoreCase));

            if (jogadorEncontrado.Equals(default(Jogador)))
            {
                Console.WriteLine("Jogador não encontrado!");
                Limpar.LimparTela();
                return;
            }

            Console.WriteLine($"Você realmente deseja remover o jogador {nomeExcluir}?");
            string opcao = Console.ReadLine();
            if (string.Equals(opcao, "Sim", StringComparison.OrdinalIgnoreCase))
            {
                int indice = jogadores.FindIndex(jogador => jogador.Nome.Equals(nomeExcluir, StringComparison.OrdinalIgnoreCase));

                if (indice != -1)
                {
                    jogadores.RemoveAt(indice);
                    Console.WriteLine("Jogador removido com sucesso!");
                    Limpar.LimparTela();
                }
            }
            else
            {
                Console.WriteLine("Operação cancelada!");
                Limpar.LimparTela();
            }
        }
    }
}