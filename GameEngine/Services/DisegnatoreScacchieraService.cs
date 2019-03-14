using System;
using GameEngine.TavolaDaGioco;

namespace GameEngine.Services
{
    public class DisegnatoreScacchieraService
    {

        public void DisegnaScacchiera(Scacchiera scacchiera)
        {
            for (int i = 0; i <= 4; i++)
            {
                Console.WriteLine($"{scacchiera.Cella(1).Righe[i]}|{scacchiera.Cella(2).Righe[i]}|{scacchiera.Cella(3).Righe[i]}");
            }

            Console.WriteLine($"-----------------------");

            for (int i = 0; i <= 4; i++)
            {
                Console.WriteLine($"{scacchiera.Cella(4).Righe[i]}|{scacchiera.Cella(5).Righe[i]}|{scacchiera.Cella(6).Righe[i]}");
            }


            Console.WriteLine($"-----------------------");


            for (int i = 0; i <= 4; i++)
            {
                Console.WriteLine($"{scacchiera.Cella(7).Righe[i]}|{scacchiera.Cella(8).Righe[i]}|{scacchiera.Cella(9).Righe[i]}");
            }

        }
    }
}