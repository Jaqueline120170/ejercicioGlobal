using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicioGlobal.Dtos
{
    internal class LibrosDto
    {
        long idLibro;
        string tituloLibro = "aaaaa";
        string subtituloLibro = "aaaaa";
        string nombreAutor = "aaaaa";
        string primerApellidoAutor = "aaaaa";
        string segundoApellidoAutor = "aaaaa";
        string nombreCompletoAutor = "aaaaa";
        string codigoISBN = "aaaaa";
        int numeroEdicion = 11111;
        string editorialLibro = "aaaaa";
        int stockLibros = 11111;

        public LibrosDto()
        {
        }

        public LibrosDto(long idLibro, string tituloLibro, string subtituloLibro, string nombreCompletoAutor, int numeroEdicion, string editorialLibro, int stockLibros)
        {
            this.idLibro = idLibro;
            this.tituloLibro = tituloLibro;
            this.subtituloLibro = subtituloLibro;
            this.nombreCompletoAutor = nombreCompletoAutor;
            string[] arrayAutor = nombreCompletoAutor.Split(' ');
            this.nombreAutor = arrayAutor[0];
            this.primerApellidoAutor= arrayAutor[1];
            this.segundoApellidoAutor = arrayAutor[2];
            this.codigoISBN = codigoISBN;
            this.numeroEdicion = numeroEdicion;
            this.editorialLibro = editorialLibro;
            this.stockLibros = stockLibros;
        }

        public long IdLibro { get => idLibro; set => idLibro = value; }
        public string TituloLibro { get => tituloLibro; set => tituloLibro = value; }
        public string SubtituloLibro { get => subtituloLibro; set => subtituloLibro = value; }
        public string NombreAutor { get => nombreAutor; set => nombreAutor = value; }
        public string PrimerApellidoAutor { get => primerApellidoAutor; set => primerApellidoAutor = value; }
        public string SegundoApellidoAutor { get => segundoApellidoAutor; set => segundoApellidoAutor = value; }
        public string NombreCompletoAutor { get => nombreCompletoAutor; set => nombreCompletoAutor = value; }
        public string CodigoISBN { get => codigoISBN; set => codigoISBN = value; }
        public int NumeroEdicion { get => numeroEdicion; set => numeroEdicion = value; }
        public string EditorialLibro { get => editorialLibro; set => editorialLibro = value; }
        public int StockLibros { get => stockLibros; set => stockLibros = value; }
    }
}
