using System.Runtime.CompilerServices;
namespace Billetes
{
    public class Pesos
    {
        private double cantidad;
        private static double cotFromDolar;

        static Pesos()
        {
            Pesos.cotFromDolar = 398;
        }

        public Pesos(double cantidad)
        {
            this.cantidad = cantidad;
        }

        public Pesos(double cantidad, double cotFromDolar) : this(cantidad) {
            Pesos.cotFromDolar= cotFromDolar;
        }
        public static double GetCotizacion()
        {
            return Pesos.cotFromDolar;
        }
        public static implicit operator Pesos(double cantidad)
        {
            return new Pesos(cantidad);
        }
    }

    public class Euro
    {
        private double cantidad;
        private static double cotFromDolar;
        static Euro()
        {
            Euro.cotFromDolar = 0.9;
        }

        public Euro(double cantidad)
        {
            this.cantidad = cantidad;
        }
        public Euro(double cantidad, double cotFromDolar) : this(cantidad)
        {
            Euro.cotFromDolar = cotFromDolar;
        }
        public static double GetCotizacion()
        {
            return Euro.cotFromDolar;
        }
    }

    public class Dolar
    {
        private double cantidad;
        private static double cotFromDolar;
        static Dolar()
        {
            Dolar.cotFromDolar = 1;
        }

        public Dolar(double cantidad) {
            this.cantidad = cantidad;
        }
        public Dolar(double cantidad, double cotFromDolar) : this(cantidad)
        {
            Dolar.cotFromDolar = cotFromDolar;
        }
        public static double GetCotizacion()
        {
            return Dolar.cotFromDolar;
        }

    }
}