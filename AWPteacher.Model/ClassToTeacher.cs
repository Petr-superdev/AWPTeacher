using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace AWPteacher.Model
{
    class ClassToTeacher: Model
    {
        public Guid IdClass { get; set; }
        public Guid IdTeacher { get; set; }
        static public List<ClassToTeacher> List { get; set; } = new List<ClassToTeacher>();
        
        public override void SaveListInTxt()
        {
            StreamWriter sw = new StreamWriter(Environment.CurrentDirectory + "\\ClassToTeacherList.txt");

            foreach (ClassToTeacher classToTeacher in List)
            {
                sw.WriteLine(IdClass);
                sw.WriteLine(IdTeacher);
            }
            sw.Close();
        }
        public override void LoadListFromTxt()
        {

            string path = Environment.CurrentDirectory + "\\ClassToTeacherList.txt";

            var sr = new StreamReader(path);

            string id_teacher;
            string id_class;
            while
            (
                (
                    (id_class = sr.ReadLine()) != null
                )
                &&
                (
                    (id_teacher = sr.ReadLine()) != null
                )
            )
            {
                var classToTeacher = new ClassToTeacher(new Guid(id_class), new Guid(id_teacher ));
                List.Add(classToTeacher);
            }

            sr.Close();

            
        }
        public ClassToTeacher(Guid id_class, Guid id_teacher)
        {
            IdClass = id_class;
            IdTeacher = id_teacher;
        }
    }
}
