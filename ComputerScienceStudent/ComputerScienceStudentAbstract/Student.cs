using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerScienceStudentAbstract
{
    abstract class Student
    {
        //this constructor will store the ata from the property
        public Student(string name, string id)
        {
            Name = name;
            ID = id;
        }

        //Property that will get and set the name and id
        public string Name { get; set; }
        public string ID { get; set; }

        //This method will be read-only
        public abstract double RequiredHours { get; }
    }
}
