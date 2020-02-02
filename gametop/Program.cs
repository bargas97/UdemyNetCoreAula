using System;
using GameTOP.Lib;

namespace gametop
{
    class Program
    {
        static void Main(string[] args)
        {
            var jogo = new JogoFODA(new Jogador1("Gabriel"),new Jogador3());
            jogo.IniciarJoogo();
        }
    }
}
