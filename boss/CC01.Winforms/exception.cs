using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CC01.Winforms
{
 public   class exception :Exception
    {
        public exception()
        {

        }
        public exception(string message) : base(message)
        {

        }
        public exception(string message, Exception innerException) : base(message, innerException)
        {

        }
    }
}
