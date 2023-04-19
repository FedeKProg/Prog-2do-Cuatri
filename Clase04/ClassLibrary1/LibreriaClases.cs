namespace LibreriaClases
{
    public class Persona
    {
        private int dni;
        public Persona(int dni)
        {
            this.dni = dni;
        }
        public int getDni()
        {
            return this.dni;
        }

        public static implicit operator Persona(int dni)
        {

            return new Persona(dni);
        }

    }
}