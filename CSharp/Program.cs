using System;

namespace CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hola Mundo C# y .Net");

            // Imprimir Datos
            /*  int edad;
             string nombre;

            Console.WriteLine("Ingrese su nombre: ");
            nombre = Console.ReadLine();

            Console.WriteLine("Inserte su edad: ");
            edad = int.Parse(Console.ReadLine());

            Console.WriteLine("El nombre del usuario es " + nombre + " y la edad es " + edad+" años");*/

            // Suma
            /*
               float numero1;
               float numero2;

               Console.WriteLine("Inserte un número para sumar: ");
               numero1 = int.Parse(Console.ReadLine());

               Console.WriteLine("Inserte otro número para sumar: ");
               numero2 = int.Parse(Console.ReadLine());

               float suma = numero1 + numero2;

               Console.WriteLine("La Suma de los números es " + suma);*/

            // Condicionales
            /*
            Boolean pregunta;
            Console.WriteLine("¿Usted hizó la tarea de matemáticas? \n True: si la hizó \n False: No la Hizó");
            pregunta = bool.Parse(Console.ReadLine());
            Console.WriteLine(pregunta);

            if(pregunta == true)
            {
                Console.WriteLine("Regalo de navidad Smartphone de último módelo");
            } else
            {
                Console.WriteLine("No hay regalo de navidad");
            }*/

            // Ciclos
            /* for(int i = 1; i <= 10; i++)
             {
                 Console.WriteLine(i);

             }*/

            // Switch Case
            /*int opcion;
          
            Console.WriteLine("Ingrese una opción \n 1. Sumar \n 2. Restar \n 3. Salir");
            opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1: 
                    float numero1, numero2, resultado;
                    Console.WriteLine("Ingrese un número para sumar");
                    numero1 = float.Parse(Console.ReadLine());
                    Console.WriteLine("Ingrese otro número para sumar");
                    numero2 = float.Parse(Console.ReadLine());
                    resultado = numero1 + numero2;
                    Console.WriteLine("La suma de los números es: " + resultado);
                    break;
                case 2: float numero3, numero4, resultado2;
                    Console.WriteLine("Ingrese un número para restar");
                    numero3 = float.Parse(Console.ReadLine());
                    Console.WriteLine("Ingrese otro número para restar");
                    numero4 = float.Parse(Console.ReadLine());
                    resultado2 = numero3 - numero4;
                    Console.WriteLine("La resta de los números es: " + resultado2);
                    break;
                default:
                    break;
            }*/

            // Funciones 

            Console.WriteLine(suma(4));

        }

        // Función sin retorno
        static void mensaje()
        {
            Console.WriteLine("Hola A todos XD");
        }

        // Función con retorno
       static int suma(int a)
        {
            int b = a + 5;

            return b;
        }
    }
}
