namespace GameEngine
{
    internal class TogleGiocatori
    {
        private Giocatore _giocatore1;
        private Giocatore _giocatore2;

        public Giocatore GiocatoreCorrente { get; private set; }

        public TogleGiocatori(Giocatore giocatore1, Giocatore giocatore2)
        {
            _giocatore1 = giocatore1;
            _giocatore2 = giocatore2;

            GiocatoreCorrente = _giocatore2;
        }

        public void CambiaTurno()
        {
            GiocatoreCorrente = GiocatoreCorrente == _giocatore1 ? _giocatore2 : _giocatore1;
        }
    }
}