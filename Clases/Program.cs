using System;
using System.Collections.Generic;
using Enumeradores;

namespace Clases
{
    class Program
    {
        static void Main(string[] args)
        {
            Alumno alumno = new Alumno();
            alumno.Id = 1;
            alumno.Nombre = "Pedro Perez";
            alumno.Sexo = Sexo.Hombre;
            alumno.FechaNacimiento = DateTime.Now;

            Alumno alumno2 = new Alumno(2, "Maria Mercedez", Sexo.Mujer);
            Console.WriteLine($"{alumno.Nombre} {alumno.FechaNacimiento}");

            List<Alumno> alumnos = new List<Alumno>();

            alumnos.Add(new Alumno { Id = 0, Nombre = "Pedro perez", FechaNacimiento = DateTime.Parse("25/01/1979"), Sexo = Sexo.Hombre });
            alumnos.Add(new Alumno { Id = 1, Nombre = "Pedro perez", FechaNacimiento = DateTime.Parse("25/01/1979"), Sexo = Sexo.Hombre });
            alumnos.Add(new Alumno { Id = 2, Nombre = "Pedro perez", FechaNacimiento = DateTime.Parse("25/01/1979"), Sexo = Sexo.Hombre });
            alumnos.Add(new Alumno { Id = 3, Nombre = "Pedro perez", FechaNacimiento = DateTime.Parse("25/01/1979"), Sexo = Sexo.Hombre });
            alumnos.Add(new Alumno { Id = 4, Nombre = "Pedro perez", FechaNacimiento = DateTime.Parse("25/01/1979"), Sexo = Sexo.Hombre });
            alumnos.Add(new Alumno { Id = 5, Nombre = "Pedro perez", FechaNacimiento = DateTime.Parse("25/01/1979"), Sexo = Sexo.Hombre });
            alumnos.Add(new Alumno { Id = 6, Nombre = "Pedro perez", FechaNacimiento = DateTime.Parse("25/01/1979"), Sexo = Sexo.Hombre });
            alumnos.Add(new Alumno { Id = 7, Nombre = "Pedro perez", FechaNacimiento = DateTime.Parse("25/01/1979"), Sexo = Sexo.Hombre });
            alumnos.Add(new Alumno { Id = 8, Nombre = "Pedro perez", FechaNacimiento = DateTime.Parse("25/01/1979"), Sexo = Sexo.Hombre });
            alumnos.Add(new Alumno { Id = 9, Nombre = "Pedro perez", FechaNacimiento = DateTime.Parse("25/01/1979"), Sexo = Sexo.Hombre });
             
             foreach(Alumno item in alumnos)
             {
                 Console.WriteLine($"{item.Id} {item.Nombre} {item.FechaNacimiento}");
             }

        }
    }
}
