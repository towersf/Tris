using System;
using GameEngine.TavolaDaGioco;

namespace GameEngine.Services
{
    public class DisegnatoreScacchieraService
    {

        public void DisegnaScacchiera(Scacchiera scacchiera)
        {
            Console.Clear();

            for (var i = 0; i <= 4; i++)
            {
                Console.WriteLine($"{scacchiera.GetSimboloCella(1).Righe[i]}|{scacchiera.GetSimboloCella(2).Righe[i]}|{scacchiera.GetSimboloCella(3).Righe[i]}");
            }

            Console.WriteLine($"-----------------------");

            for (var i = 0; i <= 4; i++)
            {
                Console.WriteLine($"{scacchiera.GetSimboloCella(4).Righe[i]}|{scacchiera.GetSimboloCella(5).Righe[i]}|{scacchiera.GetSimboloCella(6).Righe[i]}");
            }
            
            Console.WriteLine($"-----------------------");
            
            for (var i = 0; i <= 4; i++)
            {
                Console.WriteLine($"{scacchiera.GetSimboloCella(7).Righe[i]}|{scacchiera.GetSimboloCella(8).Righe[i]}|{scacchiera.GetSimboloCella(9).Righe[i]}");
            }
        }
    }
}