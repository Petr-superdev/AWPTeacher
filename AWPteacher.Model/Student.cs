using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AWPteacher.Model
{
    public class Student
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public List<Mark> Marks { get; set; }
    }
}
