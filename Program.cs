// See https://aka.ms/new-console-template for more information
// Implementar un proyecto de consola en .NET Core (C#) llamado calculadora, 
//en la cual se debe implementar las operaciones de suma, resta,
// multiplicación, división, potenciación (al cuadrado y al cubo),
// raíz cuadrada, raíz cúbica.

// Los datos deben ser ingresado por teclado en tiempo de ejecución 
//mediante un menú y el resultado de la operación debe visualizarse 
//en números y letras. Ej: si ingresamos los datos 2 + 2 ,
// el resultado a visualizarse debe ser:

// Resultado: 4

// Resultado: Cuatro

// El proyecto debe ser implementado bajo los estandares 
// y buenas practicas de programación de C#, 
// no hacer uso de programación funcional

// Entregable:

// Proyecto comprimido
// PDF con capturas de pantalla de la ejecución


using System;
using ConsoleCalculator.Models;
namespace ConsoleCalculator
{

    class Program
    {
        static void Main()
        {
            bool exitProgram = false;
            do
            {
                Console.WriteLine("MENU DE OPCIONES:\n" +
                    "1. Suma de dos números\n" +
                    "2. Resta de dos números\n" +
                    "3. Multiplicación de dos números\n" +
                    "4. División de dos números\n" +
                    "5. Potenciación al cuadrado de un número\n" +
                    "6. Potenciación al cubo de un número\n" +
                    "7. Raíz cuadrada de un número\n" +
                    "8. Raíz cúbica de un número\n" +
                    "0. Salir del programa\n");

                Console.Write("Ingrese una opción: ");
                string option = Console.ReadLine() ?? "0";
                string numberStr = "";
                switch (option)
                {
                    case "1":
                        double sumResult = Operations.Sum();
                        numberStr = PrintNumber.NumberString(sumResult);
                        Console.WriteLine($"Resultado: {sumResult} \nResultado: {numberStr}");
                        break;
                    case "2":
                        double subtractResult = Operations.Subtract();
                        numberStr = PrintNumber.NumberString(subtractResult);
                        Console.WriteLine($"Resultado: {subtractResult} \nResultado: {numberStr}");
                        break;
                    case "3":
                        double multiplyResult = Operations.Multiply();
                        numberStr = PrintNumber.NumberString(multiplyResult);
                        Console.WriteLine($"Resultado: {multiplyResult} \nResultado: {numberStr}");
                        break;
                    case "4":
                        double divideResult = Operations.Divide();
                        numberStr = PrintNumber.NumberString(divideResult);
                        Console.WriteLine($"Resultado: {divideResult} \nResultado: {numberStr}");
                        break;
                    case "5":
                        double powerSquareResult = Operations.PowerSquare();
                        numberStr = PrintNumber.NumberString(powerSquareResult);
                        Console.WriteLine($"Resultado {powerSquareResult} \nResultado: {numberStr}");
                        break;
                    case "6":
                        double powerCubeResult = Operations.PowerCube();
                        numberStr = PrintNumber.NumberString(powerCubeResult);
                        Console.WriteLine($"Resultado: {powerCubeResult} \nResultado: {numberStr}");
                        break;
                    case "7":
                        double squareRootResult = Operations.SquareRoot();
                        numberStr = PrintNumber.NumberString(squareRootResult);
                        Console.WriteLine($"Resultado: {squareRootResult} \nResultado: {numberStr}");
                        break;
                    case "8":
                        double cubeRootResult = Operations.CubeRoot();
                        numberStr = PrintNumber.NumberString(cubeRootResult);
                        Console.WriteLine($"Resultado: {cubeRootResult} \nResultado: {numberStr}");
                        break;
                    case "0":
                        exitProgram = true;
                        break;
                    default:
                        Console.WriteLine("Opción inválida. Por favor, ingrese una opción válida.");
                        break;
                }

                Console.WriteLine();

            } while (!exitProgram);

        }
    }


}

