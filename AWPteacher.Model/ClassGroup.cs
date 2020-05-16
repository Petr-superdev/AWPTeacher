using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.ComponentModel;
using FluentNHibernate.Mapping;

namespace AWPteacher.Model
{
    [DisplayName("Класс")]
    public class ClassGroup
    {

        // ID
        public Guid Id { get; set; }
        // Наименование класса (Например, "7 Б")
        public string Name { get; set; }

        // Список уроков для всего класса
        // 1 * 
        public List<Lesson> Lessons { get; set; }
        // Список учеников этого класса
        // 1 * 
        public List<Student> Students { get; set; }
        // Список учебных предметов (Биология, Математика,  ...)
        // * * 
        public List<Subject> Subjects { get; set; }
        // Список учителей
        // * * 
        public List<Teacher> Teachers { get; set; }

    }
    
    public class ClassGroupMap : ClassMap<ClassGroup>
    {
        public ClassGroupMap()
        {
            Id(u => u.Id).GeneratedBy.Guid();
            Map(u => u.Name).Length(30);
            HasMany(u => u.Lessons);
            HasMany(u => u.Students);
            HasManyToMany(u => u.Subjects);
            HasManyToMany(u => u.Teachers);
        }
    }
}
