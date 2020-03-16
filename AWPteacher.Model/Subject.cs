using System;
using System.Collections.Generic;
using System.IO;
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
        public override void SaveListInTxt()
        {
            StreamWriter sw = new StreamWriter(Environment.CurrentDirectory + "//SubjectList.txt");
            foreach (Subject subject in List)
            {
                sw.WriteLine(subject.Id);
                sw.WriteLine(subject.Name);
            }
            sw.Close();
        }
    }
}
