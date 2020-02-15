using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AWPteacher.Model
{
    public class Teacher
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public List<Subject> Subjects { get; set; }
    }
}
