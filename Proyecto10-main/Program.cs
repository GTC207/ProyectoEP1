using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TAREA11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            gestortramites gestortramites = new gestortramites();
            int op = 0;
            
            do
            {
                Console.WriteLine("\n=================================================================");
                Console.WriteLine("********* REGISTRO DEL COLEGIO ESTRELLITA DE FATIMA *************");
                Console.WriteLine("=================================================================\n");
                Console.WriteLine("1. Registrar tramites: ");
                Console.WriteLine("\n2. Mostrar todos los tramites registrados:");
                Console.WriteLine("\n3. Ordenar los tramites por seccion utilizando el metodo burbuja:");
                Console.WriteLine("\n4. Ordenar los tramites por seccion utilizando el metodo Seleccion:");
                Console.WriteLine("\n5. Buscar tramites :");
                Console.WriteLine("\n6. mostrar el registro de la mayor nota:");
                Console.WriteLine("\n7. Salir del programa:");
                Console.WriteLine("\n================================================================");
                Console.Write("\nIngrese una opción: ");
                op = Convert.ToInt32(Console.ReadLine());
                switch (op)
                {
                    case 1:
                        gestortramites.Registrar();
                        Console.Clear();
                        break;
                    case 2:
                        
                        gestortramites.Mostrar();
                        Console.Clear();
                        break;
                    case 3:
                        gestortramites.OrdenamientoBurbuja();
                        gestortramites.Mostrar();
                        break;
                    case 4:
                        gestortramites.OrdenamientoSeleccion();
                        gestortramites.Mostrar();
                        break;
                    case 5: 
                        gestortramites.buscar();
                        break;

                    case 6:
                        gestortramites.MayorNota();
                        break;
                    case 7: 
                        Console.WriteLine("\nFin de progama, hasta pronto!");
                        Console.WriteLine("Presione cualquier tecla para continuar...");
                        Console.ReadKey();
                        return;
                        
                    default: 
                        Console.WriteLine("Error! Ingresar correctamente <1-8>");
                        break;



                }


            } while (op != 7);
        }
    }
}
