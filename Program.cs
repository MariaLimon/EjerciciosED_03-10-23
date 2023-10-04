using EjerciciosED_03_10_23.Clases;

namespace EjerciciosED_03_10_23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ejercicios ejercicio1 = new Ejercicios();
            //ejercicio1.Ejercicio1();

            //Ejercicios ejercicio2 = new Ejercicios();
            //ejercicio2.Ejercicio2();

            //Ejercicios ejercicios3 = new Ejercicios();
            //ejercicios3 .Ejercicio3();

            //Console.WriteLine("dame el tamaño del arreglo");
            //int tamaño = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("dame un numero");
            //int numero = Convert.ToInt32(Console.ReadLine());
            //Ejercicios ejercicios4 = new Ejercicios();
            //ejercicios4.Ejercicio4(tamaño, numero);

            Console.WriteLine("dame el tamaño del arreglo");
            int tamaño = Convert.ToInt32(Console.ReadLine());
            Ejercicios ejercicios5 = new Ejercicios();
            ejercicios5.Ejercicio5(tamaño);

        }
    }
}