using System;

namespace chapter2._2_9
{
    class Program
    {
        static void Main(string[] args)
        {
            Nullable<int> noValue = new Nullable<int>();
            object noValueBoxed = noValue;
            Console.WriteLine(noValueBoxed == null);

            Nullable<int> someValue = new Nullable<int>(5);
            object someValueBoxed = someValue;
            Console.WriteLine(someValueBoxed.GetType());
            Console.ReadKey();
        }
    }
}

