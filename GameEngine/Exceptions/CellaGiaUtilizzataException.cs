using System;

namespace GameEngine.TavolaDaGioco
{
    public class CellaGiaUtilizzataException : Exception
    {
        public CellaGiaUtilizzataException() : base("Cella già utilizzata")
        { }
    }
}