using System;

namespace stack_heap_2
{
    class Person
    {
        public string name;
        public int age;
    }
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person { name = "Vasya", age = 25 };
            Console.WriteLine($"1.{p.name} {p.age}\n");
            Person f = new Person();
            Change(ref f);
            Console.WriteLine($"2.{f.name} {f.age}\n");
        }
        static void Change (ref Person person)
        {
            person.name = "Andrei";
            person.age = 24;
            Console.WriteLine($"3.{person.name} {person.age}\n");
            person = new Person { name = "Igor", age = 28};
            Console.WriteLine($"4.{person.name} {person.age}\n");
        }
    }
}
