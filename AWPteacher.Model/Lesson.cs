using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AWPteacher.Model
{
    public class Lesson : Model
    {
        static public List<Lesson> List { get; set; } = new List<Lesson>();
        public long Id { get; set; }
        public string HomeWork { get; set; }
        public Lesson() { }
        public Lesson(string hw)
        {
            Id = 0 /*TODO*/;
            HomeWork = hw;
        }
    }
}
