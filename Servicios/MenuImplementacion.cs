using ejercicioGlobal.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicioGlobal.Servicios
{
    internal class MenuImplementacion : MenuInterfaz

    {
        OperativaBibliotecaInterfaz oi = new OperativaBibliotecaImplementacion();
        List<ClientesDto> listaClientes = new List<ClientesDto> ();
        List<LibrosDto> listaLibros = new List<LibrosDto> ();
        public int mostrarMenuYSeleccion()
        {
            int opcionSeleccionada;
            Console.WriteLine("0. Cerrar Menu");
            Console.WriteLine("1. Crear biblioteca");
            Console.WriteLine("2. Acceder a biblioteca");
            Console.WriteLine("Seleccione una opcion");
            opcionSeleccionada = Convert.ToInt32(Console.ReadLine());
            return opcionSeleccionada;
        }
        private  int mostrarMenuBiblioteca()
        {
            int seleccionOpcion;
            Console.WriteLine("0. Volver a menu inicial");
            Console.WriteLine("1. Dar alta cliente");
            Console.WriteLine("2. Dar alta libro");
            Console.WriteLine("3. Gestionar un prestamo");
            Console.WriteLine("Seleccione una opcion");
            seleccionOpcion = Convert.ToInt32(Console.ReadLine());
            return seleccionOpcion;
        }
        public void opcionMenuBiblioteca(List<BibliotecasDto> listaBibliotecas)
        {
            int opcion = mostrarMenuBiblioteca();
            
            switch (opcion)
            {
                case 0:

                    break;
                case 1:
                    oi.darAltaCliente(listaClientes, listaBibliotecas);
                    break;
                case 2:
                    oi.darAltaLibro(listaLibros,listaBibliotecas);
                    break;
                case 3:
                    //oi.darAltaLibro();
                    break;
                case 4:
                   // oi.gestionarPrestamo();
                    break;
                default:
                    Console.WriteLine("Introduzca una opcion alida");
                    break;
            }
        }
    }
}
