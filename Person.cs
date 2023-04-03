using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical_Lesson__6
{
    internal class Person
    {
        private string _name;
        private uint _head;
        private uint _torso;
        private uint _arms;
        private uint _legs;
        public string Name 
        { 
            get { return _name; }
            private set { _name = value; }
        }
        public uint Head
        {
            get { return _head; }
            private set { _head = value; }
        }
        public uint Torso
        {
            get { return _torso; }
            private set { _torso = value; }
        }
        public uint Arms
        {
            get { return _arms; }
            private set { _arms = value; }
        }
        public uint Legs
        {
            get { return _legs; }
            private set { _legs = value; }
        }
        public Person(string name, uint head, uint torso, uint arms, uint legs)
        {
            if (name == null)
                throw new NullReferenceException("Name");
            Name = name;
            Head = head;
            Torso = torso;
            Arms = arms;
            Legs = legs;
        }
        public void Read()
        {
            Console.WriteLine("Укажите имя человека:");
            Name = Convert.ToString(Console.Read());
            Console.WriteLine("Укажите обхват головы человека:");
            Head = Convert.ToUInt16(Console.Read());
            Console.WriteLine("Укажите длину тела человека:");
            Torso = Convert.ToUInt16(Console.Read());
            Console.WriteLine("Укажите длину рук человека:");
            Arms = Convert.ToUInt16(Console.Read());
            Console.WriteLine("Укажите длину ног человека:");
            Legs = Convert.ToUInt16(Console.Read());
            Console.WriteLine("");
        }
        public void Display()
        {
            Console.WriteLine("Person");
            Console.WriteLine($"Name:{Name}");
            Console.WriteLine($"Head:{Head}");
            Console.WriteLine($"Torso:{Torso}");
            Console.WriteLine($"Arms:{Arms}");
            Console.WriteLine($"Legs:{Legs}");
        }
    }
}
