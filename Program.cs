
using System;
using System.Collections.Generic;
using System.Linq;

namespace ejemplos5_1
{
    class Program
    {
        static void Main(string[] args)
        {



            // for, while, do while , foreach

            //for  (inicio;condicion; incremento ){} 
            /*
                        for (int i = 0; i < 3; i++)
                        {
                            Console.WriteLine(i);
                        }

                        for (int i = 30; i < 33; i++)
                        {
                            Console.WriteLine(i);
                        }

                        for (int i = 100; i >= 0; i -= 10)
                        {
                            Console.WriteLine(i);
                        }

            */
            //while(condicion){ validarcondicion}  
            /*
                        int i = 0;
                        while (i < 3)
                        {
                            Console.WriteLine(i);
                            i++;
                        }


                        bool bandera =true;
                        i = 0;
                        while (bandera == false )
                        {
                            if (i == 3)
                            {
                                bandera = true;
                            }
                            else
                            {
                                Console.WriteLine(i);
                                i++;
                            }
                        }
            */


            // do{}while(condicion) 
            /*
                        int i = 5;
                        do
                        {
                            Console.WriteLine(i);
                            i++;
                        } while (i < 3);
            */
            /*
                        List<string> cadenas = new List<string>();
                        cadenas.Add("Cadena1");
                        cadenas.Add("Cadena2");
                        cadenas.Add("Cadena3");
                        cadenas.Add("Cadena4");
                        cadenas.Add("Cadena5");
                        cadenas.Add("Cadena2");
                        cadenas.Add("Cadena3");
                        cadenas.Add("Cadena4");
                        cadenas.Add("Cadena5");
                        cadenas.Add("Cadena2");
                        cadenas.Add("Cadena3");
                        cadenas.Add("Cadena4");
                        cadenas.Add("Cadena5");
                        cadenas.Add("Cadena2");
                        cadenas.Add("Cadena3");
                        cadenas.Add("Cadena4");
                        cadenas.Add("Cadena5");
                        cadenas.Add("Cadena2");
                        cadenas.Add("Cadena3");
                        cadenas.Add("Cadena4");
                        cadenas.Add("Cadena5");
                        cadenas.Add("Cadena2");
                        cadenas.Add("Cadena3");
                        cadenas.Add("Cadena4");
                        cadenas.Add("Cadena5");

                        foreach (string cadena in cadenas)
                        {
                            Console.WriteLine(cadena);
                        }

            */
            //arreglos  tipodato[] NombreArreglo = new tipodato[];
            /*
                        int[] Enteros = new int[10000];

                        for (int i = 0; i < 100; i++)
                        {
                            Enteros[i] = i + 1;
                        }

                        int Suma = 0;


                        foreach (int entero in Enteros)
                        {
                            Suma = Suma + entero;
                        }

                        Console.WriteLine(Suma);

                        // List<Tipo> variable = new List<Tipo>();

                        List<int> ListEnteros = new List<int>();


                        for (int i = 0; i < 100; i++)

                        {
                            ListEnteros.Add(i + 1);
                        }


                        int SumaLista = 0;
                         foreach (int entero in ListEnteros)
                         {
                             SumaLista += entero;

                         }

                        SumaLista = ListEnteros.Sum();

                        Console.WriteLine(SumaLista);

            */

            SumaNumeros(15, 10);
            SumaNumeros(150, 1);
            SumaNumeros(35, 25);
        
            int resultado=SumaNumeros2(15,SumaNumeros2(25,50)); 
            Console.WriteLine(resultado);          
        }

        static void SumaNumeros(int numero1, int numero2)
        {
            Console.WriteLine(numero1 + numero2);
        }

       static int SumaNumeros2(int numero1, int numero2)
        {
            return numero1 + numero2;
        }

    }
}
