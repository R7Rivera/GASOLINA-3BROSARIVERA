using _3_GASOLINA_FACTURA_CLIENTE.CLASES;
using System;

namespace _3_GASOLINA_FACTURA_CLIENTE
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;   
                Console.WriteLine("*****************Tercer Nivel Cía. Ltda.*******************\n");
                Console.WriteLine("*******************FACTURA********************************\n");
                Console.WriteLine("FECHA : MANTA, 10 DE NOVIEMBRE DEL 2019 " );
                Console.WriteLine("\n");
                CLIENTE datocliente = new CLIENTE("ROSA GUADALUPE", "RIVERA ALVARADO", "131453948-5", "CALLE 16 AVENIDA 32");
                GASOLINA calculogasolina = new GASOLINA("Extra", 10, 1.50);

            Console.WriteLine("Información del Cliente  :   \n");
            Console.WriteLine("\n");
                Console.WriteLine("     Apellidos: {0} \n     Nombres: {1} \n     Cédula: {2} \n     Dirección: {3}",
                        datocliente.APELLIDOS, datocliente.NOMBRES, datocliente.IDENTIFICACIONCLIENTE, datocliente.DIRECCION);
                Console.WriteLine("\n");


                Console.WriteLine("Información Gasolina :      \n");
                Console.WriteLine("     Tipo de gasolina: {0} \n     Cantidad de Galones: {1} \n     Precio: {2}",
                    calculogasolina.TIPOGASOLINA, calculogasolina.CANTGALONES, calculogasolina.PRECIODEVENTA);
                Console.WriteLine("\n");


                Console.WriteLine("\n");
                Console.WriteLine("     Subtotal: " + calculogasolina.TOTALDECOMPRA);
                Console.WriteLine("     Iva 12%: " + calculogasolina.IVA);
                Console.WriteLine("     Valor Final: " + calculogasolina.TOTALAPAGAR);
                Console.WriteLine("\n");


                Console.WriteLine("Información del Cliente :  \n");
                CLIENTE datocliente1 = new CLIENTE("GINGER CRISTHINA", "ALVARADO DELGADO ", "130722867-4 ", "Manta");
                GASOLINA calculogasolina1 = new GASOLINA("Super", 5, 2);

                
                Console.WriteLine("     Apellidos: {0} \n     Nombres: {1} \n     Cédula: {2} \n     Dirección: {3}",
                        datocliente1.APELLIDOS, datocliente1.NOMBRES, datocliente1.IDENTIFICACIONCLIENTE, datocliente1.DIRECCION);
                Console.WriteLine("\n");



                Console.WriteLine("Información Gasolina :   \n");
                Console.WriteLine("     Tipo de gasolina : {0} \n    cantidad de  Galones: {1} \n     Precio: {2}",
                    calculogasolina1.TIPOGASOLINA, calculogasolina1.CANTGALONES, calculogasolina1.PRECIODEVENTA);
                Console.WriteLine("\n");


                Console.WriteLine("FACTURA :     \n   ");
                Console.WriteLine("     Subtotal:$ " + calculogasolina1.TOTALDECOMPRA);
                Console.WriteLine("     Iva 12%:$ " + calculogasolina1.IVA);
                Console.WriteLine("     Valor Final: $" + calculogasolina1.TOTALAPAGAR);
                Console.ReadKey();
            }
        }
    }


