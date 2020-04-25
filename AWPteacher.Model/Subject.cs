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

        public Guid Id { get; set; }
        public string Name { get; set; }
        public Subject() { }
        public Subject(string name)
        {
            Id = Guid.NewGuid(); 
            Name = name;
        }
        public Subject(string name, Guid id)
        {
            Id = id;
            Name = name;
        }

        public override string GetInfoForComboBox()
        {
            return "";
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
            string path = Environment.CurrentDirectory + "\\SubjectList.txt";

            var sr = new StreamReader(path);

            string name;
            string id;
            while
            (
                (
                    (id = sr.ReadLine()) != null
                )
                &&
                (
                    (name = sr.ReadLine()) != null
                )
            )
            {
                var class_ = new Subject(name, new Guid(id));
                List.Add(class_);
            }

            sr.Close();
        }
    }
}
