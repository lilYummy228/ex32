using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex32
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> marksMeanings = new Dictionary<string, int>();

            AddValue(marksMeanings);

            while (true)
            {
                Console.Write("Введите значение оценки: ");
                string enteredMeaning = Console.ReadLine().ToUpper();

                if (marksMeanings.ContainsKey(enteredMeaning))
                {
                    Console.WriteLine($"{marksMeanings[enteredMeaning]} - {enteredMeaning}");
                }
                else
                {
                    Console.WriteLine("Такого значение нет...");
                }
            }
        }

        static void AddValue(Dictionary<string, int> marksMeanings)
        {
            marksMeanings.Add("ПРЕВОСХОДНО", 10);
            marksMeanings.Add("ОТЛИЧНО", 9);
            marksMeanings.Add("ПОЧТИ ОТЛИЧНО", 8);
            marksMeanings.Add("ОЧЕНЬ ХОРОШО", 7);
            marksMeanings.Add("ХОРОШО", 6);
            marksMeanings.Add("ПОЧТИ ХОРОШО", 5);
            marksMeanings.Add("ВЕСЬМА УДОВЛЕТВОРИТЕЛЬНО", 4);
            marksMeanings.Add("УДОВЛЕТВОРИТЕЛЬНО", 3);
            marksMeanings.Add("ПОЧТИ УДОВЛЕТВОРИТЕЛЬНО", 2);
            marksMeanings.Add("НЕУДОВЛЕТВОРИТЕЛЬНО", 1);
        }
    }
}
