using System;

namespace myDemoApp
{
    class Program
    {
        static void Main(string[] args)
        {

            for (int i = 1; i <= 10; i++)
            {
                if(i%2 == 0)
                {
                    Console.WriteLine(i + " " +  "cut");
                }
                else
                {
                    Console.WriteLine(i + " " + "tek");
                }
            }
           

        }
    }
}
