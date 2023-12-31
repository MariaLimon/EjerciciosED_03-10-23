﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosED_03_10_23.Clases
{
    internal class Ejercicios
    {
        public void Ejercicio1()
        {
            int[] numeros = { 1, 2, 3, 4, 5 };
            Console.WriteLine(string.Join(", ", numeros));
        }

        public void Ejercicio2()
        {
            int[] numeros = new int[5];
            for (int i = 0; i < numeros.Length; i++)
            {
                Console.WriteLine("dame un numero");
                numeros[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine(string.Join(", ", numeros));
        }

        public void Ejercicio3()
        {
            int suma = 0;
            int[] numeros = new int[10];
            for (int i = 0; i < numeros.Length; i++)
            {
                Console.WriteLine("dame un numero");
                numeros[i] = Convert.ToInt32(Console.ReadLine());
                suma += numeros[i]; 
            }
            double media = suma /numeros.Length;
            Console.WriteLine($"la media es: {media}");

        }

        
        public void Ejercicio4(int tamaño, int numero)
        {
            int[] numerosMultiplos = new int[tamaño];

            for(int i = 1; i <= tamaño ;i++)
            {

                Console.WriteLine(numero *i);
                
            }
           
        }

        public void Ejercicio5(int tamaño)
        {
            string[] nombresPersonas = new string[tamaño];
            int[] longitud = new int[tamaño];

            for(int i= 0; i < tamaño; i++)
            {
                Console.WriteLine("dame el nombre de la persona");
                nombresPersonas[i] = Console.ReadLine();

                longitud[i] = nombresPersonas[i].Length;
                Console.WriteLine($"El nombre {nombresPersonas[i]} toma {longitud[i]} espacios");
            }
            /*
            for (int i = 0; i < tamaño; i++)
            {
                Console.WriteLine($"El nombre {nombresPersonas[i]} toma {longitud[i]} espacios");
            }
            */
        }




        /*   ###   EJERCICIOS 04-10-23   ###    */



        public void Ejercicio6(int tamaño)
        {
            int[] array1 = new int[tamaño];
            int[] array2 = new int[tamaño];
            int[] sumaArreglos = new int[tamaño]; 
            for (int i =0; i < tamaño; i++)
            {
                Console.WriteLine($"dame el valor de la posicion {i} en el arreglo 1");
                array1[i] = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"dame el valor de la posicion {i} en el arreglo 2");
                array2[i] = Convert.ToInt32(Console.ReadLine());
                sumaArreglos[i] = array1[i] + array2[i];
            }
            for (int i = 0; i < tamaño; i++)
            {
                Console.WriteLine($"arreglo1 posicion {i} + arreglo2 posicion {i} = {sumaArreglos[i]}");
                
            }
        }

        public void Ejercicio7(int numero)
        {
            /*if( numero < 0 && numero>10)
            {
                int i = 0;
                while (numeros[i] != numero)
                {
                    i++;
                }
                Console.WriteLine($"el numero esta en la pocision {i} del array");
            }
            Console.WriteLine("no es un numero valido");*/
            int[] numeros = { 1, 2, 3, 4, 5, 6, 7, 4, 9, 10 };
            if(numero <= 0 || numero > 10)
            {
                Console.WriteLine("el numero no es valido");
            }
            else
            {
                for (int i = 0; i < 10; i++)
                {
                    if (numeros[i] == numero)
                    {
                        Console.WriteLine($"{numero} esta en la posicion {i}");
                    }
                }
            }
            
        }
      
        public void Ejercicio8(int tamañoAlgebra, int tamañoAnalisis)
        {
            int[] algebra = new int[tamañoAlgebra];
            int[] analisis = new int[tamañoAnalisis];
            int[] coincidenciasAlumnos = new int[tamañoAlgebra];
            if (tamañoAlgebra < tamañoAnalisis)
            { 
                coincidenciasAlumnos = new int[tamañoAnalisis];
            }
            for (int i = 0; i < tamañoAlgebra; i++)
            {
                Console.WriteLine("dame los id de la clase de algebra");
                algebra[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < tamañoAnalisis; i++)
            {
                Console.WriteLine("dame los id de la clase de analisis");
                analisis[i] = Convert.ToInt32(Console.ReadLine());
            }
            int cantidadCoincidencias = 0;
            for (int i = 0; i < tamañoAlgebra; i++)
            {
                for (int j = 0; j < tamañoAnalisis; j++)
                {
                    if (algebra[i] == analisis[j])
                    {
                        coincidenciasAlumnos[cantidadCoincidencias] = algebra[i];
                        cantidadCoincidencias++;
                    }
                }
            }

            Console.WriteLine("los alumnos inscritos en ambas asignaturas son:");
            for (int i = 0; i < cantidadCoincidencias; i++)
            {
                Console.WriteLine(coincidenciasAlumnos[i] + " ");
            }

        }

        public void Ejercicio9(int tamaño)
        {
            
            int[] arrayNumeros = new int[tamaño];
            int numero;
            for (int i = 0; i < tamaño; i++)
            {
                Console.WriteLine($"dame el valor de la posicion {i} en el arreglo");
                numero = Convert.ToInt32(Console.ReadLine());
                

                for (int j=0; i < j; j++)
                {
                    if (numero == arrayNumeros[j])
                    {
                        
                        Console.WriteLine("ese numero ya esta en el array");
                        break;
                        
                    }
                }
                
            }
        }

        public void Ejercicio10(int tamaño)
        {
            
        }
    }
}
