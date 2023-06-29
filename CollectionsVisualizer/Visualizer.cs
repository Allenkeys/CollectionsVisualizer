using System;
using System.Collections.Generic;
using System.Text;

namespace CollectionsVisualizer
{
    public class Visualizer
    {
        public static void Display<T>(IEnumerable<T> values) where T : IConvertible
        {
            try
            {
                StringBuilder stringBuilder = new StringBuilder();
                stringBuilder.Append("[");
                if (typeof(T) == typeof(int))
                {
                    foreach (var item in values)
                    {
                        stringBuilder.Append($" {item},");
                    }
                }
                else
                {
                    foreach (var item in values)
                    {
                        stringBuilder.Append($" \"{item}\",");
                    }
                }

                stringBuilder.Append(" ]");
                Console.WriteLine(stringBuilder.ToString());
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

    }
}
