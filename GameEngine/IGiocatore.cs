using GameEngine.Interfaces;

namespace GameEngine
{
    internal interface IGiocatore
    {
        string Nome { get; }
        ISimbolo Simbolo { get; }
    }
}