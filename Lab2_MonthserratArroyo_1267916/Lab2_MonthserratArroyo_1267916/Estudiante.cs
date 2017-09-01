using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_MonthserratArroyo_1267916
{
    /// <summary>
    /// Clase estudiante para el laboratorio número 2
    /// </summary>
    public class Estudiante
    {

        public string NombreEstudiante { get; set; }
        public bool GeneroEstudiante { get; set; }
   /// <summary>
   /// Constructor de la clase estudiante
   /// </summary>
   /// <param name="nombre">Nombre del estudiante</param>
   /// <param name="genero">Genero del estudiante, false para hombre, true para mujer</param>
        public Estudiante(string nombre, bool genero)
        {
            
            NombreEstudiante = nombre;
            GeneroEstudiante = genero;
            
            
        }
    }
}
