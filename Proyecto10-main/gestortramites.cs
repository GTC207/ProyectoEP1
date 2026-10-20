using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace TAREA11
{
    public class gestortramites
    {
        public tramites[] Tramites = new tramites[50];
        public int cantidad = 0;
        public void Registrar()
        {
            string respuesta;
            if (cantidad < Tramites.Length)
            {
                Console.Clear();
                Console.WriteLine("\n================================");
                Console.WriteLine("=== REGISTRO DE NUEVO ALUMNO ===");
                Console.WriteLine("================================\n");
                Console.Write("\nCodigo del nuevo alumno: ");
                string codigoAlumno = Console.ReadLine();
                if (codigoAlumno.Length < 9)
                {
                    Console.WriteLine("Ingrese un codigo de 9 digitos!");
                    Console.WriteLine("Presiones cualquier tecla para continuar...");
                    Console.ReadKey();
                    Registrar();
                    return;
                }
                Console.Write("\nDNI del apoderado: ");
                int dni = int.Parse(Console.ReadLine());
                if (dni.ToString().Length != 8)
                {
                    Console.WriteLine("\nIngrese un DNI valido!");
                    Console.WriteLine("\nPresiones cualquier tecla para continuar...");
                    Console.ReadKey();
                    Registrar();
                    return;
                }
                Console.Write("\nPrimer nombre del alumno: ");
                string NombreAlumno = Console.ReadLine();
                Console.Write("\nApellidos del alumno: ");
                string ApellidoAlumno = Console.ReadLine();
                //Formato de los apellidos
                int espacio = ApellidoAlumno.IndexOf(' ');
                string apellido1 = ApellidoAlumno.Substring(0, espacio);
                string apellido2 = ApellidoAlumno.Substring(espacio + 1);

                apellido1 = char.ToUpper(apellido1[0]) + apellido1.Substring(1);
                apellido2 = char.ToUpper(apellido2[0]) + apellido2.Substring(1);

                string ApellidosFormateados = apellido1 + " " + apellido2;
                //

                Console.Write("\nProfesor o Tutor: ");
                string p_name = Console.ReadLine();
                //Formato al nombre del profesor
                int space = p_name.IndexOf(' ');
                string p_name1 = p_name.Substring(0, space);
                string p_name2 = p_name.Substring(space + 1);

                p_name1 = char.ToUpper(p_name1[0]) + p_name1.Substring(1);
                p_name2 = char.ToUpper(p_name2[0]) + p_name2.Substring(1);

                string ProfesorFormateado = p_name1 + " " + p_name2;
                //
                Console.Write("\nGrado: ");
                string Grado = Console.ReadLine();
                Console.Write("\nSeccion: ");
                string Seccion = Console.ReadLine();
                Console.Write("\nNota: ");
                double nota = Convert.ToDouble(Console.ReadLine());
                if(nota < 0 || nota > 20)
                {
                    Console.WriteLine("\nIngrese una nota valida! <0-20>");
                    Console.WriteLine("\nPresione cualquier tecla para continuar...");
                    Console.ReadKey();
                    Console.Clear();
                    Registrar();
                    return;
                }

                Tramites[cantidad] = new tramites(codigoAlumno.ToUpper(),dni, char.ToUpper(NombreAlumno[0])+NombreAlumno.Substring(1),ApellidosFormateados, ProfesorFormateado, Grado.ToLower(),Seccion.ToUpper(),nota);
                cantidad++;
                Console.WriteLine("\nTramite registrado");

                Console.Write("\nDesea registrar otro alumno? (S/N) : ");
                respuesta = Console.ReadLine();
                if(respuesta.ToUpper() == "S")
                {
                    Registrar();
                }else
                {
                    return;
                }
                
            }
            else
            {
                Console.WriteLine("\nCapacidad máxima alcanzada");
                Console.WriteLine("\nPresione cualquier tecla para continuar...");
                Console.ReadKey();
                return;

            }
        }
        public void Mostrar()
        {
            
            if (cantidad == 0)
            {
                Console.WriteLine("\nNo existen trámites para mostrar.. : :D");
                Console.WriteLine("\nPresione cualquier tecla para continuar...");
                Console.ReadKey();
                return;
            }
            Console.Clear();
            Console.WriteLine("\n=================");
            Console.WriteLine("LISTA DE TRAMITES");
            Console.WriteLine("=================\n");
            for (int i = 0; i < cantidad; i++)
            {
                Console.WriteLine($"\nCodigo Alumno : {Tramites[i].CodigoAlumno}");
                Console.WriteLine($"\nCodigo Alumno : {Tramites[i].CodigoAlumno}");
                Console.WriteLine($"\n\tNombre : {Tramites[i].NombreAlumno} {Tramites[i].ApellidosAlumno}");
                Console.WriteLine($"\n\tDNI de apoderado: {Tramites[i].DNI}");
                Console.WriteLine($"\n\tProfesor o tutor: {Tramites[i].TutorProfesor}");
                Console.WriteLine($"\n\tGrado : {Tramites[i].Grado}\t|| Seccion : {Tramites[i].Seccion}");
                Console.WriteLine($"\n\tNotas : {Tramites[i].Notas}");
            }
            Console.WriteLine("\nPresione cualquier tecla para continuar...");
            Console.ReadKey();
            Console.Clear();
            return;
        }
        public void ModificarRegistro()
        {
            string respuesta;
            Console.Clear();
            Console.WriteLine("\n=================================");
            Console.WriteLine("=== MODIFICACION DE REGISTROS ===");
            Console.WriteLine("=================================\n");
            Console.Write("Ingrese codigo del estudiante a modificar: ");
            string code = Console.ReadLine();
            for(int i = 0;i  < cantidad; i++)
            {
                if (Tramites[i].CodigoAlumno.Equals(code))
                {
                    Console.WriteLine("\nTrámite localizado: ");
                    Console.WriteLine($"\nCodigo Alumno : {Tramites[i].CodigoAlumno}");
                    Console.WriteLine($"\n\tNombre : {Tramites[i].NombreAlumno} {Tramites[i].ApellidosAlumno}");
                    Console.WriteLine($"\n\tDNI de apoderado: {Tramites[i].DNI}");
                    Console.WriteLine($"\n\tProfesor o tutor: {Tramites[i].TutorProfesor}");
                    Console.WriteLine($"\n\tGrado : {Tramites[i].Grado}\t|| Seccion : {Tramites[i].Seccion}");
                    Console.WriteLine($"\n\tNotas : {Tramites[i].Notas}");
                    Console.WriteLine("\nDesea continuar? (S/N) : ");
                    respuesta = Console.ReadLine();
                    if (respuesta.ToUpper() == "S")
                    {
                        Console.WriteLine("\nQue desea modificar?");
                        Console.WriteLine("\n1. Nombre");
                        Console.WriteLine("\n2. Apellidos");
                        Console.WriteLine("\n3. DNI del apoderado");
                        Console.WriteLine("\n4. Tutor a cargo");
                        Console.WriteLine("\n5. Grado");
                        Console.WriteLine("\n6. Seccion");
                        Console.WriteLine("\n7. Notas");
                        Console.WriteLine("\n8. Volver al inicio");
                        Console.Write("\nIngrese una opcion: ");
                        int _ = int.Parse(Console.ReadLine());
                        switch (_)
                        {
                            case 1:
                                Console.WriteLine("\nIngrese nuevo nombre: ");
                                string n_name = Console.ReadLine();
                                Tramites[i].NombreAlumno = n_name;
                                Console.WriteLine("\nNombre cambiado con exito!");
                                Console.WriteLine("\nPresione cualquier tecla para continuar...");
                                Console.ReadKey();
                                Console.Clear();
                                break;
                            case 2:
                                Console.WriteLine("\nIngrese nuevos apellidos: ");
                                string nl_name = Console.ReadLine();
                                Tramites[i].ApellidosAlumno = nl_name;
                                Console.WriteLine("\nApellidos cambiados con exito!");
                                Console.WriteLine("\nPresione cualquier tecla para continuar...");
                                Console.ReadKey();
                                Console.Clear();
                                break;
                            case 3:
                                Console.WriteLine("\nIngrese nuevo DNI: ");
                                int n_dni = int.Parse(Console.ReadLine());
                                Tramites[i].DNI = n_dni;
                                Console.WriteLine("\nDNI cambiado con exito!");
                                Console.WriteLine("\nPresione cualquier tecla para continuar...");
                                Console.ReadKey();
                                Console.Clear();
                                break;
                            case 4:
                                Console.WriteLine("\nIngrese nuevo tutor: ");
                                string n_tutor = Console.ReadLine();
                                Tramites[i].TutorProfesor = n_tutor;
                                Console.WriteLine("\nNombre cambiado con exito!");
                                Console.WriteLine("\nPresione cualquier tecla para continuar...");
                                Console.ReadKey();
                                Console.Clear();
                                break;
                            case 5:
                                Console.WriteLine("\nIngrese nuevo grado: ");
                                string n_grade = Console.ReadLine();
                                Tramites[i].Grado = n_grade;
                                Console.WriteLine("\nNombre cambiado con exito!");
                                Console.WriteLine("\nPresione cualquier tecla para continuar...");
                                Console.ReadKey();
                                Console.Clear();
                                break;
                            case 6:
                                Console.WriteLine("\nIngrese nueva seccion: ");
                                string n_section = Console.ReadLine();
                                Tramites[i].Seccion = n_section;
                                Console.WriteLine("\nNombre cambiado con exito!");
                                Console.WriteLine("\nPresione cualquier tecla para continuar...");
                                Console.ReadKey();
                                Console.Clear();
                                break;
                            case 7:
                                Console.WriteLine("\nIngrese nueva nota: ");
                                double n_note = int.Parse(Console.ReadLine());
                                Tramites[i].Notas = n_note;
                                Console.WriteLine("\nNombre cambiado con exito!");
                                Console.WriteLine("\nPresione cualquier tecla para continuar...");
                                Console.ReadKey();
                                Console.Clear();
                                break;
                            case 8:
                                Console.Clear();
                                return;
                            default:
                                Console.WriteLine("\nIngrese una opcion valida! <1-8>");
                                Console.WriteLine("\nPresione cualquier tecla para continuar...");
                                Console.ReadKey();
                                Console.Clear();
                                ModificarRegistro();
                                return;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Desea volver al menu inicial? (S/N) :");
                        respuesta = Console.ReadLine();
                        if(respuesta.ToUpper() == "S")
                        {
                            Console.Clear();
                            return;
                        }
                        else
                        {
                            Console.Clear();
                            ModificarRegistro();
                            return;
                        }
                    }
                }
                

            }
        }

        public void EliminarRegistro()
        {
            string respuesta;
            Console.Clear();
            Console.WriteLine("\n=================================");
            Console.WriteLine("=== ELIMINACION DE REGISTROS ===");
            Console.WriteLine("=================================\n");
            Console.Write("Ingrese codigo del estudiante a modificar: ");
            string code = Console.ReadLine();
            for (int i = 0; i < cantidad; i++)
            {
                if (Tramites[i].CodigoAlumno.Equals(code))
                {
                    Console.WriteLine("\nTrámite localizado: ");
                    Console.WriteLine($"\nCodigo Alumno : {Tramites[i].CodigoAlumno}");
                    Console.WriteLine($"\n\tNombre : {Tramites[i].NombreAlumno} {Tramites[i].ApellidosAlumno}");
                    Console.WriteLine($"\n\tDNI de apoderado: {Tramites[i].DNI}");
                    Console.WriteLine($"\n\tProfesor o tutor: {Tramites[i].TutorProfesor}");
                    Console.WriteLine($"\n\tGrado : {Tramites[i].Grado}\t|| Seccion : {Tramites[i].Seccion}");
                    Console.WriteLine($"\n\tNotas : {Tramites[i].Notas}");
                    Console.WriteLine("\nDesea continuar? (S/N) : ");
                    respuesta = Console.ReadLine();
                    if (respuesta.ToUpper() == "S")
                    {
                        for(int j = i; j < cantidad - 1; j++)
                        {
                            Tramites[j] = Tramites[j + 1];
                        }
                        Tramites[cantidad - 1] = null;
                        cantidad--;
                        Console.WriteLine("Alumno eliminaod con exito!");
                        Console.WriteLine("Presione cualquier tecla para continuar...");
                        Console.ReadKey();
                        Console.Clear();
                        return;
                    }
                }
            }
        }
        public void BuscarPorCodigoAlumno(string codigo)
        {
            string respuesta;
            Console.Clear();
            for (int i = 0; i < cantidad; i++)
            {
                if (Tramites[i].CodigoAlumno.Equals(char.ToUpper(codigo[0]) + codigo.Substring(1)))
                {
                    Console.WriteLine("\nTrámite localizado: ");
                    Console.WriteLine($"\nCodigo Alumno : {Tramites[i].CodigoAlumno}");
                    Console.WriteLine($"\n\tNombre : {Tramites[i].NombreAlumno} {Tramites[i].ApellidosAlumno}");
                    Console.WriteLine($"\n\tDNI de apoderado: {Tramites[i].DNI}");
                    Console.WriteLine($"\n\tProfesor o tutor: {Tramites[i].TutorProfesor}");
                    Console.WriteLine($"\n\tGrado : {Tramites[i].Grado}\t|| Seccion : {Tramites[i].Seccion}");
                    Console.WriteLine($"\n\tNotas : {Tramites[i].Notas}");
                    //Mostrar();
                    Console.WriteLine("\nDesea buscar otro alumno? (S/N) :");
                    respuesta = Console.ReadLine();
                    if (respuesta.ToUpper() == "S")
                    {
                        buscar();
                        return;
                    }
                    else
                    {
                        Console.Clear();
                        return;
                    }
                    
                }
            }
            Console.WriteLine("No se encontraron resultados");
            Console.WriteLine("\nDesea buscar otro alumno? (S/N) :");
            respuesta = Console.ReadLine();
            if (respuesta.ToUpper() == "S")
            {
                buscar();
                return;
            }
            else
            {
                Console.Clear();
                return;
            }
        }

        public void BuscarPorNombre(string nombre)
        {
            string respuesta;
            Console.Clear();
            for (int i = 0; i < cantidad; i++)
            {
                if (Tramites[i].NombreAlumno.Equals(char.ToUpper(nombre[0]) + nombre.Substring(1)))
                {
                    Console.WriteLine("\nTrámite localizado: ");
                    Console.WriteLine($"\nCodigo Alumno : {Tramites[i].CodigoAlumno}");
                    Console.WriteLine($"\n\tNombre : {Tramites[i].NombreAlumno} {Tramites[i].ApellidosAlumno}");
                    Console.WriteLine($"\n\tDNI de apoderado: {Tramites[i].DNI}");
                    Console.WriteLine($"\n\tProfesor o tutor: {Tramites[i].TutorProfesor}");
                    Console.WriteLine($"\n\tGrado : {Tramites[i].Grado}\t|| Seccion : {Tramites[i].Seccion}");
                    Console.WriteLine($"\n\tNotas : {Tramites[i].Notas}");

                    Console.WriteLine("\nDesea buscar otro alumno? (S/N) :");
                    respuesta = Console.ReadLine();
                    if (respuesta.ToUpper() == "S")
                    {
                        buscar();
                        return;
                    }
                    else
                    {
                        Console.Clear();
                        return;
                    }
                }

            }
            Console.WriteLine("No se encontraron resultados");
            Console.WriteLine("\nDesea buscar otro alumno? (S/N) :");
            respuesta = Console.ReadLine();
            if (respuesta.ToUpper() == "S")
            {
                buscar();
                return;
            }
            else
            {
                Console.Clear();
                return;
            }
        }

        public void BuscarPorApellidos(string l_name)
        {
            string respuesta;
            Console.Clear();
            for (int i = 0; i < cantidad; i++)
            {
                if (Tramites[i].ApellidosAlumno.Contains(char.ToUpper(l_name[0]) + l_name.Substring(1)))
                {
                    Console.WriteLine("\nTrámite localizado: ");
                    Console.WriteLine($"\nCodigo Alumno : {Tramites[i].CodigoAlumno}");
                    Console.WriteLine($"\n\tNombre : {Tramites[i].NombreAlumno} {Tramites[i].ApellidosAlumno}");
                    Console.WriteLine($"\n\tDNI de apoderado: {Tramites[i].DNI}");
                    Console.WriteLine($"\n\tProfesor o tutor: {Tramites[i].TutorProfesor}");
                    Console.WriteLine($"\n\tGrado : {Tramites[i].Grado}\t|| Seccion : {Tramites[i].Seccion}");
                    Console.WriteLine($"\n\tNotas : {Tramites[i].Notas}");

                    Console.WriteLine("\nDesea buscar otro alumno? (S/N) :");
                    respuesta = Console.ReadLine();
                    if (respuesta.ToUpper() == "S")
                    {
                        buscar();
                        return;
                    }
                    else
                    {
                        Console.Clear();
                        return;
                    }
                }
            }
            Console.WriteLine("No se encontraron resultados");
            Console.WriteLine("\nDesea buscar otro alumno? (S/N) :");
            respuesta = Console.ReadLine();
            if (respuesta.ToUpper() == "S")
            {
                buscar();
                return;
            }
            else
            {
                Console.Clear();
                return;
            }
        }

        public void BuscarPorProfesor(string profe)
        {
            string respuesta;
            Console.Clear();
            for (int i = 0; i < cantidad; i++)
            {
                if (Tramites[i].TutorProfesor.Contains(char.ToUpper(profe[0]) + profe.Substring(1)))
                {
                    Console.WriteLine("\nTrámite localizado: ");
                    Console.WriteLine($"\nCodigo Alumno : {Tramites[i].CodigoAlumno}");
                    Console.WriteLine($"\n\tNombre : {Tramites[i].NombreAlumno} {Tramites[i].ApellidosAlumno}");
                    Console.WriteLine($"\n\tDNI de apoderado: {Tramites[i].DNI}");
                    Console.WriteLine($"\n\tProfesor o tutor: {Tramites[i].TutorProfesor}");
                    Console.WriteLine($"\n\tGrado : {Tramites[i].Grado}\t|| Seccion : {Tramites[i].Seccion}");
                    Console.WriteLine($"\n\tNotas : {Tramites[i].Notas}");

                    Console.WriteLine("\nDesea buscar otro alumno? (S/N) :");
                    respuesta = Console.ReadLine();
                    if (respuesta.ToUpper() == "S")
                    {
                        buscar();
                        return;
                    }
                    else
                    {
                        Console.Clear();
                        return;
                    }
                }
            }
            Console.WriteLine("No se encontraron resultados");
            Console.WriteLine("\nDesea buscar otro alumno? (S/N) :");
            respuesta = Console.ReadLine();
            if (respuesta.ToUpper() == "S")
            {
                buscar();
                return;
            }
            else
            {
                Console.Clear();
                return;
            }
        }

        public void BuscarPorNota(double nota)
        {
            string respuesta;
            Console.Clear();
            for (int i = 0; i < cantidad; i++)
            {
                if (Tramites[i].Notas.Equals(nota))
                {
                    Console.WriteLine("\nTrámite localizado: ");
                    Console.WriteLine($"\nCodigo Alumno : {Tramites[i].CodigoAlumno}");
                    Console.WriteLine($"\n\tNombre : {Tramites[i].NombreAlumno} {Tramites[i].ApellidosAlumno}");
                    Console.WriteLine($"\n\tDNI de apoderado: {Tramites[i].DNI}");
                    Console.WriteLine($"\n\tProfesor o tutor: {Tramites[i].TutorProfesor}");
                    Console.WriteLine($"\n\tGrado : {Tramites[i].Grado}\t|| Seccion : {Tramites[i].Seccion}");
                    Console.WriteLine($"\n\tNotas : {Tramites[i].Notas}");

                    Console.WriteLine("\nDesea buscar otro alumno? (S/N) :");
                    respuesta = Console.ReadLine();
                    if (respuesta.ToUpper() == "S")
                    {
                        buscar();
                        return;
                    }
                    else
                    {
                        Console.Clear();
                        return;
                    }
                }

            }
            Console.WriteLine("No se encontraron resultados");
            Console.WriteLine("\nDesea buscar otro alumno? (S/N) :");
            respuesta = Console.ReadLine();
            if (respuesta.ToUpper() == "S")
            {
                buscar();
                return;
            }
            else
            {
                Console.Clear();
                return;
            }
        }
        public void buscar()
        {
            Console.Clear();
            Console.WriteLine("\n=====================");
            Console.WriteLine("=== BUSCAR ALUMNO ===");
            Console.WriteLine("=====================\n");
            Console.WriteLine("1. Buscar por codigo");
            Console.WriteLine("\n2. Buscar por nombre");
            Console.WriteLine("\n3. Buscar por apellidos");
            Console.WriteLine("\n4. Buscar por tutos o profesor");
            Console.WriteLine("\n5. Buscar por nota");
            Console.WriteLine("\n6. Volver al menu");
            Console.Write("\nIngrese una opcion: ");
            int _ = int.Parse(Console.ReadLine());
            switch (_)
            {
                case 1:
                    Console.Write("\nIngrese el codigo del alumno a buscar: ");
                    string codigo = Console.ReadLine();
                    BuscarPorCodigoAlumno(codigo);
                    break;
                case 2:
                    Console.Write("\nIngrese el nombre del alumno a buscar: ");
                    string name = Console.ReadLine();
                    BuscarPorNombre(name);
                    break;
                case 3:
                    Console.Write("\nIngrese el apellido del alumno a buscar: ");
                    string l_name = Console.ReadLine();
                    BuscarPorApellidos(l_name);
                    break;
                case 4:
                    Console.Write("\nIngrese nombre del tutor o profesor del alumno a buscar: ");
                    string proffesor = Console.ReadLine();
                    BuscarPorProfesor(proffesor);
                    break;
                case 5:
                    Console.WriteLine("\nIngrese la nota del alumno a buscar: ");
                    double note = int.Parse(Console.ReadLine());
                    BuscarPorNota(note);
                    break;
                case 6:
                    Console.Clear();
                    return;
                default:
                    Console.WriteLine("Debe ingresar una opcion valida! <1-5>");
                    Console.WriteLine("Presione cualquier tecla para continuar...");
                    Console.ReadKey();
                    Console.Clear();
                    break;
            }

            
        }
        public void OrdenamientoBurbuja()
        {
            for (int i = 0; i < cantidad; i++)
            {
                for (int j = 0; j < cantidad - 1 - i; j++)
                {
                    if (Tramites[j].Notas > Tramites[j + 1].Notas)
                    {
                        tramites aux = Tramites[j];
                        Tramites[j] = Tramites[j + 1];
                        Tramites[j + 1] = aux;

                    }
                }
            }
            Console.WriteLine("Tramites ordenados por burbuja");
        }

        public void OrdenamientoSeleccion()
        {
            for (int i = 0; i < cantidad - 1; i++)
            {
                int menor = i;

                for (int j = i + 1; j < cantidad; j++)
                {
                    if (Tramites[j].Notas < Tramites[menor].Notas)
                    {
                        menor = j;
                    }
                }
                tramites aux = Tramites[i];
                Tramites[i] = Tramites[menor];
                Tramites[menor] = aux;

                Console.WriteLine("Tramites ordenados por Seleccion");
            }
        }

        public void MayorNota()
        {

            if (cantidad == 0)
            {
                Console.WriteLine("No existen tramites registrados.");
                return;
            }

            double mayor = Tramites[0].Notas;

            for (int i = 1; i < cantidad; i++)
            {
                if (Tramites[i].Notas > mayor)
                {
                    mayor = Tramites[i].Notas;
                }
            }

            for (int i = 0; i < cantidad; i++)
            {
                if (Tramites[i].Notas == mayor)
                {
                    Console.WriteLine("\nREGISTRO DE LA MAYOR NOTA");
                    Console.WriteLine($"CodigoAlumno: {Tramites[i].CodigoAlumno}");
                    Console.WriteLine($"NombreAlumno: {Tramites[i].NombreAlumno}");
                    Console.WriteLine($"Grado: {Tramites[i].Grado}");
                    Console.WriteLine($"Seccion: {Tramites[i].Seccion}");
                    Console.WriteLine($"Notas: {Tramites[i].Notas}");
                }
            }
            Console.WriteLine("Presione cualquier tecla para continuar...");
            Console.ReadKey();
            Console.Clear();
            return;
        }
        public void ImpresionTramite()
        {
            string respuesta;
            Console.Write("\nIngrese codigo del alumno: ");
            string code = Console.ReadLine();
            Console.Clear();
            for(int i = 0;i< cantidad; i++)
            {
                if(Tramites[i].CodigoAlumno.Equals(char.ToUpper(code[0]) + code.Substring(1)))
                {
                    Console.WriteLine("=====================================================================");
                    Console.WriteLine("===================== Estrellitas de Fátima =========================");
                    Console.WriteLine("=====================================================================");
                    Console.WriteLine($"Estudiante: {Tramites[i].NombreAlumno} {Tramites[i].ApellidosAlumno}\n");
                    Console.WriteLine($"DNI del apoderado: {Tramites[i].DNI}");
                    Console.WriteLine("---------------------------------------------------------------------");
                    Console.WriteLine($"\nDocente a cargo:{Tramites[i].TutorProfesor}");
                    Console.WriteLine("---------------------------------------------------------------------");
                    Console.WriteLine($"\nGrado: {Tramites[i].Grado}\t||  Seccion: {Tramites[i].Seccion}");
                    Console.WriteLine("---------------------------------------------------------------------");
                    Console.WriteLine($"Estimado(a) apoderado(a)\nNos complace informar que el estudiante {Tramites[i].NombreAlumno} {Tramites[i].ApellidosAlumno} ha obtenido una calificación de {Tramites[i].Notas}. Este resultado \nrefleja su esfuerzo, dedicación y compromiso con sus actividades académicas.\n\nFelicitamos al estudiante por este importante logro y reconocemos el apoyo constante de su familia en su proceso de \naprendizaje. \n\nConfiamos en que continuará desarrollando sus capacidades, alcanzando nuevas metas y superándose día a día.\n\nLe animamos a seguir manteniendo el entusiasmo, la responsabilidad y la perseverancia que le permitirán continuar \ncreciendo tanto académica como personalmente.");
                    Console.WriteLine("\n\nPresione cualquier tecla para continuar...");
                    Console.ReadKey();
                    Console.Clear();
                    return;
                }
            }
            Console.WriteLine("No se encontraron resultados");
            Console.WriteLine("\nDesea buscar otro alumno? (S/N) :");
            respuesta = Console.ReadLine();
            if (respuesta.ToUpper() == "S")
            {
                ImpresionTramite();
                return;
            }
            else
            {
                Console.Clear();
                return;
            }
        }
    }
}