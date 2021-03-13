using System;
using GameTop.Interface;
using GameTop.Lib;

namespace GameTop
{
    class Program
    {
        static void Main(string[] args)
        {
            var jogo = new Jogo(
                new Jogador1("Monique"),
                new Jogador2()
            );
            jogo.IniciarJogo();
        }        
    }
}
