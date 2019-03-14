using System.Collections.Generic;

namespace GameEngine.TavolaDaGioco
{
    public class Scacchiera
    {
        private List<Cella> _listaCelle;

        public Scacchiera()
        {
            _listaCelle = new List<Cella>();
            for (var i = 1; i < 10; i++)
            {
                var cella = new Cella(i);
                _listaCelle.Add(cella);
            }
        }
    }
}