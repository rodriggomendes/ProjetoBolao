using System;
using System.Collections.Generic;

namespace ProjetoBolao
{
    public static class Listar
    {
        public static void ListarJogadores(List<Jogador> jogadores)
        {
            Console.Clear();

            Console.WriteLine("Lista atualizada do Bolão 2025: ");
            if (jogadores == null || jogadores.Count == 0)
            {
                Console.WriteLine("Não há nenhum jogador cadastrado!");
                Limpar.LimparTela();
                return;
            }

            try
            {
                foreach (var jogador in jogadores)
                {
                    Console.WriteLine($"{jogador.Nome}: {jogador.Pontos} pontos");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao listar jogadores: {ex.Message}");
                Limpar.LimparTela();
                return;
            }
            Limpar.LimparTela();
        }
    }
}