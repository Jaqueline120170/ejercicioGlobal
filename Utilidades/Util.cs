using ejercicioGlobal.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicioGlobal.Utilidades
{
    internal class Util
    {
        public static long calcularIdBiblioteca(List<BibliotecasDto> listaBibliotecas)
        {

            long nuevoId = 0;
            int tamanio = listaBibliotecas.Count();

            if (tamanio > 0)
            {

                nuevoId = listaBibliotecas[tamanio - 1].IdBiblioteca + 1;

            }
            else
            {

                nuevoId = 1;

            }

            return nuevoId;

        }

        public static long calcularIdCliente(List<ClientesDto> listaClientes)
        {

            long nuevoId = 0;
            int tamanio = listaClientes.Count();

            if (tamanio > 0)
            {

                nuevoId = listaClientes[tamanio - 1].IdCliente + 1;

            }
            else
            {

                nuevoId = 0;

            }

            return nuevoId;

        }
        public static long calcularIdLibro(List<LibrosDto> listaLibros)
        {

            long nuevoId = 0;
            int tamanio = listaClientes.Count();

            if (tamanio > 0)
            {

                nuevoId = listaClientes[tamanio - 1].IdLibro +1;

            }
            else
            {

                nuevoId = 0;

            }

            return nuevoId;

        }
        public static long calcularIdPrestamo(List<PrestamosDto> listaPrestamos)
        {

            long nuevoId = 0;
            int tamanio = listaPrestamos.Count();

            if (tamanio > 0)
            {

                nuevoId = listaPrestamos[tamanio - 1].IdLibro + 1;

            }
            else
            {

                nuevoId = 0;

            }

            return nuevoId;

        }
    }
}
