using GameEngine.Interfaces;
using GameEngine.Simboli;

namespace GameEngine.TavolaDaGioco
{
    public class Cella
    {
        public int Numero { get; }
        public ISimbolo Simbolo;

        public Cella(int numero)
        {
            Simbolo = new SimboloVuoto(numero);
            Numero = numero;
        }
    }
}