using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoModuloSimulacion.Models
{
    public class Vehiculo
    {
        public double Capacidad { get; set; }
        public long LatitudOrigenCondicionInicial { get; set; }
        public long LongitudOrigenCondicionInicial { get; set; }


        public DateTime FechaDisponible { get; set; }

        public List<Asignacion> ListaAsignaciones = new List<Asignacion>();
        public Vehiculo() { }

        public Vehiculo(double capacidad, long latitudOrigenCondicionInicial, 
            long longitudOrigenCondicionInicial, DateTime fechaDisponible, List<Asignacion> listaAsignaciones)

        {
            Capacidad = capacidad;
            LatitudOrigenCondicionInicial = latitudOrigenCondicionInicial;
            LongitudOrigenCondicionInicial = longitudOrigenCondicionInicial;
            FechaDisponible = fechaDisponible;
            ListaAsignaciones = listaAsignaciones;

        }
    }
}
