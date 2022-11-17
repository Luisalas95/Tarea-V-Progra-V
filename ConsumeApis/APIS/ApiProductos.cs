using Newtonsoft.Json.Linq;
using QuickType2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace ConsumeApis.APIS
{
   public class ApiProductos
    {
        private const string BaseUrl = "http://localhost:56108/api/Productoes";
        public ApiProductos() { }

        public List<Producto> ListarTodosProductos(string Tokens)
        {
            try
            {
                List<Producto> P = new List<Producto>();
                
                
                
                using (var estudian = new HttpClient())
                {
                    //Enviamos el token en la cabezara 
                    string tokenss = Tokens;
                    string TokenSinComillas = Tokens.Replace("\"", "");
                estudian.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", TokenSinComillas);

                    var task1 = Task.Run(async () =>
                    {
                   
                        return await estudian.GetAsync(BaseUrl);
                    }
                    );
                    HttpResponseMessage Message = task1.Result;
                    if (Message.StatusCode == System.Net.HttpStatusCode.OK)
                    {
                        var task2 = Task<string>.Run(async () =>
                        {
                            return await Message.Content.ReadAsStringAsync();
                        });
                        string resultSrt = task2.Result;
                        P = Producto.FromJson(resultSrt);
                    }

                    if (Message.StatusCode == System.Net.HttpStatusCode.NotFound)
                    {
                        P = null;
                    }

                    if (Message.StatusCode == System.Net.HttpStatusCode.Unauthorized)
                    {
                        P = null;
                    }


                    return P;
                }

            }
            catch (Exception)
            {

                throw;
            }

        }

        public string InsertaProducto(Producto c, string Tokens)
        {
            string json = c.ToJson();
            HttpClient cliente = new HttpClient();
            string TokenSinComillas = Tokens.Replace("\"", "");
            cliente.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", TokenSinComillas);
            var tarea = Task.Run
            (
               async () =>
               {
                   return await cliente.PostAsync(BaseUrl, new StringContent(json, Encoding.UTF8, "application/json"));
               }
            );


            HttpResponseMessage mensaje = tarea.Result;

            if (mensaje.StatusCode == System.Net.HttpStatusCode.Created)
            {
                var tarea2 = Task<string>.Run
                (
                    async () =>
                    {
                        return await mensaje.Content.ReadAsStringAsync();
                    }

                );

                return "201";// usuario creado
            }
            else
            {
                if (mensaje.StatusCode == System.Net.HttpStatusCode.Conflict)
                {
                    return "409";// conflicto (el usuario ya existe)

                }
                else
                {
                    if (mensaje.StatusCode == System.Net.HttpStatusCode.NotFound)
                    {
                        return "404";

                    }
                    else
                    {
                        if (mensaje.StatusCode == System.Net.HttpStatusCode.InternalServerError)
                        {
                            return "500";/*Error interno en el servidor*/

                        }
                        else if (mensaje.StatusCode == System.Net.HttpStatusCode.Unauthorized)
                        {
                            return "401";

                        }
                        else
                        {
                            return "";
                        }

                    }

                }

            }
        }


        public string ActulizarProducto(Producto e, string Tokens)
        {
            try
            {
                string json = e.ToJson();
                var cliente = new HttpClient();
                string TokenSinComillas = Tokens.Replace("\"", "");
                cliente.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", TokenSinComillas);
                var tarea = Task.Run
                (
                   async () =>
                   {
                       return await cliente.PutAsync(BaseUrl, new StringContent(json, Encoding.UTF8, "application/json"));
                   }
                );

                HttpResponseMessage Message = tarea.Result;

                if (Message.StatusCode == System.Net.HttpStatusCode.NoContent)
                {
                 

                    return "204";
                }

                if (Message.StatusCode == System.Net.HttpStatusCode.NotFound)
                {
                    return "404";
                }

                if (Message.StatusCode == System.Net.HttpStatusCode.BadRequest)
                {
                    var task2 = Task<string>.Run(async () =>
                    {
                        return await Message.Content.ReadAsStringAsync();
                    });
                    string resultSrt = task2.Result;
                    return resultSrt;
                }
                if (Message.StatusCode == System.Net.HttpStatusCode.Unauthorized)
                {
                    return "401";
                }
                if (Message.StatusCode == System.Net.HttpStatusCode.InternalServerError)
                {
                    return "500";
                }

                return "";


            }
            catch (Exception)
            {

                throw;
            }
        }


        public string EliminarProducto(string id, string tokens)
        {
            var cliente = new HttpClient();
            string TokenSinComillas = tokens.Replace("\"", "");
            cliente.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", TokenSinComillas);
            try
            {
                var tarea = Task.Run
              (
                 async () =>
               {
                        return await cliente.DeleteAsync(BaseUrl + "?id=" + id);
                    }
                      );

                HttpResponseMessage mensaje = tarea.Result;

                if (mensaje.StatusCode == System.Net.HttpStatusCode.OK)
                {
                 
                    return "201";
                }

                if (mensaje.StatusCode == System.Net.HttpStatusCode.NotFound)
                {
                    return "404";

                }
                if (mensaje.StatusCode == System.Net.HttpStatusCode.Unauthorized)
                {
                    return "401";

                }

                if (mensaje.StatusCode == System.Net.HttpStatusCode.InternalServerError)
                {
                    return "500";
                }

                return "";
            }
            catch (Exception)
            {

                throw;
            }
   
        }



    }
}
