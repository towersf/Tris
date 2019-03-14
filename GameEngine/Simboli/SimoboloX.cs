using GameEngine.Interfaces;

namespace GameEngine.Simboli
{
    public class SimoboloX : ISimbolo
    {
        public string[] Righe { get; }

        public SimoboloX()
        {
            Righe = new string[5];
            Righe[0] = " 0   0 ";
            Righe[1] = "  0 0  ";
            Righe[2] = "   0   ";
            Righe[3] = "  0 0  ";
            Righe[4] = " 0   0 ";
        }
    }
}