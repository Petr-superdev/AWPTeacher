using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AWPteacher.Model
{
    public class Mark : Model
    {
        static public List<Mark> List { get; set; } = new List<Mark>();
        public byte Value { get; set; }

        public Mark() { }

        public Mark(byte value)
        {
            Value = value;
        }
    }
}
