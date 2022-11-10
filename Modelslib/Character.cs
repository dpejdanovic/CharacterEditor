namespace Modelslib
{
    public class Character
    {
        private const int BaseValue = 1;

        public string? Name { get; set; }
        public Helm? Helm { get; set; }
        public Ruestung? Ruestung { get; set; }
        public Stiefel? Stiefel { get; set; }
        public Waffe? Waffe { get; set; }
        public int Defense 
        { 
            get
            {
                // Anhand der ausgerüsteten Teile berechnen
                // Der Wert darf nicht negativ werden
                return BaseValue;
            }
        }
        public int Attack
        {
            get
            {
                // Anhand der ausgerüsteten Teile berechnen
                // Der Wert darf nicht negativ werden
                return BaseValue;
            }
        }
        public int Health
        {
            get
            {
                // Anhand der ausgerüsteten Teile berechnen
                // Der Wert darf nicht negativ werden
                return BaseValue;
            }
        }

    }
}