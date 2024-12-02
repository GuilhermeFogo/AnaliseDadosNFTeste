using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Doman.Handeler
{
    public class ErroExeption : Exception
    {
        public ErroExeption(string message)
            :base(message) 
        {
            
        }

        
    }
}
