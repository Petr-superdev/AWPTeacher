using System;
using System.Collections.Generic;
using System.IO;
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
        public override void SaveListInTxt()
        {
            StreamWriter sw = new StreamWriter(Environment.CurrentDirectory + "//MarkList.txt");
            foreach (Mark mark in List)
            {
                sw.WriteLine(mark.Value);
            }
            sw.Close();
        }
    }
}
