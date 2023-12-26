using System;

namespace VeterinariaLib
{
    public class ComandoBDException : Exception
    {
        public ComandoBDException() : base("La ejecución del comando no afectó el número esperado de filas en la base de datos.") { }

        public ComandoBDException(string mensaje) : base(mensaje)
        {
        }
    }
}
