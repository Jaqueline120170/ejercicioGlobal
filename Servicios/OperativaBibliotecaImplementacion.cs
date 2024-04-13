using ejercicioGlobal.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicioGlobal.Servicios
{
    
    internal class OperativaBibliotecaImplementacion : OperativaBibliotecaInterfaz
    {
       
        public void crearBiblioteca(List<BibliotecasDto>listaBibliotecas)
        {
            long idBiblio = Utilidades.Util.calcularIdBiblioteca(listaBibliotecas);
            Console.WriteLine("Introduzca el nombre de la biblioteca");
            string nombre = Console.ReadLine();
            Console.WriteLine("Introduzca el domicilio completo de la biblioteca separado por espacios");
            string domicilio = Console.ReadLine();
            BibliotecasDto bibliotecas = new BibliotecasDto(idBiblio, nombre, domicilio);
            return bibliotecas; 
            listaBibliotecas.Add(bibliotecas);  
        }
        /*public void mostrarListaBibliotecas(List<BibliotecasDto> listaBibliotecas)
        {
            foreach(BibliotecasDto biblioteca in listaBibliotecas)
            {
                Console.WriteLine(ClientesDto.ToString());
            }
        }
        */
        public void darAltaCliente(List<ClientesDto>listaClientes)
        {
            foreach (BibliotecasDto biblioteca in listaBibliotecas)
            {
                Console.WriteLine(biblioteca.ToString());
            }
            long id = Utilidades.Util.calcularIdCliente(listaClientes);
            Console.WriteLine("Introduzca el id de la biblioteca en la cual desea dar alta al cliente");
            long idBibliotecaSeleccionado = Convert.ToInt64(Console.ReadLine());
        }
    }
}
