using System.Collections.Generic;
using GameEngine.TavolaDaGioco;

namespace GameEngine.Simboli
{
    internal class ValutatoreVittoriaService
    {
        public bool Valuta(List<Cella> listaCelle)
        {
            return _valutaVittoria(listaCelle);
        }

        private bool _valutaVittoria(List<Cella> listaCelle)
        {
            var vinto = _rigaVincente(listaCelle, 1, 2, 3);
            if (vinto) { return true; }

            vinto = _rigaVincente(listaCelle, 1, 5, 9);
            if (vinto) { return true; }

            vinto = _rigaVincente(listaCelle, 1, 4, 7);
            if (vinto) { return true; }

            vinto = _rigaVincente(listaCelle, 4, 5, 6);
            if (vinto) { return true; }

            vinto = _rigaVincente(listaCelle, 7, 8, 9);
            if (vinto) { return true; }

            vinto = _rigaVincente(listaCelle, 2, 5, 8);
            if (vinto) { return true; }

            vinto = _rigaVincente(listaCelle, 3, 6, 9);
            if (vinto) { return true; }

            vinto = _rigaVincente(listaCelle, 3, 5, 7);
            if (vinto) { return true; }

            return false;
        }

        private bool _rigaVincente(List<Cella> listaCelle, int cella1, int cella2, int cella3)
        {
            var simbolo1 = listaCelle[cella1 - 1].Simbolo;
            var simbolo2 = listaCelle[cella2 - 1].Simbolo;
            var simbolo3 = listaCelle[cella3 - 1].Simbolo;

            return simbolo1.GetType() != typeof(SimboloVuoto)
                && simbolo1.GetType() == simbolo2.GetType()
                && simbolo1.GetType() == simbolo3.GetType();
        }
    }
}