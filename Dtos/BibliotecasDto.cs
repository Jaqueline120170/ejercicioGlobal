namespace ejercicioGlobal.Dtos
{
    internal class BibliotecasDto
    {
        long idBiblioteca;
        string nombreBiblioteca = "aaaaa";
        string calleBiblioteca = "aaaaa";
        string numeroPortal = "aaaaa";
        string  codigoPostal = "aaaaa";
        string localidad = "Sevilla";
        string provinciaBiblioteca = "Sevilla";
        string domicilioCompleto = "aaaaa";
        
        public BibliotecasDto()
        {
        }

        public BibliotecasDto(long idBiblioteca, string nombreBiblioteca, string domicilioCompleto)
        {
            this.idBiblioteca = idBiblioteca;
            this.nombreBiblioteca = nombreBiblioteca;
            this.domicilioCompleto = domicilioCompleto;
            string[] arrayDomicilio=domicilioCompleto.Split(' ');
            this.calleBiblioteca = arrayDomicilio[0];
            this.numeroPortal = arrayDomicilio[1];
            this.codigoPostal = arrayDomicilio[2];
            this.localidad = arrayDomicilio[3];
            this.provinciaBiblioteca = arrayDomicilio[4];
            
        }

        public long IdBiblioteca { get => idBiblioteca; set => idBiblioteca = value; }
        public string NombreBiblioteca { get => nombreBiblioteca; set => nombreBiblioteca = value; }
        public string CalleBiblioteca { get => calleBiblioteca; set => calleBiblioteca = value; }
        public string NumeroPortal { get => numeroPortal; set => numeroPortal = value; }
        public string CodigoPostal { get => codigoPostal; set => codigoPostal = value; }
        public string Localidad { get => localidad; set => localidad = value; }
        public string ProvinciaBiblioteca { get => provinciaBiblioteca; set => provinciaBiblioteca = value; }
        public string DomicilioCompleto { get => domicilioCompleto; set => domicilioCompleto = value; }

        override
        public string ToString()
        {
            string bibliotecaString = "Lista de bibliotecas\n" + this.idBiblioteca;
        }
    }
}
