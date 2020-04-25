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

        //
        public long Id { get; set; }
        //
        public byte Value { get; set; }

        //
        public Lesson Lesson { get; set; }
        //
        public Student Student { get; set; }
        //
        public Subject Subject { get; set; }
        //
        public Teacher Teacher { get; set; }

        public Mark() { }

        public Mark(byte value)
        {
            Value = value;
        }
        public override void SaveListInTxt()
        {
            StreamWriter sw = new StreamWriter(Environment.CurrentDirectory + "//MarkList.txt");
            sw.WriteLine(List.Count);
            foreach (Mark mark in List)
            {
                sw.WriteLine(mark.Value);
            }
            sw.Close();
        }
        public override string GetInfoForComboBox()
        {
            return "";
        }

        public override void LoadListFromTxt()
        {
            string path = Environment.CurrentDirectory + "\\MarkList.txt";

            var sr = new StreamReader(path);

            string value;
            while
            (
                (
                    (value = sr.ReadLine()) != null
                )
                
            )
            {
                var class_ = new Mark(Convert.ToByte(value));
                List.Add(class_);
            }

            sr.Close();
        }
    }
}
