using ProyectoModuloSimulacion.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoModuloSimulacion.Algoritmos
{
    public class AlgoritmoGenetico
    {
        List<Viaje> ListaViajes = new List<Viaje>();
        public AlgoritmoGenetico() 
        {
        
        }
        public void AlgoritmoPrincipal(int recursos, int tareas) 
        {
        
        }
        public List<int> GeneracionPseudoaleatorios(int semilla, int m, 
            int a, int c, int total) 
        {
            List<int> listaPseudoaleatorios = new List<int>();

            // Paso 1: Guardamos la semilla
            listaPseudoaleatorios.Add(semilla);
            int valorGenerado = semilla;
            // Paso 2: inicia ciclo de total de números pseudoaleatorios
            for (int i = 0; i < total; i++) 
            {
                int valorAnterior = valorGenerado; 
                // Paso 2.1: Generar el siguiente valor pseaudoleatoria
                valorGenerado = (a * valorGenerado + c) % m;
                // Paso 2.2: Añadir elemento en la lista de return
                listaPseudoaleatorios.Add(valorGenerado);
                // Paso 2.3: Criterio de paro
                if (valorGenerado == valorAnterior) 
                {
                    break;
                }
            }
            return listaPseudoaleatorios;
        }
    }
}
