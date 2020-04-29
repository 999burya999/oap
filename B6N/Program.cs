using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B6N
{
    class Program
    {
        static void Main(string[] args)
        {
            int count;
            int age;
            int minAge = 0;
            int maxAge = 0;
            double avgAge = 0.00;
            Console.WriteLine("Сколько человек посетило зал?");
            count = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine();
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine("Введите возраст " + (i + 1) + " клиента:");
                age = Convert.ToInt16(Console.ReadLine());
                Class1 gym = new Class1(age);
                minAge = gym.MinAgeClient;
                maxAge = gym.MaxAgeClient;
                avgAge = gym.Srpos;
            }

            Console.WriteLine("\nМаксимальный возраст посетителя: "+minAge+ "\nМинимальный возраст посетителя: " + maxAge+ "\nСредний возраст посетителей: " + avgAge+"\n");
            Console.ReadLine();
        }
    }
}
