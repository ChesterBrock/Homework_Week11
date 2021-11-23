using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_Week11
{
    class Program
    {
        static void Main(string[] args)
        {
            // creating the person object
            Person chad = new Person("Chad");

            // creating the truck object 
            Truck t1 = new Truck(Vehicle.manuName(manufracturerName.ford), 4, 3200.0, 2000);

            // displaying the toString
            // 
            Console.WriteLine(t1.toString() + "Owner [ " + chad.GetName() + " ] Manu [" + Vehicle.manuName(manufracturerName.ford) + "] ");

            Console.ReadLine();
        }
    }

    public class Person
    {
        private String name;
        public Person() { this.name = "John Doe"; }
        public Person(string theName) { name = theName; }
        public Person(Person obj) { this.name = obj.name; }
        public string GetName() { return this.name; }
        public void SetName(string name) { this.name = name; }
        public string ToString() { return "Name [ " + this.name + "] "; }
        public bool Equals(Object obj) 
        {
            if (obj == null || this.GetType() != obj.GetType())
            {
                return false;
            }
            Person that = (Person)obj;
            return this.name.Equals(that.name);
        }
    }
}
