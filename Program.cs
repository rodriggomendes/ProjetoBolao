using System;
using System.Collections.Generic;
using System.Net;

namespace ProjetoBolao
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Jogador> jogadores = new List<Jogador>();

            while (true)
            {
                Console.Clear();
                Console.WriteLine("Escolha uma opção:");
                Console.WriteLine("1 - Adicionar jogador à tabela");
                Console.WriteLine("2 - Ordenar pontuação da tabela");
                Console.WriteLine("3 - Editar pontuação da tabela");
                Console.WriteLine("4 - Excluir um jogador da tabela");
                Console.WriteLine("5 - Listar a tabela");
                Console.WriteLine("0 - Sair");

                string entrada = Console.ReadLine();

                if (!int.TryParse(entrada, out int opcao))
                {
                    Console.WriteLine("Opção inválida!");
                    continue;
                }

                switch (opcao)
                {
                    case 1: Inserir.AdicionarJogador(jogadores); break;
                    case 2: Ordenar.OrdenarJogadores(jogadores); break;
                    case 3: Editar.EditarPontuacao(jogadores); break;
                    case 4: Deletar.DeletarJogador(jogadores); break;
                    case 5: Listar.ListarJogadores(jogadores); break;
                    case 0:
                        {
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Opção inválida! Escolha um número válido.");
                            Limpar.LimparTela(); break;
                        }
                }

                if (opcao == 0)
                {
                    Console.Clear();
                    Console.WriteLine("Tem certeza que deseja sair?");
                    string opcao2 = Console.ReadLine();
                    if (string.Equals(opcao2, "Sim", StringComparison.OrdinalIgnoreCase))
                    {
                        Console.WriteLine("Saindo do programa...");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Retornando ao menu principal...");
                        Limpar.LimparTela();
                    }
                }
            }
        }
    }
}