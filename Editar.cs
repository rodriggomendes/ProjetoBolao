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

            if (jogadorEncontrado.Equals(default(Jogador)))
            {
                Console.WriteLine("Jogador não encontrado!");
                Limpar.LimparTela();
                return;
            }

            Console.WriteLine("Informe o número de pontos que deseja adicionar ao jogador: ");
            string adicionarPontos = Console.ReadLine();

            if (int.TryParse(adicionarPontos, out int Pontos))
            {
                int indice = jogadores.FindIndex(jogador => jogador.Nome.Equals(nomeEditar, StringComparison.OrdinalIgnoreCase));

                if (indice != -1)
                {
                    jogadores[indice] = new Jogador { Nome = jogadorEncontrado.Nome, Pontos = jogadorEncontrado.Pontos + Pontos };
                    Console.WriteLine("Pontuação atualizada com sucesso!");
                    Limpar.LimparTela();
                }
            }
            else
            {
                Console.WriteLine("Pontuação inválida! \nA pontuação deve ser um número inteiro.");
                Limpar.LimparTela();
            }
        }
    }
}