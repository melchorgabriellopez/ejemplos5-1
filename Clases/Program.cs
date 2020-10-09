using System;
using System.Collections.Generic;
using System.Linq;
using Enumeradores;

namespace Clases
{
    public class Program
    {

        static void Main(string[] args)
        {


            /*     Alumno alumno = new Alumno();
                 alumno.Id = 1;
                 alumno.Nombre = "Pedro Perez";
                 alumno.Sexo = Sexo.Hombre;
                 alumno.FechaNacimiento = DateTime.Now;

                 Alumno alumno2 = new Alumno(2, "Maria
                  Mercedez", Sexo.Mujer);
                // Console.WriteLine($"{alumno.Nombre} {alumno.FechaNacimiento}");

                 List<Alumno> alumnos = new List<Alumno>();

                 alumnos.Add(new Alumno { Id = 0, Nombre = "Pedro Perez", FechaNacimiento = DateTime.Parse("25/01/1979"), Sexo = Sexo.Hombre });
                 alumnos.Add(new Alumno { Id = 1, Nombre = "Maria Soto", FechaNacimiento = DateTime.Parse("25/01/1979"), Sexo = Sexo.Mujer,Activo=false });
                 alumnos.Add(new Alumno { Id = 2, Nombre = "Juan Hernandez", FechaNacimiento = DateTime.Parse("25/01/1979"), Sexo = Sexo.Hombre });
                 alumnos.Add(new Alumno { Id = 3, Nombre = "Carla Lopez", FechaNacimiento = DateTime.Parse("25/01/1979"), Sexo = Sexo.Mujer });
                 alumnos.Add(new Alumno { Id = 4, Nombre = "Fernando Soberanes", FechaNacimiento = DateTime.Parse("25/01/1979"), Sexo = Sexo.Hombre });
                 alumnos.Add(new Alumno { Id = 5, Nombre = "Jose Martinez", FechaNacimiento = DateTime.Parse("25/01/1979"), Sexo = Sexo.Hombre });
                 alumnos.Add(new Alumno { Id = 6, Nombre = "Fabio Ureta", FechaNacimiento = DateTime.Parse("25/01/1979"), Sexo = Sexo.Hombre });
                 alumnos.Add(new Alumno { Id = 7, Nombre = "Idelma Lopez", FechaNacimiento = DateTime.Parse("25/01/1979"), Sexo = Sexo.Mujer });
                 alumnos.Add(new Alumno { Id = 8, Nombre = "Idalia Parra", FechaNacimiento = DateTime.Parse("25/01/1979"), Sexo = Sexo.Mujer });
                 alumnos.Add(new Alumno { Id = 9, Nombre = "Israel Olivas", FechaNacimiento = DateTime.Parse("25/01/1979"), Sexo = Sexo.Hombre });

                  foreach(Alumno item in alumnos.Where(a=>a.Sexo==Sexo.Mujer && !a.Activo))
                  {
                      Console.WriteLine($"{item.Id} {item.Nombre} {item.FechaNacimiento} {item.Sexo}");
                  }

                var Materia= alumno.Materias[0].Nombre;
                var Profesor= alumno.Materias[0].Profesor ;  
0

     */
            int Salir = 0;




            while (Salir == 0)
            {
                Console.Clear();
                Console.WriteLine("Menu");
                Console.WriteLine("_____________________");
                Console.WriteLine("ALta alumno ........1");
                Console.WriteLine("Listar alumno ......2");
                Console.WriteLine("ALta Materia .......3");
                Console.WriteLine("Listar Materia......4");
                Console.WriteLine("Salir  .............0");
                Console.WriteLine("_____________________");

                int opcion = int.Parse(Console.ReadLine());
                switch (opcion)
                {
                    case 0:
                        Salir = 1;
                        break;
                    case 1:
                        Guardar();
                        break;
                    case 2:
                        Listar();
                        break;

                    case 3:
                        GuardarMateria();
                        break;
                    case 4:
                        ListarMaterias();
                        break;
                    default:
                        break;
                }

            }
        }

        private static void ListarMaterias()
        {
            Console.Clear();
            Console.WriteLine("Lista de materias");
            Console.WriteLine("_________________________");

            foreach (Materia item in BaseDatos.ListarMateria())
            {
                Console.WriteLine($"{item.IdMateria} - {item.Nombre}");
            }
            Console.WriteLine("_________________________");
            Console.WriteLine($"Total de registros: {BaseDatos.ListarMateria().Count}");
            Console.WriteLine("_________________________");
            Console.WriteLine("Precione una tecla para continuar...");
            Console.ReadKey();
        }

        private static void GuardarMateria()
        {
            Console.Clear();
            Console.WriteLine("Alta de materias");
            Console.WriteLine("_________________________");
            Materia materia = new Materia();

            Console.WriteLine("Codigo");
            materia.IdMateria = int.Parse(Console.ReadLine());

            Console.WriteLine("Nombre");
            materia.Nombre = Console.ReadLine();

            BaseDatos.Guardar(materia);

            Console.WriteLine("_________________________");
            Console.WriteLine("Se guardo correctamente");
            Console.ReadKey();


        }


        static void Guardar()
        {

            Console.Clear();
            Console.WriteLine("Alta de Alumnos");
            Console.WriteLine("_________________________");
            Alumno alumno = new Alumno();


            Console.WriteLine("Codigo:");
            alumno.Id = int.Parse(Console.ReadLine());

            Console.WriteLine("Nombre:");
            alumno.Nombre = Console.ReadLine();

            BaseDatos.Guardar(alumno);

            Console.WriteLine("_________________________");
            Console.WriteLine("Se guardo correctamente");
            Console.ReadKey();
        }

        static void Listar()
        {

            Console.Clear();
            Console.WriteLine("Lista de alumnos");
            Console.WriteLine("_________________________");
            foreach (Alumno item in BaseDatos.ListarAlumno())
            {
                Console.WriteLine($"{item.Id} {item.Nombre}");
            }
            Console.WriteLine("_________________________");
            Console.WriteLine($"Total de registros: {BaseDatos.ListarAlumno().Count}");
            Console.WriteLine("_________________________");
            Console.WriteLine("Precione una tecla para continuar...");
            Console.ReadKey();
        }


    }



}
