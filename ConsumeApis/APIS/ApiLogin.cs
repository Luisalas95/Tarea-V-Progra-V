using ConsumeApis.Clases;
using Newtonsoft.Json;
using QuickType;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace ConsumeApis.APIS
{
    public class ApiLogin
    {
        private const string BaseUrl = "http://localhost:56108/api/LoginUsuarios";
        public ApiLogin() { }

        public string LoginConsulta(LoginUsuario usuario)
        {
            string retorno = "";
            try
            {
                string json = usuario.ToJson();
                using (var usur = new HttpClient())
                {
                    var task1 = Task.Run(async () =>
                    {
                        string url = BaseUrl + "/LoginUsuario";
                        return await usur.PostAsync(url, new StringContent(json, Encoding.UTF8, "application/json")
                        );

                    }
                        );
                    HttpResponseMessage Message = task1.Result;
                    if (Message.StatusCode == System.Net.HttpStatusCode.Created)
                    {
                        var task2 = Task<string>.Run(async () =>
                        {
                            return await Message.Content.ReadAsStringAsync();
                        });
                        string resultSrt = task2.Result;
                        return retorno = "201" + "/" + resultSrt;
                    }

                    if (Message.StatusCode == System.Net.HttpStatusCode.NotFound)
                    {
                        return retorno = "404";
                    }
                    if (Message.StatusCode == System.Net.HttpStatusCode.InternalServerError)
                    {

                        return retorno = "500";

                    }

                }


            }
            catch (Exception)
            {

                throw;
            }
            return retorno;
        }

        public string CrearUsuario(Usuarios usuario)
        {
            string retorno = "";
            try
            {
                string json = usuario.ToJson();
                
                using (var usur = new HttpClient())
                {
                    var task1 = Task.Run(async () =>
                    {
                        
                        return await usur.PostAsync(BaseUrl, new StringContent(json, Encoding.UTF8, "application/json")
                        );

                    }
                        );
                    HttpResponseMessage Message = task1.Result;
                    if (Message.StatusCode == System.Net.HttpStatusCode.Created)
                    {
               
                        return retorno = "201";
                    }

                    if (Message.StatusCode == System.Net.HttpStatusCode.Conflict)
                    {
                        return retorno = "409";
                    }
                    if (Message.StatusCode == System.Net.HttpStatusCode.InternalServerError)
                    {

                        return retorno = "500";

                    }

                }


            }
            catch (Exception)
            {

                throw;
            }
            return retorno;
        }











    }
}
