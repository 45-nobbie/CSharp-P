using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates_Events_Lambdas
{
    // TODO: declare the delegate type
    public delegate string MyDelegate(int arg1, int arg2);

    class Delegates 
    {
        // Delegates can be bound to instance members as well as
        // static class functions
        public static string instanceMethod1(int arg1, int arg2)
        {
            return ((arg1 + arg2) * arg1).ToString();
        }
    }

}
