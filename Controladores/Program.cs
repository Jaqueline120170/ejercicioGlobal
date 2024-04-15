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
            OperativaBibliotecaInterfaz oi = new OperativaBibliotecaImplementacion();
            List<BibliotecasDto> listaBibliotecas = new List<BibliotecasDto>();
            List<ClientesDto> listaClientes = new List<ClientesDto>();

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
                        oi.crearBiblioteca(listaBibliotecas);
                        break;
                    case 2:
                        Console.WriteLine("ACCESO BIBLIOTECA");
                        mi.opcionMenuBiblioteca(listaBibliotecas);
                        break;

                    default:
                        Console.WriteLine("INTRODUZCA UNA OPCION VALIDA");
                        break;
                }
            }

        }
    }
}
