using System;
using System.Collections.Generic;
using System.Text;

namespace CollectionsVisualizer
{
    public class Visualizer
    {
        public static void Display(IEnumerable<string> strArr)
        {
            try
            {
                StringBuilder stringBuilder = new StringBuilder();
                stringBuilder.Append("[");
                foreach (var item in strArr)
                {
                    stringBuilder.Append($" \"{item}\",");
                }
                stringBuilder.Append(" ]");
                Console.WriteLine(stringBuilder.ToString());
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public static void Display(IEnumerable<int> intArr)
        {
            try
            {
                StringBuilder stringBuilder = new StringBuilder();
                stringBuilder.Append("[");
                foreach (var item in intArr)
                {
                    stringBuilder.Append($" {item},");
                }
                stringBuilder.Append(" ]");
                Console.WriteLine(stringBuilder.ToString());
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

    }
}
