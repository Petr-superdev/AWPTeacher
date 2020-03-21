using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace AWPteacher.Model
{
    public class Class : Model
    {
        static public List<Class> List { get; set; } = new List<Class>();

        // ID
        public long Id { get; set; }
        // Наименование класса (Например, "7 Б")
        public string Name { get; set; }

        // Список уроков для всего класса
        public List<Lesson> Lessons { get; set; }
        // Список учеников этого класса
        public List<Student> Students { get; set; }
        // Список учебных предметов (Биология, Математика,  ...)
        public List<Subject> Subjects { get; set; }
        // Список учителей
        public List<Teacher> Teachers { get; set; }

        public override void SaveListInTxt()
        {
            StreamWriter sw = new StreamWriter(Environment.CurrentDirectory+"\\ClassList.txt");
            
            foreach (Class class_ in List)
            {
                sw.WriteLine(class_.Id);
                sw.WriteLine(class_.Name);
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
                var class_ = new Class(name, Convert.ToInt64(id));
                List.Add(class_);
            }

            sr.Close();
        }

        public Class(){}

        public Class(string name)
        {
            Id = 0 /*TODO*/;
            Name = name;
        }
        public Class(string name,long id)
        {
            Id = id;
            Name = name;
        }
    }
}
