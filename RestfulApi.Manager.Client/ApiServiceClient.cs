using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;

namespace RestfulApi.Manager.Client
{
    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="T">this parameter is used to get the return value</typeparam>
    public class ApiServiceClient<T>
    {
        public string _url { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="url">Set url of api service</param>
        public ApiServiceClient(string url)
        {
            _url = url;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns>This function is uset to get value</returns>
        public ServiceResponse<T> Get()
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    var response = client.GetAsync(_url).Result;
                    var serialize = new JavaScriptSerializer();
                    var result = serialize.Deserialize<T>(response.Content.ReadAsStringAsync().Result);
                    return new ServiceResponse<T>()
                    {
                        Data = result
                    };
                }
            }
            catch (Exception ex)
            {
                return new ServiceResponse<T>()
                {
                    InternalException = new Exception(ex.Message)
                };
            }
        }
    }
}
