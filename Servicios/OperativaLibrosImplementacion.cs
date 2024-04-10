using ejercicioGlobal.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicioGlobal.Servicios
{
    internal class OperativaLibrosImplementacion : OperativaLibrosInterfaz
    {
        public void crearLibro(List<LibrosDto> listaLibros)
        {
            long id = Utilidades.Util.calcularIdLibro(listaLibros);
            Console.WriteLine("Introduzca el titulo del libro");
            string titulo=Console.ReadLine();
            Console.WriteLine("Introduzca el subtitutlo del libro");
            string subtitulo = Console.ReadLine();
            Console.WriteLine("Introduzca nombre completo del autor separado por espacios");
            string nombreAu=Console.ReadLine();
            Console.WriteLine("Introduce el número de edicion del libro");
            int edicion = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Introduce la editorial del libro");
            string editorial=Console.ReadLine();
            Console.WriteLine("Introduce el stock de libros ");
            int stock = Console.ReadLine();
            LibrosDto libro = new LibrosDto();
            listaLibros.Add(libro);

        }
    }
}
