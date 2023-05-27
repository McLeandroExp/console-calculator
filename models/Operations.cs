using System;
namespace ConsoleCalculator.Models
{
    class Operations
    {
        public static double Sum()
        {
            double num1 = InputHelper.GetNumber("Ingrese el primer número: ");
            double num2 = InputHelper.GetNumber("Ingrese el segundo número: ");
            return num1 + num2;
        }

        public static double Subtract()
        {
            double num1 = InputHelper.GetNumber("Ingrese el primer número: ");
            double num2 = InputHelper.GetNumber("Ingrese el segundo número: ");

            return num1 - num2;
        }

        public static double Multiply()
        {
            double num1 = InputHelper.GetNumber("Ingrese el primer número: ");
            double num2 = InputHelper.GetNumber("Ingrese el segundo número: ");

            return num1 * num2;
        }

        public static double Divide()
        {
            double dividend = InputHelper.GetNumber("Ingrese el dividendo: ");
            double divisor = 0;
            double result = 0;
            do
            {
                divisor = InputHelper.GetNumber("Ingrese el divisor: ");
                if (divisor == 0)
                    Console.WriteLine("No se puede dividir para 0");
            } while (divisor == 0);
            result = dividend / divisor;
            return result;
        }

        public static double PowerSquare()
        {
            double num = InputHelper.GetNumber("Ingrese el número: ");

            return Math.Pow(num, 2);
        }

        public static double PowerCube()
        {
            double num = InputHelper.GetNumber("Ingrese el número: ");

            return Math.Pow(num, 3);

        }

        public static double SquareRoot()
        {
            double num = -1;
            do
            {
                num = InputHelper.GetNumber("Ingrese el número: ");
                if (num < 0)
                    Console.WriteLine("No se puede sacar raiz cuadrada de numeros menores que 0");
            } while (num < 0);
            return Math.Sqrt(num);
        }

        public static double CubeRoot()
        {
            double num = InputHelper.GetNumber("Ingrese el número: ");

            return Math.Pow(num, 1.0 / 3.0);
        }
    }
}
