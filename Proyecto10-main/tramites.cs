using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TAREA11
{
    public class tramites
    {
        public string CodigoAlumno { get; set; }
        public string NombreAlumno { get; set; }
        public string ApellidosAlumno { get; set;}
        public string TutorProfesor { get; set; }
        public string Grado { get; set; }
        public string Seccion { get; set; }
        public double Notas { get; set; }   

        public tramites(string codigoalumno, string nombrealumno,string apellidosalumno,string tutorprofesor, string grado, string seccion, double notas)
        {
            CodigoAlumno = codigoalumno;
            NombreAlumno = nombrealumno;
            ApellidosAlumno = apellidosalumno;
            TutorProfesor = tutorprofesor;
            Grado = grado;
            Seccion = seccion;
            Notas = notas;
        }
    }
}