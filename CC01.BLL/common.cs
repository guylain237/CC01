using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CC01.BLL
{
   public static  class common
    {
        public static void writetofile(this Exception ex)
        {
            using (StreamWriter sw = new StreamWriter("app.log", true))
            {
                sw.WriteLine(
                   $"{ DateTime.Now}\n{ex}\n"
                    );

            }

        }
    }
}
