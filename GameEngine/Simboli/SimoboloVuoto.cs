﻿using GameEngine.Interfaces;

namespace GameEngine.Simboli
{
    public class SimoboloVuoto : ISimbolo
    {
        public string[] Righe { get; }

        public SimoboloVuoto(int numero)
        {
            Righe = new string[5];
            Righe[0] = "       ";
            Righe[1] = "       ";
            Righe[2] = $"   {numero}   ";
            Righe[3] = "       ";
            Righe[4] = "       ";
        }
    }
}