using System.Collections.Generic;

namespace Clases
{


     public static class BaseDatos
    {
          
          
             static List<Alumno> TablaAlumnos= new List<Alumno>();
             static List<Materia> TablaMaterias= new List<Materia>();            
               

        public static bool Guardar(Alumno alumno)
         {
             TablaAlumnos.Add(alumno);
             return true;
         }  
          public static bool Guardar(Materia materia)
         {
             TablaMaterias.Add(materia);
             return true;
         }  

       public static List<Alumno> ListarAlumno()
         {
             return TablaAlumnos;
         } 

       public static List<Materia> ListarMateria()
         {
             return TablaMaterias;
         } 


    }
}