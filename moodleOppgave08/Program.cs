using System.ComponentModel.Design;

namespace moodleOppgave08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write a number:");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("I need more:");
            int num2 = Convert.ToInt32(Console.ReadLine());

            static bool checkIf30(int num1, int num2)
            {
                if ((num1 == 30) || (num2 == 30))
                {
                    return true;
                }
                else if ((num1 + num2) == 30)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            Console.WriteLine($"Is one of these numbers or both combined is equal to 30?: {checkIf30(num1, num2)}");
        }
    }
}