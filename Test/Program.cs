using System.Collections;
using System.Text;
using CollectionsVisualizer;
namespace Test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> strings = new List<string> { "Josh", "Amara", "Mum" };
            string[] str = { "Test", "eggs", "computer" };
            int[] nums = { 1, 2, 3 };
            bool[] bools = { true, false, false };
            
            Visualizer.Display(str);
            Visualizer.Display(strings);
            Visualizer.Display(nums);
            Visualizer.Display(bools);
        }
    }

}