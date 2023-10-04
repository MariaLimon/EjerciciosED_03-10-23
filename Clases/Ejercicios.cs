using System;
using System.Collections.Generic;
using System.Linq;
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

        //le falta
        public void Ejercicio4(int tamaño, int numero)
        {
            int[] numerosMultiplos = new int[tamaño];

            for(int i = 0; i < numerosMultiplos.Length;)
            {
                if (numero % i == 0)
                {
                    i++;
                    numerosMultiplos[i] = i;
                }
            }
            Console.WriteLine(string.Join(", ", numerosMultiplos));
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
            }
            for (int i = 0; i < tamaño; i++)
            {
                Console.WriteLine($"El nombre {nombresPersonas[i]} toma {longitud[i]} espacios");
            }
        }
    }
}
