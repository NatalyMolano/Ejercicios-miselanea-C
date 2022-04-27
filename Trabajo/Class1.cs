using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabajo
{
    

    
        internal class Class1
        {
            public static void Main(string[] args)
            {
                string opcion2;
                Console.WriteLine("Bienvenido a la Miscelanea Ejercicios C#");
                Console.WriteLine(" ");
                Console.WriteLine("Menu principal");
                Console.WriteLine("---------------------------------------------");
                Console.WriteLine(" ");
                Console.WriteLine("Seleccione una de la siguientes condicionales: ");
                Console.WriteLine(" 1.si desea hacer Operacion");
                Console.WriteLine(" 2.si desea ver el Condicionales");
                Console.WriteLine(" 3.si desea ver los Ciclos ");
                Console.WriteLine(" 99. salir del programa");

                opcion2 = Console.ReadLine();
                switch (opcion2)
                {
                    case "1":
                        {
                            Operacion();
                            break;
                        }
                    case "2":
                        {

                            Bucles();
                            break;
                        }
                    case "3":
                        {
                            Condicionales();
                            break;
                        }
                    case "99":
                        {

                            break;
                        }


                }
            }
            static void Operacion()
            {
                string opcion_operadores;
                Console.WriteLine("Sub menu Operadores");
                Console.WriteLine("---------------------");
                Console.WriteLine("Selecciones una de las siguientes opciones: ");
                Console.WriteLine(" a. si desea Calcular el área de un triángulo.");
                Console.WriteLine(" b. si desea Ingresar dos números por teclado y sumarlos.");
                Console.WriteLine(" c. si desea Ingresar un número y visualizar el número elevado al cuadrado. ");
                Console.WriteLine(" d. si desea Escribir un algoritmo que convierta de euros a dólares.");
                Console.WriteLine(" e. si desea Escribir un algoritmo que pida el lado de un cuadrado y muestre el valor del área y del perímetro..");
                Console.WriteLine(" f. si desea Escribir un algoritmo que determine el área y el volúmen de un cilindro.");
                Console.WriteLine(" g. si desea Realizar un algoritmo que lea el radio de una circunferencia  ");
                Console.WriteLine(" h. si desea Calcular el promedio de tres (3) números ingresados por teclado.");
                Console.WriteLine(" 99. si desea Salir del programa");
                opcion_operadores = Console.ReadLine();

                switch (opcion_operadores)
                {
                    case "a":
                        {
                            BaseTriangulo();
                            break;
                        }
                    case "b":
                        {
                            Suma();
                            break;
                        }
                    case "c":
                        {
                            Cuadrado();
                            break;
                        }
                    case "d":
                        {
                            break;
                        }
                    case "e":
                        {
                            AreayPerimetro();
                            break;
                        }
                    case "f":
                        {
                            break;
                        }
                    case "g":
                        {
                            break;
                        }
                    case "h":
                        {
                            break;
                        }
                    case "99":
                        {
                            break;
                        }

                }
            }
            static void Bucles()
            {
                Console.WriteLine("En proceso");
            }
            static void Condicionales()
            {
                Console.WriteLine("En proceso");
            }
            static void BaseTriangulo()
            {
                Console.WriteLine("Ingrese la base del triangulo: ");
                int base_t = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese la altura del triangulo: ");
                int altura = int.Parse(Console.ReadLine());

                double area = (base_t * altura) / 2;
                Console.WriteLine("El area del triangulo es: " + area + " cm²");
                Console.ReadKey();
            }
            static void Suma()
            {
                double numero1, numero2, resultado;
                Console.WriteLine("Ingrese el primer número : ");
                numero1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Ingrese el segundo número : ");
                numero2 = Convert.ToInt32(Console.ReadLine());
                resultado = numero1 + numero2;
                Console.WriteLine("La suma de los numeros es:  " + resultado);
            }
            static void Cuadrado()
            {
                int numero;
                Console.WriteLine("Ingrese un numero");
                numero = int.Parse(Console.ReadLine());
                Console.WriteLine("El numero " + numero + " Elevado al cuadrado es: ");
                Console.WriteLine(Math.Pow(numero, 2));
                Console.ReadKey();
            }
            static void AreayPerimetro()
            {
                Console.WriteLine("Ingrese la medida de lado del cuadrado: ");
                double lado = double.Parse(Console.ReadLine());
                double area = lado * lado;
                double perimetro = 4 * lado;

                Console.WriteLine("El area del cuadrado es: " + area + "cm²");
                Console.WriteLine("El perimetro del cuadrado es: " + perimetro);
                Console.ReadKey();
            }
            static void AreayVolumen()
            {
                Console.WriteLine("Ingrese la medida del lado del cilindro: ");
                double LAdo = double.Parse(Console.ReadLine());
                
               
            }
        }
    }


