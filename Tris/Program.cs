using System;
using GameEngine;
using GameEngine.Simboli;

namespace Tris
{
    class Program
    {
        static void Main(string[] args)
        {
            var giocatore1 = new Giocatore("Sergio", new SimoboloX());
            var giocatore2 = new Giocatore("Fabrizio", new SimoboloO());

            var ge = new GameRunner(giocatore1, giocatore2);

            ge.Run();

            _showEsito(ge);
            _byebye();
        }

        private static void _byebye()
        {
            Console.WriteLine("Premi invio per uscire...");
            Console.ReadLine();
        }

        private static void _showEsito(GameRunner ge)
        {
            var message = ge.Vincitore != null
                            ? $"{ge.Vincitore.Nome} hai vinto !!!"
                            : "Nessun vincitore.";

            Console.WriteLine();
            Console.WriteLine(message);
            Console.WriteLine();
        }
    }
}
