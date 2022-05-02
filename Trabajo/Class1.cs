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
                case "1": {Operacion(); break;}
                case "2": { Condicionales(); break; }
                case "3": { Ciclos(); break; }
                case "99": {Salida(); break;}
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
            Console.WriteLine("---------------------- ");
            opcion_operadores = Console.ReadLine();

            switch (opcion_operadores)
            {
                case "a": { Console.WriteLine("---------------------"); BaseTriangulo(); break; }
                case "b": {  Console.WriteLine("---------------------");Suma();break;}
                case "c": { Console.WriteLine("---------------------"); Cuadrado();break; }
                case "d": {Console.WriteLine("---------------------");Conversion(); break; }
                case "e": {Console.WriteLine("---------------------");AreayPerimetro();break;}
                case "f": {Console.WriteLine("---------------------");AreayVolumen();break;  }
                case "g": {Console.WriteLine("---------------------"); Radio(); break; }
                case "h":{ Console.WriteLine("---------------------"); Promedio(); break; }
                case "99": {Console.WriteLine("---------------------");Salida(); break;}
            }
        }
        static void Condicionales()
        {
            string opcion_condicionales;
            Console.WriteLine("Sub menu Condicionales");
            Console.WriteLine("---------------------");
            Console.WriteLine("Selecciones una de las siguientes opciones: ");
            Console.WriteLine(" a. si desea escribir un algoritmo para saber si el numero ingresado por teclado es positivo o negativo.");
            Console.WriteLine(" b. si desea escribir un algoritmo que reciba dos numeros por teclao y diga cual es el mayor y cual es el menor.");
            Console.WriteLine(" c. si desea Ingrese  tres números enteros positivos para que calcule e imprima en pantalla el menor y el mayor de ellos");
            Console.WriteLine(" d. si desea Dar dos números A y B, sumarlos si A es menor que B o sino restarlos.");
            Console.WriteLine(" e. si desea Dar dos números A y B encontrar el cociente entre A y B.");
            Console.WriteLine(" f. si desea Dar dos números A y B, sumarlos si al menos uno de ellos es negativo, en caso contrario multiplicarlos.");
            Console.WriteLine(" g. si desea Escribir un algoritmo que determine si un año es bisiesto o no.");
            Console.WriteLine(" 99. si desea Salir del programa");
            opcion_condicionales = Console.ReadLine();
            switch (opcion_condicionales)
            {
                case "a": { PositivoNegativo(); break; }     
                case "b": { MayorMenor(); break; }     
                case "c":{ NumerosEnteros(); break; }  
                case "d": { SumaResta(); break; }
                case "e":{ Cociente(); break; }      
                case "f":{ sumaMultiplicacion();break;}   
                case "g":{ AñoBisiesto();break;}
                case "99":{ Salida(); break; }
                Console.ReadKey();

            }
        }
        static void Ciclos ()
        {
            string opcion_ciclos;
            Console.WriteLine("Sub menu Condicionales");
            Console.WriteLine("---------------------");
            Console.WriteLine("Selecciones una de las siguientes opciones: ");
            Console.WriteLine(" a. si desea Imprimir todos los múltiplos de 3 que hay entre 1 y 100.");
            Console.WriteLine(" b. si desea Imprimir los números impares entre 0 y 100.");
            Console.WriteLine(" c. si desea Imprimir los números pares del 1 al 100.");
            Console.WriteLine(" d. si desea ver en pantalla los cuadrados de los números del 1 al 30.");
            Console.WriteLine(" e. si desea Escribir un programa que sume los cuadrados de los cien primeros números naturales,mostrando el resultado en pantalla.");
            Console.WriteLine(" f. si desea Dados dos números naturales, el primero menor que el segundo, generar y mostrar todos los comprendidos entre ellos en secuencia ascendente.");
            Console.WriteLine(" g. si desea Dados dos números naturales, el primero menor que el segundo, generar y mostrar todos los números comprendidos entre ellos en secuencia ascendente.");
            Console.WriteLine(" 99. si desea Salir del programa");
            opcion_ciclos = Console.ReadLine();
            switch (opcion_ciclos)
            {
                case "a": { Multiplos(); break; }
                case "b": { Impares();  break; }
                case "c": { Pares();  break; }
                case "d": { Cuadrados(); break; }
                case "e": { SumaCuadrados();  break; }
                case "f": { break; }
                case "g": { break; }
                case "99": { Salida(); break; }
            }


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
            Console.WriteLine("Ingrese la perimetro: ");
            int perimetro = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la altura");
            int altura = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese radio");
            int radio = int.Parse(Console.ReadLine());
            Console.WriteLine("el area del cilindro es: " + (2 * Math.PI * perimetro * altura));
            Console.WriteLine("el volumen del cilindro es:" + (Math.PI * radio * radio * altura));
            Console.ReadKey();
        }
        static void Conversion()
        {
            double euros, dolares;
            Console.WriteLine("Ingrese los euros que desea convertir: ");
            euros = double.Parse(Console.ReadLine());
            dolares = euros * 1.06;
            Console.WriteLine("La convercion a dolares es:" + dolares);
            Console.ReadKey();
        }
        static void Radio()
        {
            Console.WriteLine("Ingrese el area");
            int area = int.Parse(Console.ReadLine());
            Console.WriteLine("El radio es: " + Math.Sqrt(area / Math.PI));
            Console.ReadKey();

        }
        static void Salida()
        {
            Console.WriteLine("Fin del programa");
        }
        static void Promedio()
        {
            Console.WriteLine("Ingrese primer valor: ");
            int n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese segundo valor: ");
            int n2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese tercer valor: ");
            int n3 = int.Parse(Console.ReadLine());
            Console.WriteLine("El promedio de los tres valores es de: " + (n1 + n2 + n3) / 3);
            Console.ReadKey();
        }
        static void PositivoNegativo()
        {
            Console.WriteLine("Ingrese numero: ");
            int numero = int.Parse(Console.ReadLine());
            if (numero == 0)
            { Console.WriteLine("El numero " + numero + " es neutro"); }
            else if (numero > 0)
            {  Console.WriteLine("El numero " + numero + " es positivo.");}
            else
            { Console.WriteLine("el numero " + numero + " es negativo"); }
            Console.ReadKey();
        }
        static void MayorMenor()
        {
            Console.WriteLine("Ingrese numero");
            float numero = float.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese segundo numero");
            float numero1 = float.Parse(Console.ReadLine());
            if (numero == numero1)
            { 
                Console.WriteLine("estos dos numeros son iguales: ");
            }
            else if (numero > numero1)
            {
                Console.WriteLine("el numero mayor es: " + numero + " el numero menor es:" + numero1);
            }
            else
            {
                Console.WriteLine("el numero mayor es: " + numero1 + " el numero menor es:" + numero);
            }
            Console.ReadLine();


        }
        static void NumerosEnteros()
        {
            int num1, num2, num3;
            Console.WriteLine("Ingrese numero: ");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese segundo numero: ");
            num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese tercer numero:  ");
            num3 = int.Parse(Console.ReadLine());
            if (num1 >= num2 && num1 >= num3)
            {
                Console.WriteLine("El numero mayor es: " + num1);
            }
            else if (num2 >= num3 && num2 >= num3)
            {
                Console.WriteLine("El numero mayor es:  " + num2);
            }
            else if (num3 >= num1 && num3 >= num2)
            {
                Console.WriteLine("El numero mayor es: " + num3);
            }
            else if (num1 <= num2 && num1 <= num3)
            {
                Console.WriteLine("El numero menor es: " + num1);
            }
            else if (num2 <= num3 && num2 <= num3)
            {
                Console.WriteLine("El numero menor es:  " + num2);
            }
            else if (num3 <= num1 && num3 <= num2)
            {
                Console.WriteLine("El numero menor es: " + num3);
            }
            Console.ReadKey();
        }
        static void SumaResta()
        {
            int num1, num2,resultado,resultado2;
            Console.WriteLine("Ingresa numero: ");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese numero: ");
            num2 = int.Parse(Console.ReadLine()); 
            if ( num1 >= num2 )
            {
                resultado = num1 + num2;
                Console.WriteLine("La suma de los numeros es: " + resultado);
            }
            else if (num2 > num1)
            {
                resultado2 = num2 + num1;
                Console.WriteLine("la resta de los numeros es: " + resultado2);
            }
            Console.ReadKey();

        }
        static void Cociente()
        {
            int dividendo, divisor;
            Console.WriteLine("Ingrese el numero dividendo: ");
            dividendo = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el numero divisor: ");
            divisor = int.Parse(Console.ReadLine());
            
            
            if (dividendo <= 0)
            {
                Console.WriteLine("No se puede hacer la operacion");
            }
            else if (divisor <= 0)
            {
                Console.WriteLine("No se puede hacer la operacion");
            }
            else
            {
                Console.WriteLine("El cociente es: " + dividendo / divisor);
            }
            Console.ReadKey();
        }
        static void sumaMultiplicacion()
        {
            int num1, num2;
            Console.WriteLine("Ingrese numero: " );
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese segundo numero: ");
            num2 = int.Parse(Console.ReadLine());
            if ( num1 < 0 || num2 <0)
            {
                Console.WriteLine("La suma de los numeros es: " + (num1 + num2));
            }
            else if ( num1 >= 0 && num2 >= num1 )
            {
                Console.WriteLine("La multiplicacion de los numeros es: " + (num1 * num2));
            }
            Console.ReadKey();
                

        }
        static bool Bisiesto(int año)
        {
           if (año % 4 == 0 &&(año % 100 !=0 || año % 400 ==0 ))return true;
            return false;
        }
        static void AñoBisiesto ()
        {
            Console.WriteLine("Ingrese año: ");
            int x = int.Parse(Console.ReadLine());  
            if (Bisiesto(x)==true)
            {
                Console.WriteLine("El año {0} es bisiesto " , x);
            }
            else
            {
                Console.WriteLine("El año {0} NO es bisiesto" , x);
            }
            Console.ReadKey();
        }
        static void Multiplos()
        {
           for(int i = 1; i < 100; i++)
            {
                if (i % 3 == 0)
                {
                    Console.Write("{0}|", i);
                }
            }
            Console.ReadKey();
        }
        static void Impares()
        {
            for (int i = 1; i < 100; i +=2)
            {
                Console.Write("{0}|", i);
            
            }
            Console.ReadKey();
        }
        static void Pares()
        {
            for (int i = 1; i < 100; i ++)
            {
              if (i%2 ==0)
                {
                    Console.Write("{0}|" , i);
                }
            }
            Console.ReadKey();
        }
        static void Cuadrados()
        {
            for (int i = 1; i < 31; i++)
            {Console.Write("| " + i * i);
            Console.ReadKey(); }
            
        
        }
        static void SumaCuadrados()
        {
            int suma = 0;
            for (int i = 1; i <= 100; i++)
              
            { 
                Console.WriteLine("Numero " + i);
                suma = suma + i * i;
                Console.WriteLine("El cuadrado es: " + Math.Pow(i,2)); 
            }
            Console.WriteLine("\nLa suma total de los cuadrados es: " + suma);
            Console.ReadKey();


        }
    }
}



