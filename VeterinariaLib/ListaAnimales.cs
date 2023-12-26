using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeterinariaLib
{
    public class ListaAnimales
    {
        public List<Animal> listaAnimalesActuales = new List<Animal>();        

        public static bool operator +(ListaAnimales lista, Animal animal)
        {
            bool respuesta = false;

            if (lista != animal)
            {
                lista.listaAnimalesActuales.Add(animal);
                respuesta = true;
            }
            return respuesta;
        }

        public static bool operator -(ListaAnimales lista, Animal animal)
        {
            bool respuesta = false;

            if (lista == animal)
            {
                lista.listaAnimalesActuales.Remove(animal);
                respuesta = true;
            }
            return respuesta;
        }

        public static bool operator ==(ListaAnimales lista, Animal animal)
        {
            return lista.listaAnimalesActuales.Contains(animal);            
        }

        public static bool operator !=(ListaAnimales lista, Animal animal)
        {
            return !(lista == animal);
        }
    }
}
