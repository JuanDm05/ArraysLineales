using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysLineales
{
    internal class Metodos
    {
        public void Lineal()
        {
            int[] t = { 13, 22, 12, 4, 5, 6, 7, 8, 9 };
            Console.WriteLine("Ingrese valor para decirle su posicion");
            int valor = Convert.ToInt32(Console.ReadLine());
            bool encontrado = false;
            for (int i = 0; i < t.Length; i++)
            {
                if (t[i] == valor)
                {
                    Console.WriteLine($"El valor esta en la posicion {i + 1}");
                    encontrado = true;
                    break;
                }
            }
            if (!encontrado)
            {
                Console.WriteLine("El valor no esta en este arreglo");
            }

        }
        public void Cadena()
        {
            string[] t = { "hola", "adios", "bye" };
            Console.WriteLine("Ingresa cadena para ver si esta en este arreglo");
            string cadena = Console.ReadLine();
            bool encontrada = false;
            for (int i = 0; i < t.Length; i++)
            {
                if (t[i] == cadena)
                {
                    Console.WriteLine($"La cadena {cadena} se ecuentra en la posicion {i + 1} de este arreglo");
                    encontrada = true;
                    break;
                }
            }
            if (!encontrada)
            {
                Console.WriteLine("LA CADENA NO ESTA EN ESTE ARRAY");
            }
        }
        public void Enteros()
        {
            int[] numeros = { 1, 2, 2, 2, 2, 2, 2, 2, 2, 5 };
            bool encontrado = false;
            for (int i = 0; i < numeros.Length; i++)
            {

                if (numeros[i] % 2 == 0)
                {
                    Console.WriteLine($"El numero par esta en la posicion {i + 1}");
                    encontrado = true;
                    break;
                }
            }
            if (!encontrado)
            {
                Console.WriteLine($"No hay numeros pares");
            }
        }
        public void EnterosV2()
        {
            int[] numeros = { 1, 2, 2, 2, 2, 2, 2, 2, 2, 5 };
            bool encontrado = false;
            for (int i = 0; i < numeros.Length; i++)
            {

                if (numeros[i] % 2 == 0)
                {
                    Console.WriteLine($"El numero par esta en la posicion {i + 1}");
                    encontrado = true;
                }
            }
            if (!encontrado)
            {
                Console.WriteLine($"No hay numeros pares");
            }
        }
        public void BinariaBusqueda()
        {
            int[] numeros = { 1, 2, 3, 4, 5, 6, 7 };
            Console.WriteLine("Ingrea numero a  buscar");
            int numeroBuscar = Convert.ToInt32(Console.ReadLine());
            bool encontrado = false;
            int izquierda = 0;
            int derecha = numeros.Length-1;
            while (izquierda <= derecha)
            {
                int medio = (izquierda + derecha) / 2;
                if (medio == numeroBuscar)
                {
                    Console.WriteLine($"El numero que buscaste esta en la posicion {medio}");
                    encontrado = true;
                    break;
                }
                if (medio < numeroBuscar)
                {
                    izquierda = medio + 1;
                }
                if(medio > numeroBuscar)
                {
                    derecha = medio -1;
                }

            }
        }
        public void Cadenasv2()
        {
            char[] cadenitas = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H' };
            Console.WriteLine("iNGRESE CARACTER PARA BUSACR");
            char caracter = Convert.ToChar(Console.ReadLine());
            bool encontrado = false;
            int izquierda = 0;
            int derecha = cadenitas.Length-1;
            while(izquierda <= derecha)
            {
                int medio= (izquierda + derecha)/ 2;
                int comparacion = string.Compare(cadenitas[medio].ToString(), caracter.ToString());
                if(comparacion == 0)
                {
                    Console.WriteLine($"El caracter se encuentra en la posicion {medio}");
                    encontrado = true;  
                    break;
                    
                }
                else if(comparacion <0)
                {
                    izquierda = medio + 1;
                }
                else if (comparacion > 0)
                {
                    derecha = medio - 1;
                }

                
            }
            if (!encontrado)
            {
                Console.WriteLine("No se ecneucntra");
            }

        }
        public void ParesV2()
        {
            int[] numeros = { 1, 2, 3, 4, 5, 6, 7, 8, 9 }; // Arreglo ordenado de menor a mayor

            int izquierda = 0;
            int derecha = numeros.Length - 1;
            bool encontrado = false;

            while (izquierda <= derecha)
            {
                int medio = (izquierda + derecha) / 2;

                // Verificar si el número en la posición del medio es par
                if (numeros[medio] % 2 == 0)
                {
                    Console.WriteLine($"El primer número par se encuentra en la posición {medio}");
                    encontrado = true;
                    break;
                }
                else if (numeros[medio] > 2)
                {
                    // Si el número en la posición del medio es par, buscar en la mitad izquierda
                    derecha = medio - 1;
                }
                else
                {
                    // Si el número en la posición del medio es impar, buscar en la mitad derecha
                    izquierda = medio + 1;
                }
            }

            if (!encontrado)
            {
                Console.WriteLine("No se encontraron números pares en el arreglo.");
            }
        }
    }
}

