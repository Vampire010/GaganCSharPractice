using System;
namespace app
{
    class unaryOprtrEx
    {
           static void Test1(string[] args)
            {
                int a=1;
                int b = 200;
                int c = 400;
                double d = 999;
                
                Console.WriteLine("Unary Operators");
                //Postfix increment operator
                Console.WriteLine("Postfix increment operator:  " + a++) ;          
                Console.WriteLine(a);

                Console.WriteLine(++b);

                Console.WriteLine(c--);
                Console.WriteLine(c);
                Console.WriteLine(--d);

            } 

    }
}