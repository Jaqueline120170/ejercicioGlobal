using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicioGlobal.Dtos
{
    internal class PrestamosDto
    {
        long idPrestamo;
        long idClientePrestamo;
        DateTime fechaPrestamo;
        DateTime fechaEntrega;

        public long IdPrestamo { get => idPrestamo; set => idPrestamo = value; }
        public long IdClientePrestamo { get => idClientePrestamo; set => idClientePrestamo = value; }
        public DateTime FechaPrestamo { get => fechaPrestamo; set => fechaPrestamo = value; }
        public DateTime FechaEntrega { get => fechaEntrega; set => fechaEntrega = value; }
    }
}
