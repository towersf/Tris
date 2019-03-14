using System;
using System.Collections.Generic;
using System.Linq;
using GameEngine.Interfaces;
using GameEngine.Simboli;
using GameEngine.Validators;

namespace GameEngine.TavolaDaGioco
{
    public class Scacchiera
    {
        private readonly List<Cella> _listaCelle;
        private readonly PosizioneValidator _posizioneValidator;
        private readonly ValutatoreVittoriaService _valutatoreVittoria;

        public Scacchiera()
        {
            _posizioneValidator = new PosizioneValidator();
            _valutatoreVittoria = new ValutatoreVittoriaService();

            _listaCelle = new List<Cella>();
            for (var i = 1; i <= 9; i++)
            {
                _listaCelle.Add(new Cella(i));
            }
        }

        public bool PartitaConclusa { get; private set; }

        public ISimbolo GetSimboloCella(int posizione)
        {
            _posizioneValidator.Validate(posizione);

            return _listaCelle[posizione - 1].Simbolo;
        }

        public void ImpostaCasella(int posizione, ISimbolo simbolo)
        {
            _posizioneValidator.Validate(posizione);

            var cella = _listaCelle[posizione - 1];

            if (cella.Simbolo.GetType() != typeof(SimboloVuoto))
            {
                throw new CellaGiaUtilizzataException();
            }

            cella.Simbolo = simbolo;

            PartitaConclusa = _valutatoreVittoria.Valuta(_listaCelle);

            if (!PartitaConclusa && _listaCelle.All(c => c.Simbolo.GetType() != typeof(SimboloVuoto)))
            {
                throw new NessunVincitoreException();
            }
        }
    }
}