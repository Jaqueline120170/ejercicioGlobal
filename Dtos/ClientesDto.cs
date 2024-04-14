using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicioGlobal.Dtos
{
    internal class ClientesDto
    {
       
        string nombreCliente = "aaaaa";
        string apellido1 = "aaaaa";
        string apellido2 = "aaaaa";
        string nombreCompletoCliente = "aaaaa";
        int numeroDni = 11111;
        char letraDni = 'A';
        string dniCliente = "aaaaa";
        string emailCliente = "aaaaa";
        string inicioSuspension = "12/12/1999";
        string finSuspension = "12712/1999";
        long idCliente;

        public ClientesDto(string nombreCompletoCliente, string dniCliente, string emailCliente, long idCliente)
        {
            this.nombreCompletoCliente = nombreCompletoCliente;
            string[] arrayNombre = nombreCompletoCliente.Split(" ");
            this.nombreCliente = arrayNombre[0];
            this.apellido1 = arrayNombre[1];
            this.apellido2 = arrayNombre[2];
            this.dniCliente = numeroDni.ToString() + letraDni;
            this.emailCliente = emailCliente;
            this.idCliente = idCliente;
        }

        public string NombreCliente { get => nombreCliente; set => nombreCliente = value; }
        public string Apellido1 { get => apellido1; set => apellido1 = value; }
        public string Apellido2 { get => apellido2; set => apellido2 = value; }
        public string NombreCompletoCliente { get => nombreCompletoCliente; set => nombreCompletoCliente = value; }
        public int NumeroDni { get => numeroDni; set => numeroDni = value; }
        public char LetraDni { get => letraDni; set => letraDni = value; }
        public string DniCliente { get => dniCliente; set => dniCliente = value; }
        public string EmailCliente { get => emailCliente; set => emailCliente = value; }
        public string InicioSuspension { get => inicioSuspension; set => inicioSuspension = value; }
        public string FinSuspension { get => finSuspension; set => finSuspension = value; }
        public long IdCliente { get => idCliente; set => idCliente = value; }
    }
}
