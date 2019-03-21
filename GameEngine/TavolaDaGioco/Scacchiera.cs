using System;
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

        public void ImpostaSimbolo(int posizione, ISimbolo simbolo)
        {
            if (_listaCelle[posizione - 1].Simbolo.GetType() != typeof(SimboloVuoto))
            {
                throw new Exception("Questa cella non è disponibile.");
            }
            _listaCelle[posizione - 1].Simbolo = simbolo;
        }
    }
}