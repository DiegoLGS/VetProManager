using System.Text;

namespace VeterinariaLib
{
    public class Persona
    {
        private string nombre;
        private string apellido;
        private int dni;
        private string numeroContacto;
        
        public Persona(string nombre, string apellido, int dni, string numeroContacto) 
        { 
            this.nombre = nombre;
            this.apellido = apellido;
            this.dni = dni;
            this.numeroContacto = numeroContacto;
        }

        public string Nombre { get { return this.nombre; } set { this.nombre = value; } }
       
        public string Apellido { get { return this.apellido; } set { this.apellido = value; } }

        public int Dni { get { return this.dni; } set { this.dni = value; } }

        public string NumeroContacto { get { return this.numeroContacto; } set { this.numeroContacto = value; } }

        public override bool Equals(object obj)
        {
            return this == (Persona)obj;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Nombre completo: {this.nombre} {this.apellido}");
            sb.AppendLine($"DNI: {this.dni}");
            sb.AppendLine($"Número de contacto: {this.numeroContacto}");

            return sb.ToString();
        }

        public static bool operator ==(Persona personaUno, Persona personaDos)
        {
            return personaUno.dni == personaDos.dni;
        }

        public static bool operator !=(Persona personaUno, Persona personaDos)
        {
            return !(personaUno == personaDos);
        }
    }
}
