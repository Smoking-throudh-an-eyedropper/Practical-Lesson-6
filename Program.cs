using Practical_Lesson__6;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical_Lesson_6_Part_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Чтобы дабавить элемент в список введите [1]");
            int add = Convert.ToInt16(Console.ReadLine());
            var ListPerson = new List<Person>
            {
            };
            if (add==1)
            {
                ListPerson.Add(new Person(Convert.ToString(Console.ReadLine()), Convert.ToUInt16(Console.Read()), Convert.ToUInt16(Console.Read()), Convert.ToUInt16(Console.Read()), Convert.ToUInt16(Console.Read())));
                Console.WriteLine("Чтобы закончить добавление элементов в список введите [0]");
                add = Convert.ToInt16(Console.ReadLine());
            }
            else
            {
                if (add == 0)
                {
                    Console.WriteLine("Добавление элементов в список завершено");
                }  
            }
            var LongPeople = ListPerson.Where(l => l.Arms > 65 && l.Legs == 90)
                                       .Select(l => l.Name)
                                       .ToList();
            LongPeople.ForEach(p => Console.WriteLine(p));
            var HeadsPeople = ListPerson.Select(h => h.Head)
                                        .ToList();
            HeadsPeople.ForEach(h => Console.WriteLine(h));
        }
    }
}
