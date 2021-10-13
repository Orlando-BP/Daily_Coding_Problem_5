using System;

namespace Daily_Coding_Problem_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 3;
            int b = 4;
            Console.WriteLine(car(cons(a,b)));
            Console.WriteLine(cdr(cons(a,b)));
        }
        static pair cons(int a, int b)
        {
            pair f;
            return f = new pair(a, b);
        }
        static int car(pair f)
        {
            return f.GetFirstElement();
        }
        static int cdr(pair f)
        {
            return f.GetSecondElement();
        }
    }
}
