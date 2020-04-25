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

        //
        public Guid Id { get; set; }
        //
        public DateTime DateTime { get; set; }
        //
        public string HomeWork { get; set; }

        //
        public Class Class { get; set; }
        //
        public Subject Subject { get; set; }
        //
        public Teacher Teacher { get; set; }

        public Lesson() { }
        public Lesson(string homeWork)
        {
            Id = Guid.NewGuid();
            HomeWork = homeWork;
        }
        public Lesson(Guid id, string homeWork)
        {
            Id = id;
            HomeWork = homeWork;
        }

        public override string GetInfoForComboBox()
        {
            return DateTime.ToString() + " " + Subject;
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
            string path = Environment.CurrentDirectory + "\\LessonList.txt";

            var sr = new StreamReader(path);

            string homeWork;
            string id;
            while
            (
                (
                    (id = sr.ReadLine()) != null
                )
                &&
                (
                    (homeWork = sr.ReadLine()) != null
                )
            )
            {
                var class_ = new Lesson(new Guid(id),homeWork);
                List.Add(class_);
            }

            sr.Close();
        }
    }
}
