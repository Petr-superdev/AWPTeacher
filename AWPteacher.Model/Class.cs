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

        public long Id { get; set; }
        public string Name { get; set; }

        public override void SaveListInTxt()
        {
            StreamWriter sw = new StreamWriter(Environment.CurrentDirectory+"//ClassList.txt");
            sw.WriteLine(List.Count);
            foreach (Class class_ in List)
            {
                sw.WriteLine(class_.Id);
                sw.WriteLine(class_.Name);
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
                var class_ = new Class(name, Id);
                List.Add(class_);
            }
            
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
