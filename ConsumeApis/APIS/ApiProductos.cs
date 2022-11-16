using Newtonsoft.Json.Linq;
using QuickType2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
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



    }
}
