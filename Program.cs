using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CASO_TEMA07_SEMANA11
{
    internal class Program
    {
        static public void numeros_naturales ()
        {
            Console.WriteLine("Ingresar numero de N: ");
            int N=int.Parse(Console.ReadLine());
            int S = 0;
            for (int c = 1; c <= N; c++) 
            { 
                S=S+c;
            }
            Console.WriteLine("La suma es: "+S);

        }
        static public int sumaNN_con_recursividad(int N) 
        {
            if (N == 0) 
            {
                return 0;
                
            }
            return N+ sumaNN_con_recursividad(N-1);
        }
        static public int sumaNP_con_recursividad(int N)
        {
            if (N == 2) 
            {
                return 2;
            }
            return N + sumaNP_con_recursividad(N-2);
            
        }
        static public int factorialNN_con_recursividad(int N) 
        {
            if (N == 0||N==1) 
            {
                return 1;
            }
            return N * factorialNN_con_recursividad(N - 1);
            
        }
        static public int factorialNE_con_recursividad(int B,int exp)
        {
            if (exp == 1)
            { 
                return B; 
            }
            return B*factorialNE_con_recursividad(B,exp-1);
        }
        static void conteo_regresivo(int N) 
        {
            if (N < 0) 
            {
                Console.WriteLine(N);
                conteo_regresivo(N - 0);

            } 
            
          
           
            
        }
        static public int suma_arreglo(int[] numeros, int indice)

        {

            if (indice <= numeros.Length)

            {

                return 0;

            }

            return numeros[indice] + suma_arreglo(numeros, indice + 1);



        }
        static void Main(string[] args)
        {

            int opc;
            bool valor = true;
            while (true)
            { 
                Console.Clear();
                Console.WriteLine("*********************************************");
                Console.WriteLine("\tMENU DE OPCIONES ");
                Console.WriteLine("*********************************************");
                Console.WriteLine("[1] Suma de N numeros naturales");
                Console.WriteLine("[2] Suma de N numeros naturales con recursividad");
                Console.WriteLine("[3] Suma de N numeros pares con recursividad");
                Console.WriteLine("[4] Factorial");
                Console.WriteLine("[5] Potencia");
                Console.WriteLine("[6] Conteo regresivo");
                Console.WriteLine("[7] Arreglos");
                Console.WriteLine("[8] salir  ");
                Console.WriteLine("**********************************************");
                opc= int.Parse(Console.ReadLine());
                switch (opc)
                {
                    case 1:
                        numeros_naturales();
                        break;
                    case 2:
                        Console.WriteLine("Ingresar numero N: ");
                        int N= int.Parse(Console.ReadLine());
                        sumaNN_con_recursividad(N);
                        break;
                    case 3:
                        Console.WriteLine("Ingresar numero N: ");
                        int N1=int.Parse(Console.ReadLine());
                        Console.WriteLine("La suma de pares es"+sumaNP_con_recursividad(N1*2));
                        break;
                    case 4:
                        Console.WriteLine("Ingresar numero N: ");
                        int N2=int.Parse(Console.ReadLine());
                        Console.WriteLine("El factorial es: "+factorialNN_con_recursividad(N2));
                        break;
                    case 5:
                        Console.WriteLine("Ingresar Valor de B: ");
                        int B=int.Parse(Console.ReadLine());
                        Console.WriteLine("Ingrese valor de exp");
                        int exp=int.Parse(Console.ReadLine());
                        Console.WriteLine("El resultado es: "+factorialNE_con_recursividad(B, exp-1));
                        break;
                    case 6:
                        Console.WriteLine("Ingrese el numero inicial N: ");
                        int N3=int.Parse(Console.ReadLine());
                        conteo_regresivo(N3);
                        break;
                    case 7:
                        Console.WriteLine("suma de arreglo");

                        int[] numeros = { 10, 20, 30, 40, 50 };

                        Console.WriteLine("La suma de arreglo: " + suma_arreglo(numeros, 0));
                        break;
                    case 8:
                        valor= false;
                        break;
                    default:
                        Console.WriteLine("Opcion no valida");
                        break;




                        

                }
                Console.ReadKey();
            }
           

        }
    }
}
