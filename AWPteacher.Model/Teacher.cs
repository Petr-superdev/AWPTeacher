using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AWPteacher.Model
{
    public class Teacher:Model
    {
        static public List<Teacher> List { get; set; } = new List<Teacher>();

        public long Id { get; set; }
        public string Name { get; set; }
        public List<Subject> Subjects { get; set; }
        public Teacher() { }
        public Teacher(string name)
        {
            Id = 0 /*TODO*/;
            Name = name;
        }
    }
}
