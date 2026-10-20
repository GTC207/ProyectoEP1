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
                Console.WriteLine("\n==============================================================");
                Console.WriteLine("********* REGISTRO DEL NIDO ESTRELLITA DE FATIMA *************");
                Console.WriteLine("==============================================================\n");
                Console.WriteLine("1. Registrar tramite: ");
                Console.WriteLine("\n2. Mostrar todos los tramites registrados:");
                Console.WriteLine("\n3. Modificar registro de un alumno");
                Console.WriteLine("\n4. Ordenar los tramites por seccion utilizando el metodo burbuja:");
                Console.WriteLine("\n5. Ordenar los tramites por seccion utilizando el metodo Seleccion:");
                Console.WriteLine("\n6. Buscar tramites :");
                Console.WriteLine("\n7. Mostrar el registro de la mayor nota:");
                Console.WriteLine("\n8. Eliminar un registro");
                Console.WriteLine("\n9. Impresion de tramite");
                Console.WriteLine("\n10. Salir del programa:");
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
                        gestortramites.ModificarRegistro();
                        break;
                    case 4:
                        gestortramites.OrdenamientoBurbuja();
                        gestortramites.Mostrar();
                        break;
                    case 5:
                        gestortramites.OrdenamientoSeleccion();
                        gestortramites.Mostrar();
                        break;
                    case 6: 
                        gestortramites.buscar();
                        break;

                    case 7:
                        gestortramites.MayorNota();
                        break;
                    case 8:
                        gestortramites.EliminarRegistro();
                        break;
                    case 9:
                        gestortramites.ImpresionTramite();
                        break;
                    case 10: 
                        Console.WriteLine("\nFin de progama, hasta pronto!");
                        Console.WriteLine("Presione cualquier tecla para continuar...");
                        Console.ReadKey();
                        return;
                        
                    default: 
                        Console.WriteLine("Error! Ingresar correctamente <1-10>");
                        break;



                }


            } while (op != 9);
        }
    }
}
