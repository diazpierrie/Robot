namespace CintaTrans
{
    public class Robot
    {
        //Se utilizan Word = (bit0= Encendido, bit1=Prensa, bit2=Cinta, bit3=Apilados) ej. 0000-1000-1010

        private static Robot _instancia;

        private Robot()
        {
        }

        public string BEncendido { get; set; } // Encendido

        public string BPrensa { get; set; } // Prensa
        public string BCinta { get; set; } // Cinta
        public string BPila { get; set; } // Pila

        public string Apilados { get; set; }

        public static Robot InstanciaUnica()

        {
            return _instancia ?? (_instancia = new Robot());
        }
    }
}