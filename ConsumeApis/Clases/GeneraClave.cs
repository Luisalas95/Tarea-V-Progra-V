using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class GeneraClave
    {
        public static string ClaveGenerada(string clave)
        {
            Random rdn = new Random();
            //caracteres contiene las letras para generar la contraseña.
            string caracteres = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890%$#@";

            int longitud = caracteres.Length;

            char letra;
            int longitudContrasenia = 12;
            clave = string.Empty;

            //vueltas para obtener las letras de la variable caracteres.
            for (int i = 0; i < longitudContrasenia; i++)
            {
                letra = caracteres[rdn.Next(longitud)];
                clave += letra.ToString();
                //concatenamos la variable letra con contraseniaAleatoria, para armar la cadena.

            }
            return clave;
        }
    }
}