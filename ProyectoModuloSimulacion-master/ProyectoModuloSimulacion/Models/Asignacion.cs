using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoModuloSimulacion.Models
{
    public class Asignacion
    {
        public string IdOrigen { get; set; }
        public string IdDestino { get; set; }

        public long LatitudOrigen { get; set; }
        public long LongitudOrigen { get; set; }

        public long LatitudDestino { get; set; }
        public long LongitudDestino { get; set; }

        public int CantidadDemanda { get; set; }

        public int IdCarro { get; set; }

        public int CantidadSurtida { get; set; }

        public string IdProducto { get; set; }
        public string IdCliente { get; set; }
        public DateTime FechaHoraLlegada { get; set; }

        public Asignacion(string idOrigen, string idDestino, long latitudOrigen, 
            long longitudOrigen, long latitudDestino, long longitudDestino, 
            int cantidadDemanda, int idCarro, int cantidadSurtida, string idProducto, 
            DateTime fechaHoraLlegada, string cliente)

        {
            IdOrigen = idOrigen;
            IdDestino = idDestino;
            LatitudOrigen = latitudOrigen;
            LongitudOrigen = longitudOrigen;
            LatitudDestino = latitudDestino;
            LongitudDestino = longitudDestino;
            CantidadDemanda = cantidadDemanda;
            IdCarro = idCarro;
            CantidadSurtida = cantidadSurtida;
            IdProducto = idProducto;
            FechaHoraLlegada = fechaHoraLlegada;
            IdCliente = cliente;
        }
        public Asignacion() { }

    }
}
