using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _13._09._2023_dz
{
    internal class Person : IModel
    {
        
        public string Name { get; set; }
        public int Age { get; set; }
        public Person() { }
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }
    }
    internal class Info
    {
        List<Person> list = new List<Person>();
        
        public void AddInfo(Person person)
        {
            list.Add(person);
        }
        public void DeleteInfo()
        {
            list.Clear();
        }
    }
    internal class SaveToFile
    {

    }
}