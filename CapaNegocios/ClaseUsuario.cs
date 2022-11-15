using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Web;
using CapaDatos;

namespace CapaNegocio
{
    public class ClaseUsuario
    {
        //gd comentario prueba
        private tiusr6pl_Tarea3PrograVEntities2 entities;

        //constructor
        public ClaseUsuario()
        {
            entities = new tiusr6pl_Tarea3PrograVEntities2();
        }
        public int InsertarUsuario(int opcion, int identificacion, string nombre, string apellido, string contrasena)
        {
            entities.CRUDUsuario(opcion, identificacion, nombre, apellido, contrasena);
            return entities.SaveChanges();
        }

        public int ValidarUsuario( int identificacion,  string contrasena)
        {
            entities.Verificar( identificacion, contrasena);
            return entities.SaveChanges();

        }

        public int EliminaUsuario(int opcion, int identificacion, string nombre, string apellido, string contrasena)
        {
            entities.CRUDUsuario(opcion, identificacion, nombre, apellido, contrasena);
            return entities.SaveChanges();
        }
    }
}
