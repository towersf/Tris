using System;

namespace GameEngine.Validators
{
    public class PosizioneValidator
    {
        public void Validate(int posizione)
        {
            if (posizione < 1 || posizione > 9)
            {
                throw new Exception("Posizione non valida. Valori ammessi da 1 a 9.");
            }
        }
    }
}
