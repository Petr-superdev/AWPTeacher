using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;

namespace AWPteacher.Model
{
    [DisplayName("Урок")]
    public class Lesson 
    {

        //
        public Guid Id { get; set; }
        //
        public DateTime DateTime { get; set; }
        //
        public string HomeWork { get; set; }

        //
        public ClassGroup Class { get; set; }
        //
        public Subject Subject { get; set; }
        //
        public Teacher Teacher { get; set; }

        
    }
    public class LessonMapping : ClassMap<Lesson>
    {
        public LessonMapping()
        {
            Id(u => u.Id).GeneratedBy.Guid();
            Map(u => u.DateTime);
            Map(u => u.HomeWork);
            References(u => u.Class).Cascade.SaveUpdate();
            References(u => u.Subject).Cascade.SaveUpdate();
            References(u => u.Teacher).Cascade.SaveUpdate();
        }
    }
}
