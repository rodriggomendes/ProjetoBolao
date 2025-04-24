using System;
using System.Collections.Generic;

namespace ProjetoBolao
{
    public class Jogador
    {
        private string _nome;
        public string Nome
        {
            get { return this._nome; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("O nome não pode ser vazio!");
                }
                this._nome = value;
            }
        }

        private int _pontos;
        public int Pontos
        {
            get { return this._pontos; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("A pontuação não pode ser negativa!");
                }
                this._pontos = value;
            }
        }
    }
}