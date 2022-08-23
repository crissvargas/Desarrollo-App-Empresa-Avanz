using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio01
{
    internal class Program
    {
        // funcion para calcular la suma de 2 numero enteros
        static int Suma(int a, int b)
        {
            return a + b;
        }
        // funcion que permite restar 2 numeros enteros
        static int Resta(int num1, int num2)
        {
            return num1 - num2;
        }
        //funcion para la multiplicacion 
        static int Multiplicacion(int x, int y)
        {
            return x * y;
        }
        // funcion para la division 
        static double Division(double op1, double op2)
        {
            return op1 / op2;
        }
        // Funcion para mostrar los primeros 10 numeros primos 
        static void NumerosPrimos()
        {
            int n1 = 2;
            int div = 0;
            while (n1 <= 10) {
                for (int i = 1; i <= n1; i++) {
                    if (n1 % i == 0) {
                        div++;
                    }
                    if (div > 2) {
                        break;
                    }
                }
                if (div == 2) {
                    Console.WriteLine("{0}", n1);
                }
                div = 0;
                n1++;
            }
            Console.ReadKey();
        }
        // funcion que convierte de Celcius a Fahrenheit
        static int CelToFah (int cel){
            return ((cel * 9) / 5) + 32;

        }

        // Funcion que convierte de Fahrenheit a Celcius
        static int FahToCel(int Fah)
        {
            return (5 * (Fah - 32)) / 9;

        }

        //Procedimiento que imprime la raiz cuadrada de los 10 primeros numeros 

        static void Raiz()
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("La raìz cuadrada de {0} es:{1} ", i, Math.Sqrt(i));
            }
        }
        static void Main(string[] args)
        {
            Console.Title = "Procedimientos y funciones";
            string opcion;
            do
            {
                Console.Clear();
                Console.WriteLine("[1] Suma de dos números");
                Console.WriteLine("[2] Imprimir la raíz cuadrada de los 10 primeros números enteros");
                Console.WriteLine("[3] Resta de dos numeros");
                Console.WriteLine("[4] Multiplicacion de dos numeros");
                Console.WriteLine("[5] Division de dos numeros");
                Console.WriteLine("[6] Imprime los primeros 10 numeros primos");
                Console.WriteLine("[7] Convertidot de Celcius a Fahrenheit");
                Console.WriteLine("[8] Convertidor de Fahrenheit a Celcuis");
                Console.WriteLine("[0] Salir");
                Console.WriteLine("Ingrese una opción y presione ENTER");
                opcion = Console.ReadLine();
                switch (opcion)
                {
                    case "1":
                        Console.WriteLine("Ingrese el primer número");
                        int a = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Ingrese el segundo número");
                        int b = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("La suma de {0} y {1} es {2}", a, b, Suma(a, b));
                        Console.ReadKey();
                        break;
                    case "2":
                        Console.WriteLine("Calculando...");
                        Raiz();
                        Console.ReadKey();
                        break;
                    case "3":
                        Console.WriteLine("Ingrese el primer número");
                        int num1 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Ingrese el segundo número");
                        int num2 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("La resta de {0} y {1} es {2}", num1, num2, Resta(num1, num2));
                        Console.ReadKey();
                        break;
                    case "4":
                        Console.WriteLine("Ingrese el primer número");
                        int x = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Ingrese el segundo número");
                        int y = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("La Multiplicacion de {0} y {1} es {2}", x, y, Multiplicacion(x,y));
                        Console.ReadKey();
                        break;
                    case "5":
                        Console.WriteLine("Ingrese el primer número");
                        double op1 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Ingrese el segundo número");
                        double op2 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("La Division de {0} y {1} es {2}", op1, op2, Division(op1,op2));
                        Console.ReadKey();
                        break;
                    case "6":
                        Console.WriteLine("Los 10 numeros primos son\n");
                        NumerosPrimos(); 
                        Console.ReadKey();
                        break;
                    case "7":
                        Console.WriteLine("Ingrese los Celcius:");
                        int cel = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Los celcius {0} a Fahrenheit son:", cel, CelToFah(cel));
                        Console.ReadKey();
                        break;
                    case "8":
                        Console.WriteLine("Ingrese los Fahrenheit:");
                        int fah = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Los Fahrenheit {0} a Celsius son:", fah, FahToCel(fah));
                        Console.ReadKey();
                        break;
                }
            } while (!opcion.Equals("0"));

        }
    }
}
