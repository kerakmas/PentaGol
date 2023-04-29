using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PentaGol.Service.Exceptions
{
    public class PentaGolException : Exception
    {
        public int Code { get; set; }
        public PentaGolException(int code = 500, string message = "Something went wrong") : base(message)
        {
            this.Code = code;
        }
    }
}
