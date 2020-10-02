
using System;

namespace ejemplos5_1
{
    class Program
    {
        static void Main(string[] args)
        {

            //  [ambito] (tipo de dato) Nombre variable [valor];

            // public,private y protected

            //numero, caracateres, boleanos , objetos y de usuario
            //int  2.147.483.648 a 2.147.483.647, float,double, decimal,long ,short 32 768, byte 255,  
            //string
            //bool true o false

            // private int IdEmpleado = 1;
            /*
                        int IdAlumno;

                        string Nombre;

                        DateTime FechaNacimiento;

                        float Calificacion=1;

                        int Calificacion2=1;
                        bool Estatus;

                        var Sueldo;

                         IdAlumno=0;
                         Nombre="Pedro Antonio";
                         FechaNacimiento=DateTime.Now;
                         Estatus=false;

                         Console.Write(Nombre); 
               */

            //operadore : matematicos, logicos, comparacion 

            //  +,-,*,/,   \ % V =
            //  &&=>y  ||=>o  ~=>no
            //  >, <, >=, <=, ==, ===, != !==


            int Suma;
            int Resta;
            int Numero1 = 5;
            int Numero2 = 15;
            int Numero3 = 10;

            Suma = Numero1 + Numero2;
            Resta = Numero2 - Numero1;

            Console.WriteLine(Suma);
            Console.WriteLine(Resta);
            Console.WriteLine(Numero1 * Numero2);


            //Condicionales if,  switch ,  () ? : 

            //if(condiciones){}[else][else if] 

            if (Numero3 != 0)
                Console.WriteLine(Numero1 / Numero3);
            else
                Console.WriteLine("No se puede hacer divicion por cero");


            if (Numero1 % 2 == 0)
            {
                Console.WriteLine("Es Par");
            }
            else
            {
                Console.WriteLine("Es Impar");
            }


            if (Numero1 > Numero2)
            {
                if (Numero1 > Numero3)
                    Console.WriteLine($"{Numero1} es mayor");
                else
                {
                    if (Numero3 > Numero2)
                        Console.WriteLine($"{Numero3} es mayor");
                    else
                        Console.WriteLine($"{Numero2} es mayor");
                }
            }
            else
            {
                if (Numero2 > Numero3)
                    Console.WriteLine($"{Numero2} es mayor");
                else
                {
                    if (Numero3 > Numero1)
                        Console.WriteLine($"{Numero3} es mayor");
                    else
                        Console.WriteLine($"{Numero1} es mayor");
                }
            }

            if (Numero1 > Numero2 && Numero1 > Numero3)
                Console.WriteLine($"{Numero1} es mayor");
            else
            {
                if (Numero2 > Numero1 && Numero2 > Numero3)
                    Console.WriteLine($"{Numero2} es mayor");
                else
                    Console.WriteLine($"{Numero3} es mayor");
            }


            /* switch (valor)
            {
                case caso1:
                   instruccion
                   break;
                case caso2:
                    instruccion   
                    breack;
                default:
                Instruccion
                break;
            } 
        */

           int opcion=10;
      
           switch (opcion) 
           {
              case 1:
                 Console.Write("se tecle 1") ;
                 break;
              case 2:  
              Console.Write("se tecle 2") ;
                 break;
              default:
              Console.Write("No existe la opcion deseada") ;
                 break;    
           } 

           
            Console.ReadKey();

        }
    }
}
