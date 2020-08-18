using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesWeb.Services.Exceptions
{
    public class NotFoundException : ApplicationException
    {
        //passar essa mensagem para a classe base
        public NotFoundException (string message) : base(message)
        {
        }
    }
}
