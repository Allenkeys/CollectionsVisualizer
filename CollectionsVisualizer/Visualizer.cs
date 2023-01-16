using System;
using System.Collections.Generic;
using System.Text;

namespace CollectionsVisualizer
{
    public class Visualizer
    {
        public static void Display(string[] strArr)
        {
            try
            {
                StringBuilder stringBuilder = new StringBuilder();
                stringBuilder.Append("[");
                foreach (var item in strArr)
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

        public static void Display(List<string> strArr)
        {
            try
            {
                StringBuilder stringBuilder = new StringBuilder();
                stringBuilder.Append("[");
                foreach (var item in strArr)
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
