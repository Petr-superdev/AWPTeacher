using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;

namespace AWPteacher.Model
{
    [DisplayName("Ученик")]
    public class Student : Model
    {
        static public List<Student> List { get; set; } = new List<Student>();

        public Guid Id { get; set; }
        public string Name { get; set; }
        public Class Class { get; set; }
        public List<Mark> Marks { get; set; }

        public Student() { }

        public Student(string name)
        {
            Id = Guid.NewGuid(); 
            Name = name;
        }
        public Student(string name, Guid id)
        {
            Id = id;
            Name = name;
        }
        public override List<Model> GetList()
        {
            List<Model> modelList = new List<Model>();
            foreach (var item in List)
            {
                modelList.Add(item);
            }
            return modelList;
        }

        public override string GetInfoForComboBox()
        {
            return Name;
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
            string path = Environment.CurrentDirectory + "\\StudentList.txt";

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
                var class_ = new Student(name, new Guid(id));
                List.Add(class_);
            }

            sr.Close();
        }
    }
}
