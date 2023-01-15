using System;
using System.Collections.Generic;

namespace CollectionsVisualizer
{
    public class Visualizer
    {
        public static void Display(string[] strArr)
        {
            foreach (var item in strArr)
            {
                Console.Write($"[{item},]");
            }
        }

        public static void Display(List<string> strArr)
        {
            foreach (var item in strArr)
            {
                Console.Write($"[{item},]");
            }
        }

    }
}
