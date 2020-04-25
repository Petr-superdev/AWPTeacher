using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace AWPteacher.Model
{
    public class Teacher:Model
    {
        static public List<Teacher> List { get; set; } = new List<Teacher>();

        public Guid Id { get; set; }
        public string Name { get; set; }
        public List<Subject> Subjects { get; set; }
        public Teacher() { }
        public Teacher(string name)
        {
            Id = new Guid();
            Name = name;
        }
        public Teacher(string name, Guid id)
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
            StreamWriter sw = new StreamWriter(Environment.CurrentDirectory + "//TeacherList.txt");
            sw.WriteLine(List.Count);
            foreach (Teacher teacher in List)
            {
                sw.WriteLine(teacher.Id);
                sw.WriteLine(teacher.Name);
            }
            sw.Close();
        }

        public override void LoadListFromTxt()
        {
            string path = Environment.CurrentDirectory + "\\ClassList.txt";

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
                var class_ = new Teacher(name, new Guid(id));
                List.Add(class_);
            }

            sr.Close();
        }
    }
}
