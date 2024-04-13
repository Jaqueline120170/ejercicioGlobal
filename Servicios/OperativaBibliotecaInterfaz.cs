using ejercicioGlobal.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicioGlobal.Servicios
{
    internal interface OperativaBibliotecaInterfaz
    {
        public void crearBiblioteca(List<BibliotecasDto> listaBibliotecas);
        public void darAltaCliente(List<ClientesDto> listaClientes);
    }
}
