namespace ejercicioGlobal.Dtos
{
    internal class BibliotecasDto
    {
        long idBiblioteca;
        string nombreBiblioteca = "aaaaa";
        string calleBiblioteca = "aaaaa";
        int numeroPortal = 11111;
        int codigoPostal = 11111;
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
            this.domicilioCompleto = calleBiblioteca + numeroPortal.ToString() + codigoPostal.ToString() + localidad + provinciaBiblioteca;          
            
        }

        public long IdBiblioteca { get => idBiblioteca; set => idBiblioteca = value; }
        public string NombreBiblioteca { get => nombreBiblioteca; set => nombreBiblioteca = value; }
        public string CalleBiblioteca { get => calleBiblioteca; set => calleBiblioteca = value; }
        public int NumeroPortal { get => numeroPortal; set => numeroPortal = value; }
        public int CodigoPostal { get => codigoPostal; set => codigoPostal = value; }
        public string Localidad { get => localidad; set => localidad = value; }
        public string ProvinciaBiblioteca { get => provinciaBiblioteca; set => provinciaBiblioteca = value; }
        public string DomicilioCompleto { get => domicilioCompleto; set => domicilioCompleto = value; }

        override
        public string ToString()
        {
            string bibliotecaString = "Lista de bibliotecas\n" + this.idBiblioteca + " " + this.nombreBiblioteca;
            return bibliotecaString;
        }
    }
}
