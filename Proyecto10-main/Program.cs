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
                Console.WriteLine("\n1. Registrar alumno: ");
                Console.WriteLine("\n2. Mostrar todos los tramites registrados:");
                Console.WriteLine("\n3. Modificar registro de un alumno");
                Console.WriteLine("\n4. Ordenar los tramites por seccion utilizando el metodo burbuja:");
                Console.WriteLine("\n5. Ordenar los tramites por seccion utilizando el metodo Seleccion:");
                Console.WriteLine("\n6. Buscar tramites :");
                Console.WriteLine("\n7. Mostrar el registro de la mayor nota:");
                Console.WriteLine("\n8. Eliminar un registro");
                Console.WriteLine("\n9. Impresion de tramite");
                Console.WriteLine("\n10. Guardar en archivo de texto");
                Console.WriteLine("\n11. Cargar desde archivo de texto");
                Console.WriteLine("\n12. Guardar en archivo binario");
                Console.WriteLine("\n13. Cargar desde archivo binario");
                Console.WriteLine("\n14. Salir del programa:");
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
                        gestortramites.GuardarTexto("tramites.txt");
                        Console.WriteLine("Datos guardados en texto.");
                        break;
                    case 11:
                        gestortramites.LeerTexto("tramites.txt");
                        Console.WriteLine("Datos cargados desde texto.");
                        break;
                    case 12:
                        gestortramites.GuardarBinario("tramites.bin");
                        Console.WriteLine("Datos guardados en binario.");
                        break;
                    case 13:
                        gestortramites.LeerBinario("tramites.bin");
                        Console.WriteLine("Datos cargados desde binario.");
                        break;
                    case 14:
                        Console.WriteLine("\nFin de programa, hasta pronto!");
                        Console.WriteLine("Presione cualquier tecla para continuar...");
                        Console.ReadKey();
                        return;

                    default: 
                        Console.WriteLine("Error! Ingresar correctamente <1-14>");
                        break;



                }


            } while (op != 14);
        }
    }
}
