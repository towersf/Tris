using GameEngine.Services;
using GameEngine.Simboli;
using GameEngine.TavolaDaGioco;
using System;

namespace GameEngine
{
    public class GameRunner
    {
        private Scacchiera _scacchiera;
        private Giocatore _giocatore1;
        private Giocatore _giocatore2;
        
        public GameRunner(Giocatore giocatore1, Giocatore giocatore2)
        {
            _scacchiera = new Scacchiera();
            _giocatore1 = giocatore1;
            _giocatore2 = giocatore2;
        }

        public void Run()
        {
            var dsService = new DisegnatoreScacchieraService();
            var arbitro = new Arbitro(_giocatore1, _giocatore2);
            dsService.DisegnaScacchiera(_scacchiera);

            IGiocatore vincitore = null;
            
            while (vincitore == null)
            {
                _eseguiMossa(_giocatore1);
                dsService.DisegnaScacchiera(_scacchiera);
                vincitore = arbitro.ControllaVincitore(_scacchiera);

                if (vincitore != null)
                {                    
                    break;
                }                

                _eseguiMossa(_giocatore2);
                dsService.DisegnaScacchiera(_scacchiera);
                vincitore = arbitro.ControllaVincitore(_scacchiera);
            }

            Console.WriteLine($"Il vincitore è {vincitore.Nome}");

        }

        private void _eseguiMossa(IGiocatore giocatore)
        {
            var rispostaValida = false;
            while (!rispostaValida)
            {
                Console.WriteLine($"{giocatore.Nome} fai la tua mossa");
                var scelta = Console.ReadLine();
                try
                {
                    _scacchiera.ImpostaSimbolo(Convert.ToInt32(scelta), giocatore.Simbolo);
                    rispostaValida = true;
                }
                catch (Exception err)
                {
                    Console.WriteLine("Mossa non valida");
                }
            }
            
                
        }
    }
}
