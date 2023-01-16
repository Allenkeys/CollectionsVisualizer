using CollectionsVisualizer;
namespace Test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            List<string> strings = new List<string> { "Josh", "Amara", "Mum" };
            string[] str = { "Test", "eggs", "computer" };
            int[] nums = { 1, 2, 3 };
            Visualizer.Display(str);
            Visualizer.Display(strings);
            Visualizer.Display(nums);
        }
    }
}