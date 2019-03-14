using System;
using GameEngine.Interfaces;

namespace GameEngine
{
    public class Giocatore
    {
        public string Nome { get; }
        public ISimbolo Simbolo { get; }

        public Giocatore(string nomeGiocatore, ISimbolo simbolo)
        {
            if (string.IsNullOrWhiteSpace(nomeGiocatore))
            {
                throw new Exception("Nome giocatore obbligatorio");
            }

            Simbolo = simbolo;

            Nome = nomeGiocatore;
        }
    }
}