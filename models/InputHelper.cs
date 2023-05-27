// using System;

// namespace ConsoleCalculator.Models
// {
//     class InputHelper
//     {
//         public static double GetNumber(string message)
//         {
//             double number = 0;
//             bool isValidNumber = false;

//             do
//             {
//                 Console.Write(message);
//                 string input = Console.ReadLine();

//                 if (!string.IsNullOrEmpty(input))
//                 {
//                     if (double.TryParse(input, out number))
//                     {
//                         isValidNumber = true;
//                     }
//                     else
//                     {
//                         Console.WriteLine("Error: Ingrese un número válido.");
//                     }
//                 }
//                 else
//                 {
//                     Console.WriteLine("Error: No se ha ingresado ningún valor.");
//                 }

//             } while (!isValidNumber);

//             return number;
//         }
//     }
// }


using System;

namespace ConsoleCalculator.Models
{
    class InputHelper
    {
        public static double GetNumber(string message)
        {
            double number = 0;
            bool isValidNumber = false;

            do
            {
                Console.Write(message);
                string input = Console.ReadLine() ?? "nJu09f6wa";

                if (input != "nJu09f6wa")
                {
                    if (double.TryParse(input, out double parsedNumber))
                    {
                        number = parsedNumber;
                        isValidNumber = true;
                    }
                    else
                    {
                        Console.WriteLine("Error: Ingrese un número válido.");
                    }
                }
                else
                {
                    Console.WriteLine("Error: No se ha ingresado ningún valor.");
                }

            } while (!isValidNumber);

            return number;
        }
    }
}


