using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicioGlobal.Servicios
{
    internal class MenuImplementacion : MenuInterfaz
    {
        public int mostrarMenuYSeleccion()
        {
            int opcionSeleccionada;
            Console.WriteLine("0. Cerrar Menu");
            Console.WriteLine("1. Crear biblioteca");
            Console.WriteLine("2. Dar alta cliente");
            Console.WriteLine("3. Crear libro");
            Console.WriteLine("4. Crear prestamo");
            Console.WriteLine("Seleccione una opcion");
            opcionSeleccionada = Convert.ToInt32(Console.ReadLine());
            return opcionSeleccionada;
        }
    }
}
