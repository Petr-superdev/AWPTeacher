using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AWPteacher.Model
{
    public class Class : Model
    {
        static public List<Class> List { get; set; } = new List<Class>();

        public long Id { get; set; }
        public string Name { get; set; }

        public Class(){}

        public Class(string name)
        {
            Id = 0 /*TODO*/;
            Name = name;
        }
    }
}
