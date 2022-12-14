//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CapaDatos
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class tiusr6pl_Tarea3PrograVEntities2 : DbContext
    {
        public tiusr6pl_Tarea3PrograVEntities2()
            : base("name=tiusr6pl_Tarea3PrograVEntities2")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<LoginUsuario> LoginUsuarios { get; set; }
        public virtual DbSet<Producto> Productoes { get; set; }
    
        public virtual int CRUDProducto(Nullable<int> opcion, Nullable<int> codigoProducto, string nombreProducto, Nullable<double> existencias, string bodegaUbicacion)
        {
            var opcionParameter = opcion.HasValue ?
                new ObjectParameter("Opcion", opcion) :
                new ObjectParameter("Opcion", typeof(int));
    
            var codigoProductoParameter = codigoProducto.HasValue ?
                new ObjectParameter("CodigoProducto", codigoProducto) :
                new ObjectParameter("CodigoProducto", typeof(int));
    
            var nombreProductoParameter = nombreProducto != null ?
                new ObjectParameter("NombreProducto", nombreProducto) :
                new ObjectParameter("NombreProducto", typeof(string));
    
            var existenciasParameter = existencias.HasValue ?
                new ObjectParameter("Existencias", existencias) :
                new ObjectParameter("Existencias", typeof(double));
    
            var bodegaUbicacionParameter = bodegaUbicacion != null ?
                new ObjectParameter("BodegaUbicacion", bodegaUbicacion) :
                new ObjectParameter("BodegaUbicacion", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("CRUDProducto", opcionParameter, codigoProductoParameter, nombreProductoParameter, existenciasParameter, bodegaUbicacionParameter);
        }
    
        public virtual int CRUDUsuario(Nullable<int> opcion, Nullable<int> iD, string nombre, string apellidos, string contraseña)
        {
            var opcionParameter = opcion.HasValue ?
                new ObjectParameter("Opcion", opcion) :
                new ObjectParameter("Opcion", typeof(int));
    
            var iDParameter = iD.HasValue ?
                new ObjectParameter("ID", iD) :
                new ObjectParameter("ID", typeof(int));
    
            var nombreParameter = nombre != null ?
                new ObjectParameter("Nombre", nombre) :
                new ObjectParameter("Nombre", typeof(string));
    
            var apellidosParameter = apellidos != null ?
                new ObjectParameter("Apellidos", apellidos) :
                new ObjectParameter("Apellidos", typeof(string));
    
            var contraseñaParameter = contraseña != null ?
                new ObjectParameter("Contraseña", contraseña) :
                new ObjectParameter("Contraseña", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("CRUDUsuario", opcionParameter, iDParameter, nombreParameter, apellidosParameter, contraseñaParameter);
        }
    
        public virtual int Verificar(Nullable<int> identificacion, string clave)
        {
            var identificacionParameter = identificacion.HasValue ?
                new ObjectParameter("identificacion", identificacion) :
                new ObjectParameter("identificacion", typeof(int));
    
            var claveParameter = clave != null ?
                new ObjectParameter("clave", clave) :
                new ObjectParameter("clave", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Verificar", identificacionParameter, claveParameter);
        }
    
        public virtual ObjectResult<Listar_Productos_Result> Listar_Productos()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Listar_Productos_Result>("Listar_Productos");
        }
    
        public virtual ObjectResult<ListaProductosCodigo_Result> ListaProductosCodigo(Nullable<int> codigo)
        {
            var codigoParameter = codigo.HasValue ?
                new ObjectParameter("codigo", codigo) :
                new ObjectParameter("codigo", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<ListaProductosCodigo_Result>("ListaProductosCodigo", codigoParameter);
        }
    }
}
