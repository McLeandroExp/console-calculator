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
using MiPrograma.Models;
namespace MiPrograma
{
    class Program
    {
        static void Main()
        {

            PrintNumber printNumber = new PrintNumber(-999);
            String numeroLetras = printNumber.NumberString();
            System.Console.WriteLine(numeroLetras);
        }
    }
}

