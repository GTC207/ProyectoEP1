using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using TAREA11;

public class ArchivoTramites
{
    //Creacion de la clase "ArchivoTramites"
    public void GuardarTexto(string ruta, tramites[] lista, int cantidad)
    {
        StreamWriter sw = new StreamWriter(ruta);
        for (int i = 0; i < cantidad; i++)
        {
            sw.WriteLine(lista[i].CodigoAlumno + ";" +
                         lista[i].DNI + ";" +
                         lista[i].NombreAlumno + ";" +
                         lista[i].ApellidosAlumno + ";" +
                         lista[i].TutorProfesor + ";" +
                         lista[i].Curso + ";" +
                         lista[i].Grado + ";" +
                         lista[i].Seccion + ";" +
                         lista[i].Notas);
        }
        sw.Close();
    }

    public int LeerTexto(string ruta, tramites[] lista)
    {
        for (int k = 0; k < lista.Length; k++)
        {
            lista[k] = null;
        }

        int cantidad = 0;
        StreamReader sr = new StreamReader(ruta);
        string linea;

        while ((linea = sr.ReadLine()) != null)
        {
            string[] datos = linea.Split(';');
            if (datos.Length < 9)
            {
                continue; // salta líneas vacías o incompletas
            }
            lista[cantidad] = new tramites(
                datos[0],
                datos[1],
                datos[2],
                datos[3],
                datos[4],
                datos[5],
                datos[6],
                Convert.ToDouble(datos[7]),
                datos [8]
            );
            cantidad++;
        }
        sr.Close();
        return cantidad;
    }

    public void GuardarBinario(string ruta, tramites[] lista)
    {
        BinaryFormatter bf = new BinaryFormatter();
        using (FileStream fs = new FileStream(ruta, FileMode.Create))
        {
            bf.Serialize(fs, lista);
        }
    }

    public tramites[] LeerBinario(string ruta)
    {
        BinaryFormatter bf = new BinaryFormatter();
        FileStream fs = new FileStream(ruta, FileMode.Open);
        tramites[] lista = (tramites[])bf.Deserialize(fs);
        fs.Close();
        return lista;
    }
}
