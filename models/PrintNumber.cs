
namespace ConsoleCalculator.Models
{
    public class PrintNumber
    {
        public static string NumberString(double number)
        {
            string[] units = { "cero", "uno", "dos", "tres", "cuatro", "cinco", "seis", "siete", "ocho", "nueve" };
            string[] tens = { "", "diez", "veinte", "treinta", "cuarenta", "cincuenta", "sesenta", "setenta", "ochenta", "noventa" };
            string[] teens = { "diez", "once", "doce", "trece", "catorce", "quince", "dieciséis", "diecisiete", "dieciocho", "diecinueve" };
            string[] hundreds = { "", "ciento", "doscientos", "trescientos", "cuatrocientos", "quinientos", "seiscientos", "setecientos", "ochocientos", "novecientos" };

            // Convertir el número a su valor absoluto y convertirlo a entero
            int integerPart = (int)Math.Abs(number);

            if (integerPart > 999 || integerPart < -999)
            {
                return "Número fuera de rango. Debe estar entre -999 y 999.";
            }

            string result = "";

            if (integerPart == 0)
            {
                result = units[0];
            }
            else if (integerPart < 10)
            {
                result = units[integerPart];
            }
            else if (integerPart < 16)
            {
                result = teens[integerPart - 10];
            }
            else if (integerPart < 20)
            {
                result = "dieci" + units[integerPart - 10];
            }
            else if (integerPart < 30)
            {
                result = "veinti" + units[integerPart - 20];
            }
            else if (integerPart < 100)
            {
                int tensDigit = integerPart / 10;
                int unitsDigit = integerPart % 10;

                if (unitsDigit != 0)
                {
                    result = tens[tensDigit] + " y " + units[unitsDigit];
                }
                else
                {
                    result = tens[tensDigit];
                }
            }
            else if (integerPart < 1000)
            {
                int hundredsDigit = integerPart / 100;
                int tensDigit = (integerPart % 100) / 10;
                int unitsDigit = integerPart % 10;

                if (tensDigit == 0 && unitsDigit == 0)
                {
                    result = hundreds[hundredsDigit];
                }
                else if (tensDigit == 0)
                {
                    result = hundreds[hundredsDigit] + " " + units[unitsDigit];
                }
                else if (tensDigit == 1)
                {
                    result = hundreds[hundredsDigit] + " " + teens[unitsDigit];
                }
                else if (unitsDigit == 0)
                {
                    result = hundreds[hundredsDigit] + " " + tens[tensDigit];
                }
                else
                {
                    result = hundreds[hundredsDigit] + " " + tens[tensDigit] + " y " + units[unitsDigit];
                }
            }

            if (number < 0)
            {
                result = "menos " + result;
            }

            return result;
        }

    }

}