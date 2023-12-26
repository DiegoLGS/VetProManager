using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeterinariaLib
{
    public class ListaPersonas
    {
        public List<Persona> listaPersonasActuales = new List<Persona>();

        public static bool ComprobarCoindicencia(ListaPersonas lista, Persona personaAComprobar, int indice)
        {
            bool coincidencia = false;

            foreach (Persona persona in lista.listaPersonasActuales)
            {
                if (persona == personaAComprobar && indice != lista.listaPersonasActuales.IndexOf(persona))
                {
                    coincidencia = true;
                    break;
                }
            }

            return coincidencia;
        }


        public static bool operator +(ListaPersonas lista, Persona persona)
        {
            bool respuesta = false;

            if (lista != persona)
            {
                lista.listaPersonasActuales.Add(persona);
                respuesta = true;
            }
            return respuesta;
        }

        public static bool operator -(ListaPersonas lista, Persona persona)
        {
            bool respuesta = false;

            if (lista == persona)
            {
                lista.listaPersonasActuales.Remove(persona);
                respuesta = true;
            }
            return respuesta;
        }

        public static bool operator ==(ListaPersonas lista, Persona persona)
        {
            return lista.listaPersonasActuales.Contains(persona);
        }

        public static bool operator !=(ListaPersonas lista, Persona persona)
        {
            return !(lista == persona);
        }
    }
}
