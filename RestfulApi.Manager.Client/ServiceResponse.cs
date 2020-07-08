using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestfulApi.Manager.Client
{
    public class ServiceResponse<T>
    {
        public Exception InternalException { get; set; }
        public T Data { get; set; }
    }
}
