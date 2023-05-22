
namespace MiPrograma.Models
{
    public class PrintNumber
    {
        private double number;

        public PrintNumber(double number)
        {
            this.number = Math.Floor(number);
        }

        public String NumberString()
        {
            string[] units = { "uno", "dos", "tres", "cuatro", "cinco", "seis", "siete", "ocho", "nueve" };

            string[] tens = { "diez", "veinte", "treinta", "cuarenta", "cincuenta", "sesenta", "setenta", "ochenta", "noventa" };

            string[] hundreds = { "cien", "doscientos", "trescientos", "cuatrocientos", "quinientos", "seiscientos", "setecientos", "ochocientos", "novecientos" };


            string finalString = "";
            string numberAsString = Math.Abs(number).ToString();
            int[] digits = new int[numberAsString.Length];
            for (int i = 0; i < numberAsString.Length; i++)
            {
                digits[i] = int.Parse(numberAsString[numberAsString.Length - 1 - i].ToString());
            }
            if (digits.Length > 3)
            {
                return "Solo hasta 3 digitos";
            }
            switch (numberAsString)
            {
                case "0": return "cero";
                case "10": return "diez";
                case "11": return "once";
                case "12": return "doce";
                case "13": return "trece";
                case "14": return "catorce";
                case "15": return "quince";
                default: break;
            }
            if (number < 0)
            {
                finalString += "menos ";
            }
            if (digits.Length >= 3)
            {
                int hundred = digits[2];
                if (hundred != 0)
                {
                    finalString += hundreds[hundred - 1] + " ";
                }
            }
            if (digits.Length >= 2)
            {
                int ten = digits[1];
                if (ten != 0)
                {
                    finalString += tens[ten - 1] + " y ";
                }
            }
            if (digits.Length >= 1)
            {
                int unit = digits[0];
                if (unit != 0)
                {
                    finalString += units[unit - 1];
                }
            }

            return finalString;
        }
    }

}