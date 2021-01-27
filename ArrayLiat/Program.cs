using System;
using System.Collections;

namespace ArrayLiat
{
    class Program
    {
        static void Main(string[] args)
        {
          ArrayList myValue = new ArrayList();
            myValue.Add(10);
            myValue.Add("this is a pen");
            myValue.Add(10.23);
            foreach (var value in myValue)
            {
                Console.WriteLine(value);

            }
            {

            }

        }
    }
}
