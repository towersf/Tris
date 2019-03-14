using System;

namespace GameEngine
{
    public class Giocatore
    {
        public string Nome { get; }

        public Giocatore(string nomeGiocatore)
        {
            if (string.IsNullOrWhiteSpace(nomeGiocatore))
            {
                throw new Exception("Nome giocatore obbligatorio");
            }
            Nome = nomeGiocatore;
        }
    }
}