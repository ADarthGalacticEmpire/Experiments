using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstCSharp
{
    /// <summary>
    ///  Constants are immutable values
    ///  which are known at complie time
    ///  and do not change during the life of the program.
    /// </summary>
    class Constants
    {
        /// <summary>
        /// constants as fields
        /// </summary>
        const double PI = 3.14159265359;
        const int weeks = 52, months = 12;
        const int days = 365;

        //create constant as a string with your birthday
        const string birthday = "11-02-1991";


        static void Main(string[] args)
        {

            //cannot change
            //days = 366;

            Console.WriteLine("My Birthday is always going to be : {0}", birthday);
            Console.ReadLine();
        }
    }
}
