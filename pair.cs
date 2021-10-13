using System;
using System.Collections.Generic;
using System.Text;

namespace Daily_Coding_Problem_5
{
    class pair
    {
        int FirstElement;
        int SecondElement;

        public pair(int a,int b)
        {
            FirstElement = a;
            SecondElement = b;
        }
        public int GetFirstElement()
        {
            return FirstElement;
        }
        public int GetSecondElement()
        {
            return SecondElement;
        }
    }
}
