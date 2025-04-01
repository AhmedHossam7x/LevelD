using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LevelD.Delegates
{
    public static class Delegates
    {
        static public string EngToFrench(string input)
        {
            return "Bonjour";
        }
        static public string EngToSpanish(string input)
        {
            return "Hola";
        }
        static public string EngToGerman(string input)
        {
            return "Hallo";
        }
        // === //
        public static List<int> GetFilteredValues(List<int> values, int x, del op)
        {
            List<int> result = new List<int>();
            foreach (var value in values)
            {
                if (op(value, x))
                    result.Add(value);
            }
            return result;
        }
        static public bool IsGreaterThan(int a, int b)
        {
            return a > b;
        }
        static public bool IsLessThan(int a, int b)
        {
            return a < b;
        }
    }
}
