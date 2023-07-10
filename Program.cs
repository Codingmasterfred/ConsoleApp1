namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                StartSequence();
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
            }
            finally
            {
                Console.WriteLine("Finally block executed.");
            }
        }

        static void StartSequence()
        {
            int[] MainArray = new int[6];
            try
                {
                        Console.WriteLine("Enter a number greater than zero:");
                    for (int i = 0; i < 6; i++)
                    {
                        int size = Convert.ToInt32(Console.ReadLine());

                        if (size <= 0)
                        {
                            Console.WriteLine("The number must be greater than zero.");
                        return;
                        }

                        if (size > 0)
                    {
                        Console.WriteLine("Enter another number.");
                    }

                        MainArray[i] = size;
                        Console.WriteLine("Array created successfully with size: " + MainArray);
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid input. Please enter a valid number.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("An error occurred: " + ex.Message);
                }
                finally
                {
                    Console.WriteLine("Finally block executed.");
                }
          
        }
    }
}