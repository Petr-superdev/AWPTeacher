using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace AWPteacher.Model
{
    public class Student : Model
    {
        static public List<Student> List { get; set; } = new List<Student>();

        public long Id { get; set; }
        public string Name { get; set; }
        public List<Mark> Marks { get; set; }

        public Student() { }

        public Student(string name)
        {
            Id = 0 /*TODO*/;
            Name = name;
        }
        public Student(string name,long id)
        {
            Id = id;
            Name = name;
        }
        public override void SaveListInTxt()
        {
            StreamWriter sw = new StreamWriter(Environment.CurrentDirectory + "//StudentList.txt");
            sw.WriteLine(List.Count);
            foreach (Student student in List)
            {
                sw.WriteLine(student.Id);
                sw.WriteLine(student.Name);
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

                var student = new Student(name, Convert.ToInt64(Id));
                List.Add(student);
            }
        }
    }
}
