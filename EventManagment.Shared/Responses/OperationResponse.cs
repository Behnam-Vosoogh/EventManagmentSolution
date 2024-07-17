using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventManagment.Shared.Responses
{
    public class OperationResponse<T>
    {
        public string Message { get; set; }
        public T Record { get; set; }

    }
}
