using System.Collections.Generic;
using System;
using System.Linq;

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

      public static void BorrarListaAlumno()
      {

          TablaAlumnos.Clear();
       
      }    

     public static void BorrarListaMateria()
     {
         TablaMaterias.Clear();
     }  


      public static void BorrarAlumno(int id)
      {
          var borrar= TablaAlumnos.Where(a=> a.Id==id).FirstOrDefault();
          TablaAlumnos.Remove(borrar);
      }

      public static void BorrarMateria(int id) 
      {
          var borrar =TablaMaterias.Where(x=> x.IdMateria==id).FirstOrDefault();
          TablaMaterias.Remove(borrar);       
      }  


     public static void Actualizar(int id ,Alumno alumno)
     {
         var actualizar = TablaAlumnos.Where(x=>x.Id==id).FirstOrDefault();

         actualizar.Nombre=alumno.Nombre;
         actualizar.FechaNacimiento=alumno.FechaNacimiento;
         actualizar.Activo=alumno.Activo;
         actualizar.Sexo=alumno.Sexo;

     }           

     public static void Actualizar(int id,Materia materia)
     {
       var actualizar= TablaMaterias.Where(x=> x.IdMateria==id).FirstOrDefault();
       actualizar.Nombre=materia.Nombre;
     }  

    }
}