using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ProyectoPOS_Lopin.CapaEntidades
{
    internal static class Validacion
    {
        public static bool EsEntero(string s)
        {
            int numero;
            return int.TryParse(s, out numero);
        }

        //valida que dato sea decimal 
        public static bool EsDecimal(string s)
        {
            decimal numero;
            return decimal.TryParse(s, out numero);
        }

        //valida dirceion de correo electronico 
        public static bool EsCoreoValido(string email)
        {
            if (string.IsNullOrWhiteSpace(email))
                return false;
            //expresion regular para validar correo
            var patron = @"^[@\s]+@[^@\s]+\.[@\s]+$";
            return Regex.IsMatch(email, patron);
        }
        //Validaciones para clientes
        //valida que dato sea entero
        public static bool EsEnteroc(string s)
        {
            int Telefono;
            return int.TryParse(s, out Telefono);

        }
        //valida que dato sea entero
        public static bool EsEnteroId(string s)
        {
            int Id;
            return int.TryParse(s, out Id);
        }

        //valida direccion de correo electronico
        public static bool EsCorreoValidoc(string Correo)
        {
            if (string.IsNullOrWhiteSpace(Correo))
                return false;
            //Expresiones regular para validar correo
            var patron = @"^[^@\s]+.[^@\s]+$";
            return Regex.IsMatch(Correo, patron);
        }

    }
}
