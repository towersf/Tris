using GameEngine.Interfaces;

namespace GameEngine
{
    public interface IGiocatore
    {
        string Nome { get; }
        ISimbolo Simbolo { get; }
    }
}