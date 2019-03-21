using System;
using GameEngine;
using GameEngine.Simboli;

namespace Tris
{
    class Program
    {
        static void Main(string[] args)
        {
            var nomeGiocatore1 = "Sergio";
            var nomeGiocatore2 = "Fabrizio";

            var simboloX = new SimboloX();
            var simboloO = new SimboloO();

            var giocatore1 = new Giocatore(nomeGiocatore1, simboloX);
            var giocatore2 = new Giocatore(nomeGiocatore2, simboloO);

            var ge = new GameRunner(giocatore1, giocatore2);

            ge.Run();

            Console.WriteLine("Premi invio per uscire...");
            Console.ReadLine();
        }
    }
}
