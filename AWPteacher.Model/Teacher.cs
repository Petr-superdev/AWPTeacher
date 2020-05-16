using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;

namespace AWPteacher.Model
{
    [DisplayName("Учитель")]
    public class Teacher
    {
        static public List<Teacher> List { get; set; } = new List<Teacher>();

        public Guid Id { get; set; }
        public string Name { get; set; }
        public List<Subject> Subjects { get; set; }
        
    }
    public class TeacherMapping : ClassMap<Teacher>
    {
        public TeacherMapping()
        {
            Id(u => u.Id).GeneratedBy.Guid();
            Map(u => u.Name).Length(100);
            HasMany(u => u.Subjects);
        }
    }
}
