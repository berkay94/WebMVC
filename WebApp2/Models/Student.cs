using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApp2.Models
{
    public class Student:BaseEntity
    {
        [StringLength(50)]
        [DisplayName("Öğrenci Adı")]
        public string Name { get; set; }


        [StringLength(50)]
        [DisplayName("Öğrenci Soyadı")]
        public string SurName { get; set; }


        [StringLength(20)]
        [DisplayName("Öğrenci Numarası")]
        public string StudentId { get; set; }


        public virtual ICollection<ClassRoom> Classrooms { get; set; }
    }
}