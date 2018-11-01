using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BDDProject.CustomException
{
    class NoSuitableDriverFound : Exception
    {
        public NoSuitableDriverFound(string msg): base(msg)
        {


        }


    }
}
