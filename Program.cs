namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            PrepWork();
        }
        static void PrepWork()
        {
            Console.WriteLine("PrepWork");
            int[] nums = new int[5];
            for(int i = 0; i < nums.Length; i++)
            {
                nums[i] = Int32.Parse(Console.ReadLine());
            }
        }
       
    }
}