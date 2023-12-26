using System;
using System.Text;

namespace VeterinariaLib
{
    public class Animal
    {
        private string nombre;
        private DateTime fechaNacimiento;
        private DateTime fechaIngreso;
        private int id;
        private string especie;
        private string observaciones;
        private string historialMedico;
        private string nombreDelResponsable;
        private string apellidoDelResponsable;
        private int dniDelResponsable;

        public Animal(string nombre, DateTime fechaNacimiento, DateTime fechaIngreso,string especie, string observaciones, string historialMedico, string nombreDelResponsable, string apellidoDelResponsable,int dniDelResponsable)
        {
            this.nombre = nombre;
            this.fechaNacimiento = fechaNacimiento;
            this.fechaIngreso = fechaIngreso;
            this.especie = especie;
            this.observaciones = observaciones;
            this.historialMedico = historialMedico;
            this.nombreDelResponsable = nombreDelResponsable;
            this.apellidoDelResponsable = apellidoDelResponsable;
            this.dniDelResponsable = dniDelResponsable;
        }

        public string Nombre { get { return this.nombre; } set { this.nombre = value; } }

        public DateTime FechaNacimiento { get { return this.fechaNacimiento; } set { this.fechaNacimiento = value; } }

        public DateTime FechaIngreso { get { return this.fechaIngreso; } set { this.fechaIngreso = value; } }

        public string Especie { get { return this.especie; } set { this.especie = value; } }

        public int Id { get { return this.id; } set { this.id = value; } }

        public string Observaciones { get { return this.observaciones; } set { this.observaciones = value; } }

        public string HistorialMedico { get { return this.historialMedico; } set { this.historialMedico = value; } }

        public string NombreDelResponsable { get { return this.nombreDelResponsable; } set { this.nombreDelResponsable = value; } }

        public string ApellidoDelResponsable { get { return this.apellidoDelResponsable; } set { this.apellidoDelResponsable = value; } }

        public int DniDelResponsable { get { return this.dniDelResponsable; } set { this.dniDelResponsable = value; } }
                
        public string MostrarDetallesDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Datos detallados de {this.nombre}:");
            sb.AppendLine($"Fecha de nacimiento: {this.fechaNacimiento}");
            sb.AppendLine($"Fecha de ingreso: {this.fechaIngreso}");
            sb.AppendLine($"ID: {this.id}");
            sb.AppendLine($"Especie: {this.especie}");
            sb.AppendLine($"Nombre del responsable: {this.nombreDelResponsable}");
            sb.AppendLine($"Apellido del responsable: {this.apellidoDelResponsable}");
            sb.AppendLine($"DNI del responsable: {this.dniDelResponsable}");
            sb.AppendLine($"Observaciones: {this.observaciones}");
            sb.AppendLine($"Historial médico: {this.historialMedico}");

            return sb.ToString();
        }

        public override bool Equals(object obj)
        {
            return this == (Animal)obj;
        }

        public static bool operator ==(Animal animalUno, Animal animalDos)
        {
            return animalUno.Id == animalDos.Id;
        }

        public static bool operator !=(Animal animalUno, Animal animalDos)
        {
            return !(animalUno == animalDos);
        }
    }
}
