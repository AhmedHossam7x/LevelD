using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LevelD.Delegate_Chains
{
    public class DelegateChains
    {
        public static void MethodOne(string input)
        {
            Console.WriteLine($"Method 1 {input}");
        }
        public static void MethodTwo(string input)
        {
            Console.WriteLine($"Method 2 {input}");
        }
        public static void MethodThree(string input)
        {
            Console.WriteLine($"Method 3 {input}");
        }
    }
}
