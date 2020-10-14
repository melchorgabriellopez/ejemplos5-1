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
            int Salir = 0;
            while (Salir == 0)
            {
                Console.Clear();
                Console.WriteLine("Menu");
                Console.WriteLine("___________________________");
                Console.WriteLine("ALta alumno ..............1");
                Console.WriteLine("Borrar todos alumnos......2");
                Console.WriteLine("Borrar alumno.............3");
                Console.WriteLine("Modificar alumno..........4");
                Console.WriteLine("Listar alumno ............5");
                Console.WriteLine("Alta Materia .............6");
                Console.WriteLine("Borar todas las materias..7");
                Console.WriteLine("Borrar Materia............8");
                Console.WriteLine("Modificar materia.........9");
                Console.WriteLine("Listar Materia...........10");
                Console.WriteLine("Salir  ...................0");
                Console.WriteLine("____________________________");
                Console.Write("Opcion =>           ");
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
                        BaseDatos.BorrarListaAlumno();
                        Console.WriteLine("Se borro la lista correctamente...");
                        Console.ReadKey();
                        break;
                    case 3:
                        borrarAlumno();
                        break;
                    case 4:
                        actualizarAlumno();
                        break;    
                    case 5:
                        Listar();
                        break;
                    case 6:
                        GuardarMateria();
                        break;                   
                    case 7:
                        BaseDatos.BorrarListaMateria();
                        Console.WriteLine("Se borro la lista correctamente...");
                        Console.ReadKey();
                        break;          
                    case 8:
                        BorrarMateria();
                        break;
                   
                    case 9:
                        ActualizarMateria();
                        break;   
                    case 10:
                        ListarMaterias();
                        break;
                    default:
                        break;
                }

            }
        }
        private static void ActualizarMateria()
        {
             Console.Clear();
            Console.WriteLine("Borrar materia");
            Console.WriteLine("_________________________");

            Materia materia = new Materia();
            Console.WriteLine("Codigo");
            var Codigo = int.Parse(Console.ReadLine());

            Console.WriteLine("Nombre");
            materia.Nombre=Console.ReadLine();  

            BaseDatos.Actualizar(Codigo,materia);


            Console.WriteLine("_________________________");
            Console.WriteLine("Se modifico correctamente");
            Console.ReadKey();
        }
        private static void BorrarMateria()
        {
           Console.Clear();
            Console.WriteLine("Borrar materia");
            Console.WriteLine("_________________________");
            Console.WriteLine("Codigo");
            var Codigo = int.Parse(Console.ReadLine());

            BaseDatos.BorrarMateria(Codigo);

            Console.WriteLine("_________________________");
            Console.WriteLine("Se borro correctamente");
            Console.ReadKey();
        }
        private static void actualizarAlumno()
        {
            Console.Clear();
            Console.WriteLine("Borrar alumno");
            Console.WriteLine("_________________________");

            Alumno alumno = new Alumno();
            Console.WriteLine("Codigo");
            var Codigo = int.Parse(Console.ReadLine());

            Console.WriteLine("Nombre");
            alumno.Nombre=Console.ReadLine();  

            BaseDatos.Actualizar(Codigo,alumno);


            Console.WriteLine("_________________________");
            Console.WriteLine("Se modifico correctamente");
            Console.ReadKey();
        }
        private static void borrarAlumno()
        {
            Console.Clear();
            Console.WriteLine("Borrar alumno");
            Console.WriteLine("_________________________");
            Console.WriteLine("Codigo");
            var Codigo = int.Parse(Console.ReadLine());

            BaseDatos.BorrarAlumno(Codigo);

            Console.WriteLine("_________________________");
            Console.WriteLine("Se borro correctamente");
            Console.ReadKey();

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
