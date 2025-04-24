using System;
using System.Collections.Generic;

namespace ProjetoBolao
{
    public static class Limpar
    {
        public static void LimparTela()
        {
            Console.WriteLine("Pressione qualquer tecla para voltar ao Menu Inicial");
            Console.ReadKey();
        }
    }
}