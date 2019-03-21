using GameEngine.Interfaces;
using System;

namespace GameEngine
{
    public class Giocatore : IGiocatore
    {
        public string Nome { get; }
        public ISimbolo Simbolo { get; }

        public Giocatore(string nome, ISimbolo simbolo)
        {
            if (string.IsNullOrWhiteSpace(nome))
            {
                throw new Exception("Nome giocatore obbligatorio");
            }
            Nome = nome;
            Simbolo = simbolo;
        }
    }
}