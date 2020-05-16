using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;

namespace AWPteacher.Model
{
    [DisplayName("Предмет")]
    public class Subject
    {

        public Guid Id { get; set; }
        public string Name { get; set; }
        
    }
    public class SubjectMapping : ClassMap<Subject>
    {
        public SubjectMapping()
        {
            Id(u => u.Id).GeneratedBy.Guid();
            Map(u => u.Name).Length(100);
        }
    }
}
