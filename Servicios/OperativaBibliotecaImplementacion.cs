using ejercicioGlobal.Dtos;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        private void mostrarListaBibliotecas(List<BibliotecasDto> listaBiblio)
        {
            Console.WriteLine("Lista de bibliotecas");
            foreach (BibliotecasDto biblioteca in listaBiblio)
            {
                Console.WriteLine(biblioteca.ToString());
            }
        }
       
        public void darAltaCliente(List<ClientesDto>listaClientes, List<BibliotecasDto>listaBibliotecas)
        {
           
            Console.WriteLine("Introduzca el id de la biblioteca en la cual desea dar alta al cliente");
            mostrarListaBibliotecas(listaBibliotecas);
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
