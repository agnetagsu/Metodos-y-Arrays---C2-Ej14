using System;

namespace Metodos_y_Arrays___C2_Ej14
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] miarray;
            int longitud;
            int numero;
            int posicion = 0;
            Boolean encontrado = false;
            Random aleatorio = new Random();

            Console.WriteLine("Introduce la longitud del array:");
            longitud = Convert.ToInt32(Console.ReadLine());
            miarray = new int[longitud];


            for (int i = 0; i < miarray.Length; i++)
            {
                miarray[i] = aleatorio.Next(1, 10);
            }

            Console.WriteLine("Introduce el número a buscar en el array:");
            numero = Convert.ToInt32(Console.ReadLine());

            do
            {
                
                if (miarray[posicion] == numero)
                {
                    encontrado = true;
                }
                else
                {
                    posicion++;
                }
                
                //Console.WriteLine(miarray[i]);
            } while ((!encontrado)&(posicion < miarray.Length));

            if (encontrado)
            {
                Console.WriteLine("El número se encuentra en la posición {0} del array",posicion);
            }
            else
            {
                Console.WriteLine("El número no se encuentra en el array");
            }

        }
    }
}
