using System;

namespace GameEngine.TavolaDaGioco
{
    public class NessunVincitoreException : Exception
    {
        public NessunVincitoreException():base("Nessun voncitore")
        { }
    }
}