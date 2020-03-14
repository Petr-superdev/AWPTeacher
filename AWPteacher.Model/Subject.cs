using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AWPteacher.Model
{
    public class Subject:Model
    {
        static public List<Subject> List { get; set; } = new List<Subject>();

        public long Id { get; set; }
        public string Name { get; set; }
        public Subject() { }
        public Subject(string name)
        {
            Id = 0 /*TODO*/;
            Name = name;
        }
    }
}
