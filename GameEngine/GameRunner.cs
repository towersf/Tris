using GameEngine.Services;
using GameEngine.TavolaDaGioco;

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
            dsService.DisegnaScacchiera(_scacchiera);


        }
    }
}
