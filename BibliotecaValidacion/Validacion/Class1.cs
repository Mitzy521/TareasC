using System;
using System.Text.RegularExpressions;

namespace Validacion
{
    public static class Validador
    {
        public static bool ValidarNumeroEntero(string input, out int resultado)
        {
            return int.TryParse(input, out resultado);
        }

        public static bool ValidarCorreo(string email)
        {
            if (string.IsNullOrWhiteSpace(email))
            {
                return false;
            }

            string patron = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            
            return Regex.IsMatch(email, patron, RegexOptions.IgnoreCase);
        }

        public static bool ValidarFecha(string input, out DateTime fecha)
        {
            return DateTime.TryParse(input, out fecha);
        }
    }
}