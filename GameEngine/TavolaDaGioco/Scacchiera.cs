using System.Collections.Generic;
using GameEngine.Interfaces;
using GameEngine.Simboli;

namespace GameEngine.TavolaDaGioco
{
    public class Scacchiera
    {
        private List<Cella> _listaCelle;

        public Scacchiera()
        {
            _listaCelle = new List<Cella>();
            for (var i = 1; i <= 9; i++)
            {
                var cella = new Cella(i);
                _listaCelle.Add(cella);
            }
        }

        public ISimbolo Cella(int posizione)
        {
            return _listaCelle[posizione - 1].Simbolo;
        }
    }
}