using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;

namespace AWPteacher.Model
{
    [DisplayName("Оценка")]
    public class Mark 
    {

        //
        public long Id { get; set; }
        //
        public byte Value { get; set; }

        //
        public Lesson Lesson { get; set; }
        //
        public Student Student { get; set; }
        //
        public Subject Subject { get; set; }
        //
        public Teacher Teacher { get; set; }

        
    }
    public class MarkMapping : ClassMap<Mark>
    {
        public MarkMapping()
        {
            Id(u => u.Id).GeneratedBy.Guid();
            Map(u => u.Value).Length(1);
            References(u => u.Lesson).Cascade.SaveUpdate();
            References(u => u.Student).Cascade.SaveUpdate();
            References(u => u.Subject).Cascade.SaveUpdate();
            References(u => u.Teacher).Cascade.SaveUpdate();
        }
    }
}
