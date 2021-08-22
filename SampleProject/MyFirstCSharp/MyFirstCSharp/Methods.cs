using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstCSharp
{
    class Methods
    {



    }




    //List parameters with type
    
    
    static void Main (string[] args)
    {
        //int total = Addition(56,29);
        Console.WriteLine(Addition(56,29));
        Console.Read();
    }
    
    
    public static int Addition(int num1, int num2)
    {

        int total = num1 + num2;
        return total;
    }
}
