using System;
using GameEngine;

namespace Tris
{
    class Program
    {
        static void Main(string[] args)
        {
            var nomeGiocatore1 = "Sergio";
            var nomeGiocatore2 = "Fabrizio";

            var giocatore1 = new Giocatore(nomeGiocatore1);
            var giocatore2 = new Giocatore(nomeGiocatore2);

            var ge = new GameRunner(giocatore1, giocatore2);

            ge.Run();

            Console.WriteLine("Premi invio per uscire...");
            Console.ReadLine();
        }
    }
}
