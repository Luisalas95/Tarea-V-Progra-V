using ConsumeApis.Clases;
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

        public List<Login> LoginConsulta(string id)
        {
            try
            {

                List<Login> E2 = new List<Login>();
                using (var estudian = new HttpClient())
                {

                    var task1 = Task.Run(async () =>
                    {
                        string url = BaseUrl + "/";
                        return await estudian.GetAsync(url+id);
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
                        E2 = Login.FromJson(resultSrt);
                    }

                    if (Message.StatusCode == System.Net.HttpStatusCode.NotFound)
                    {
                        E2 = null;
                    }
                    return E2;
                }
            }
            catch (Exception)
            {

                throw;
            }

        }




        public List<Login> TodoLogin()
        {
            try
            {
                List<Login> E2 = new List<Login>();
                using (var logins = new HttpClient())
                {

                    var task1 = Task.Run(async () =>
                    {
                        string url = BaseUrl + "/";
                        return await logins.GetAsync(url);
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
                        E2 = Login.FromJson(resultSrt);
                    }

                    if (Message.StatusCode == System.Net.HttpStatusCode.NotFound)
                    {
                        E2 = null;
                    }
                    return E2;
                }

            }
            catch (Exception)
            {

                throw;
            }

        }










    }
}
