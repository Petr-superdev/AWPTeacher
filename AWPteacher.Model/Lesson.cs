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
        public override void SaveListInTxt()
        {
            StreamWriter sw = new StreamWriter(Environment.CurrentDirectory + "//LessonList.txt");
            foreach (Lesson lesson in List)
            {
                sw.WriteLine(lesson.Id);
                sw.WriteLine(lesson.HomeWork);
            }
            sw.Close();
        }
    }
}
