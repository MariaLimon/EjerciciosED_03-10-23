﻿using System;
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
            int[] numeros = { };
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("dame un numero");
                numeros[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine(string.Join(", ", numeros));
        }

        public void Ejercicio3()
        {
            int[] numerosMedia = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        }
    }
}
