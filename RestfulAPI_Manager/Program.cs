using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestfulAPI_Manager
{
    class Program
    {
        static void Main(string[] args)
        {
            RestfulApi.Manager.Client.ApiServiceClient<Tester> client = new RestfulApi.Manager.Client.ApiServiceClient<Tester>("https://jsonplaceholder.typicode.com/todos/1");
            var result = client.Get();
            Console.WriteLine(result.Data != null ? result.Data.title : result.InternalException.Message);
            Console.ReadKey();
        }
    }
    public class Tester
    {
        public int userId { get; set; }
        public int id { get; set; }
        public string title { get; set; }
        public bool completed { get; set; }
    }
}
