using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;

namespace AWPteacher.Model
{
    [DisplayName("Ученик")]
    public class Student  
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public ClassGroup Class { get; set; }
        public List<Mark> Marks { get; set; }

        
    }
    public class StudentMapping : ClassMap<Student>
    {
        public StudentMapping()
        {
            Id(u => u.Id).GeneratedBy.Guid();
            Map(u => u.Name).Length(100);
            References(u => u.Class).Cascade.SaveUpdate();
            HasMany(u => u.Marks);

        }
    }
}
