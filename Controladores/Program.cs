using ejercicioGlobal.Servicios;
using ejercicioGlobal.Dtos;
using System.Text;

namespace ejercicioGlobal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MenuInterfaz mi = new MenuImplementacion();

            int opcion;
            bool cerrarMenu=false;

            while(!cerrarMenu)
            {
                opcion=mi.mostrarMenuYSeleccion();
                switch (opcion)
                {
                    case 0:
                        Console.WriteLine("CERRAR MENU");
                        cerrarMenu=true;
                        break;
                    case 1:
                        Console.WriteLine("CREAR BIBLIOTECA");
                        break;
                    case 2:
                        Console.WriteLine("CREAR CLIENTE");
                        break;
                    case 3:
                        Console.WriteLine("CREAR LIBRO");
                        break;
                    case 4:
                        Console.WriteLine("CREAR PRESTAMO");
                        break;
                    default:
                        Console.WriteLine("INTRODUZCA UNA OPCION VALIDA");
                        break;
                }
            }

        }
    }
}
