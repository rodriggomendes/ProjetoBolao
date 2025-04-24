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
            if (jogadores.Count == 0)
            {
                Console.WriteLine("Não há nenhum jogador cadastrado!");
            }
            else
            {
                foreach (var jogador in jogadores)
                {
                    Console.WriteLine($"{jogador.Nome}: {jogador.Pontos} pontos");
                }
            }
            Limpar.LimparTela();
        }
    }
}