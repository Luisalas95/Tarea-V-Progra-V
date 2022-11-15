using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace CapaDatos
{
    public class Encriptar
    {
        public  string GetSHA256(string str)//funcion para realizar encriptacion
        {
            SHA256 sha256 = SHA256Managed.Create();

            ASCIIEncoding encoding = new ASCIIEncoding();

            byte[] stream = null;
            StringBuilder sb = new StringBuilder();//contrustor de cadena string
            stream = sha256.ComputeHash(encoding.GetBytes(str));

            for (int i = 0; i < stream.Length; i++)
            {

                sb.AppendFormat(stream[i].ToString());
            }
            return sb.ToString();
        }



    }


}
