using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AWPteacher.Model
{
    public class Student : Model
    {
        static public List<Student> List { get; set; } = new List<Student>();

        public long Id { get; set; }
        public string Name { get; set; }
        public List<Mark> Marks { get; set; }

        public Student() { }

        public Student(string name)
        {
            Id = 0 /*TODO*/;
            Name = name;
        }
    }
}
