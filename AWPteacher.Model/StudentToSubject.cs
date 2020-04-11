using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace AWPteacher.Model
{
    class StudentToSubject: Model
    {
        public Guid IdStudent { get; set; }
        public Guid IdSubject { get; set; }
        static public List<StudentToSubject> List { get; set; } = new List<StudentToSubject>();

        public override void SaveListInTxt()
        {
            StreamWriter sw = new StreamWriter(Environment.CurrentDirectory + "\\StudentToSubjectList.txt");

            foreach (StudentToSubject studentToSubject in List)
            {
                sw.WriteLine(IdStudent);
                sw.WriteLine(IdSubject);
            }
            sw.Close();
        }
        public override void LoadListFromTxt()
        {

            string path = Environment.CurrentDirectory + "\\StudentToSubjectList.txt";

            var sr = new StreamReader(path);

            string id_student;
            string id_subject;
            while
            (
                (
                    (id_student = sr.ReadLine()) != null
                )
                &&
                (
                    (id_subject = sr.ReadLine()) != null
                )
            )
            {
                var studentToSubject = new StudentToSubject(new Guid(id_student), new Guid(id_subject));
                List.Add(studentToSubject);
            }

            sr.Close();


        }
        public StudentToSubject(Guid id_student, Guid id_subject)
        {
            IdStudent = id_student;
            IdSubject = id_subject;
        }
    }
}
