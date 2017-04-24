using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RunConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            LeetCode.Medium.Medium m = new LeetCode.Medium.Medium();
            LeetCode.Easy.Easy e = new LeetCode.Easy.Easy();
            //m.Divide(-2147483648, -1);

            var index = e.SearchInsert(new int[] { 1, 3,5,6 }, 2);
        }
    }
}
