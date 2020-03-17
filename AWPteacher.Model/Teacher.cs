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

        public long Id { get; set; }
        public string Name { get; set; }
        public List<Subject> Subjects { get; set; }
        public Teacher() { }
        public Teacher(string name)
        {
            Id = 0 /*TODO*/;
            Name = name;
        }
        public Teacher(string name, long id)
        {
            Id = id;
            Name = name;
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
            StringReader sr = new StringReader(Environment.CurrentDirectory + "//ClassList.txt");
            for (int i = Convert.ToInt32(sr.ReadLine()); i > 0; i--)
            {
                string name = sr.ReadLine();
                string Id = sr.ReadLine();

                var teacher = new Teacher(name, Convert.ToInt64(Id));
                List.Add(teacher);
            }
        }
    }
}
