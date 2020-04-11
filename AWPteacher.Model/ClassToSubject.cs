using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace AWPteacher.Model
{
    class ClassToSubject: Model
    {
        public Guid IdClass { get; set; }
        public Guid IdSubjects { get; set; }
        static public List<ClassToSubject> List { get; set; } = new List<ClassToSubject>();

        public override void SaveListInTxt()
        {
            StreamWriter sw = new StreamWriter(Environment.CurrentDirectory + "\\ClassToSubjectList.txt");

            foreach (ClassToSubject classToSubject in List)
            {
                sw.WriteLine(IdClass);
                sw.WriteLine(IdSubjects);
            }
            sw.Close();
        }
        public override void LoadListFromTxt()
        {

            string path = Environment.CurrentDirectory + "\\ClassToSubjectsList.txt";

            var sr = new StreamReader(path);

            string id_subjects;
            string id_class;
            while
            (
                (
                    (id_class = sr.ReadLine()) != null
                )
                &&
                (
                    (id_subjects = sr.ReadLine()) != null
                )
            )
            {
                var classToSubject = new ClassToSubject(new Guid(id_class), new Guid(id_subjects));
                List.Add(classToSubject);
            }

            sr.Close();


        }
        public ClassToSubject(Guid id_class, Guid id_teacher)
        {
            IdClass = id_class;
            IdSubjects = id_teacher;
        }
    }
}
