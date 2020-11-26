using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CC01.BLL
{
  public  class MesException :Exception
    {
       public MesException(): base() {
        }
        public MesException(string message) : base(message)
        {

        }
        public MesException(string message, Exception innerException) : base(message, innerException)
        {

        }
    }
}
