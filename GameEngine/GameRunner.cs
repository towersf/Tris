using System;
using GameEngine.Services;
using GameEngine.TavolaDaGioco;

namespace GameEngine
{
    public class GameRunner
    {
        private readonly Scacchiera _scacchiera;
        private readonly TogleGiocatori _giocatori;

        public GameRunner(Giocatore giocatore1, Giocatore giocatore2)
        {
            _scacchiera = new Scacchiera();
            _giocatori = new TogleGiocatori(giocatore1, giocatore2);
        }

        public Giocatore Vincitore
        {
            get
            {
                return _scacchiera.PartitaConclusa ? _giocatori.GiocatoreCorrente : null;
            }
        }

        public void Run()
        {
            var dsService = new DisegnatoreScacchieraService();
            dsService.DisegnaScacchiera(_scacchiera);

            var nessunVincitorePossibile = false;

            while (!_scacchiera.PartitaConclusa && !nessunVincitorePossibile)
            {
                _giocatori.CambiaTurno();

                nessunVincitorePossibile = _eseguiMossa();

                dsService.DisegnaScacchiera(_scacchiera);
            }
        }

        private bool _eseguiMossa()
        {
            var nessunVincitorePossibile = false;
            var sceltaValida = false;

            while (!sceltaValida)
            {
                var casellaScelata = _chiediCasella(_giocatori.GiocatoreCorrente);

                try
                {
                    _scacchiera.ImpostaCasella(casellaScelata, _giocatori.GiocatoreCorrente.Simbolo);
                    sceltaValida = true;
                }
                catch (NessunVincitoreException err)
                {
                    sceltaValida = true;
                    nessunVincitorePossibile = true;
                    Console.WriteLine(err.Message);
                }
                catch (Exception err)
                {
                    Console.WriteLine(err.Message);
                }
            }

            return nessunVincitorePossibile;
        }

        private int _chiediCasella(Giocatore giocatore)
        {
            var sceltaValida = false;
            var sceltaFatta = 0;

            while (!sceltaValida)
            {
                Console.WriteLine($"Fai la tua mossa {giocatore.Nome};");
                var scelta = Console.ReadLine();

                if (!string.IsNullOrWhiteSpace(scelta) && scelta.Length == 1)
                {
                    if (int.TryParse(scelta, out sceltaFatta))
                    {
                        sceltaValida = true;
                    }
                }

                if (!sceltaValida)
                {
                    Console.WriteLine($"Scelta non valida. Valori ammessi da 1 a 9.");
                }
            }

            return sceltaFatta;
        }
    }
}
