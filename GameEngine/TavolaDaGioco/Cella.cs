using GameEngine.Interfaces;
using GameEngine.Simboli;

namespace GameEngine.TavolaDaGioco
{
    public class Cella
    {
        public int Numero { get; }
        public ISimbolo simbolo;

        public Cella(int numero)
        {
            simbolo = new SimoboloVuoto();
            Numero = numero;
        }
    }
}