using ejercicioGlobal.Dtos;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ejercicioGlobal.Servicios
{
    
    internal class OperativaBibliotecaImplementacion : OperativaBibliotecaInterfaz
    {
       
        public List<BibliotecasDto> crearBiblioteca(List<BibliotecasDto>listaBibliotecas)
        {
            long idBiblio = Utilidades.Util.calcularIdBiblioteca(listaBibliotecas);
            Console.WriteLine("Introduzca el nombre de la biblioteca");
            string nombre = Console.ReadLine();
            Console.WriteLine("Introduzca el domicilio completo de la biblioteca separado por espacios");
            string domicilio = Console.ReadLine();
            BibliotecasDto bibliotecas = new BibliotecasDto(idBiblio, nombre, domicilio);
           
            listaBibliotecas.Add(bibliotecas);
            
            Console.WriteLine(bibliotecas.ToString());
            return listaBibliotecas;
        }
        
       
        public void darAltaCliente(List<ClientesDto>listaClientes, List<BibliotecasDto>listaBibliotecas)
        {
           
            Console.WriteLine("Introduzca el id de la biblioteca en la cual desea dar alta al cliente");
            Utilidades.Util.mostrarListaBibliotecas(listaBibliotecas);
            long idBibliotecaSeleccionado = Convert.ToInt64(Console.ReadLine());
          
            foreach(BibliotecasDto biblio in listaBibliotecas)
            {
                if (biblio.IdBiblioteca.Equals(idBibliotecaSeleccionado))
                {
                    
                    Console.WriteLine("Introduzca su nombre completo separado por espacios");
                    string nombre = Console.ReadLine();
                    Console.WriteLine("Introduzca la letra de su DNI");
                    char letra = Convert.ToChar(Console.ReadLine());
                    Console.WriteLine("Introduzca la serie numerica de su DNI");
                    int numero = Convert.ToInt32(Console.ReadLine());
                    var dni = verificarDni(numero, letra);

                    foreach(ClientesDto cliente in listaClientes)
                    { 
                        if (cliente.DniCliente.Equals(dni))
                        {
                            Console.WriteLine("El dni del cliente ya existe");
                        }
                        else
                        {
                            Console.WriteLine("Introduzca el email del cliente");
                            string email = Console.ReadLine();
                            long id = Utilidades.Util.calcularIdCliente(listaClientes);
                            ClientesDto clienteNuevo = new ClientesDto(nombre,letra,numero, email, id);
                            listaClientes.Add(clienteNuevo);

                        }
                    }
                    
                }
                else
                {
                    Console.WriteLine("La biblioteca seleccionada no existe, introduzca un id valido");
                }
            }
        }
        public void darAltaLibro(List<LibrosDto>listaLibros,List<BibliotecasDto>listaBiliotecas)
        {
            Console.WriteLine("Introduzca el id de la biblioteca en la cual desea dar alta al cliente");
            Utilidades.Util.mostrarListaBibliotecas(listaBiliotecas);
            long idBibliotecaSeleccionado = Convert.ToInt64(Console.ReadLine());
            foreach (BibliotecasDto biblio in listaBiliotecas)
            {
                if (biblio.IdBiblioteca.Equals(idBibliotecaSeleccionado))
                {

                    long idLib = Utilidades.Util.calcularIdLibro(listaLibros);
                    Console.WriteLine("Introduzca el titulo del libro que desea dar de alta");
                    string nombreLib = Console.ReadLine();
                    Console.WriteLine("Introduzca el subtitulo del libro");
                    string nombreSub = Console.ReadLine();
                    Console.WriteLine("Introduzca el nombre completo del autor separado por espacios");
                    string nombreAu = Console.ReadLine();
                    Console.WriteLine("Introduzca el codigo ISBN del libro");
                    int[] codigo = { Convert.ToInt32(Console.ReadLine()) };
                    for (int x = 0; x < codigo.Length; x++)
                    {
                        codigo[x] = Convert.ToInt32(Console.ReadLine());
                    }
                    bool pares = codigo.Distinct().Count() == codigo.Length;
                    Console.WriteLine("Introduzca la editorial del libro");
                    string editorial = Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("La biblioteca seleccionada no existe, introduzca un id valido");
                }
            }
        }
        private int[] verificarDuplicadoCodigoISBN()
        {
            return verificarDuplicadoCodigoISBN();
        }
     
        private int verificarDni(int dniCliente, char letraCliente)
        {
            int dniBuscar = -1;
            char letra = ' ';

            int[] resto = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22 };
            char[] letras = { 'T', 'R', 'W', 'A', 'G', 'M', 'Y', 'F', 'P', 'D', 'X', 'B', 'N', 'J', 'Z', 'S', 'Q', 'V', 'H', 'L', 'C', 'K', 'E' };

            int divisor = 23;
            int operacion = dniCliente % divisor;

            int posicionResto = resto[operacion];

            if (letraCliente == letras[posicionResto])
            {

                Console.WriteLine("El dni ingresado es válido");
                dniBuscar = dniCliente;
            }
            else
            {
                Console.WriteLine("La letra del dni ingresado no coincide con algun dni valido");
            }
            return dniBuscar;
        }
    }
}
