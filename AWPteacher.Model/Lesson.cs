using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace AWPteacher.Model
{
    public class Lesson : Model
    {
        static public List<Lesson> List { get; set; } = new List<Lesson>();
        public long Id { get; set; }
        public string HomeWork { get; set; }
        public Lesson() { }
        public Lesson(string homeWork)
        {
            Id = 0 /*TODO*/;
            HomeWork = homeWork;
        }
        public Lesson(long id, string homeWork)
        {
            Id = id;
            HomeWork = homeWork;
        }
        public override void SaveListInTxt()
        {
            StreamWriter sw = new StreamWriter(Environment.CurrentDirectory + "//LessonList.txt");
            sw.WriteLine(List.Count());
            foreach (Lesson lesson in List)
            {
                sw.WriteLine(lesson.Id);
                sw.WriteLine(lesson.HomeWork);
            }
            sw.Close();
        }

        public override void LoadListFromTxt()
        {
            StringReader sr = new StringReader(Environment.CurrentDirectory + "//ClassList.txt");
            for (int i = Convert.ToInt32(sr.ReadLine()); i > 0; i--)
            {
                string name = sr.ReadLine();
                long Id = Convert.ToInt64(sr.ReadLine());
                var lesson = new Lesson(Id ,name );
                List.Add(lesson);
            }
        }
    }
}
