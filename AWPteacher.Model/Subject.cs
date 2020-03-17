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
        public Subject(string name, long Id)
        {
            Id = 0 /*TODO*/;
            Name = name;
        }
        public override void SaveListInTxt()
        {
            StreamWriter sw = new StreamWriter(Environment.CurrentDirectory + "//SubjectList.txt");
            sw.WriteLine(List.Count);
            foreach (Subject subject in List)
            {
                sw.WriteLine(subject.Id);
                sw.WriteLine(subject.Name);
            }
            sw.Close();
        }

        public override void LoadListFromTxt()
        {
            StringReader sr = new StringReader(Environment.CurrentDirectory + "//ClassList.txt");
            for (int i = Convert.ToInt32(sr.ReadLine()); i > 0; i--)
            {
                string name = sr.ReadLine();
                string Id = sr.ReadLine();

                var subject = new Subject(name, Convert.ToInt64(Id));
                List.Add(subject);
            }
        }
    }
}
