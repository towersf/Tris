using GameEngine.Interfaces;

namespace GameEngine.Simboli
{
    public class SimboloO : ISimbolo
    {
        public string[] Righe { get; }

        public SimboloO()
        {
            Righe = new string[5];
            Righe[0] = "  000  ";
            Righe[1] = " 0   0 ";
            Righe[2] = " 0   0 ";
            Righe[3] = " 0   0 ";
            Righe[4] = "  000  ";
        }
    }
}