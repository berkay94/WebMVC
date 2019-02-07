using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebApp2.Models
{
    public class Teacher:BaseEntity
    {
       

        [DisplayName("Eğitmen Adı")]
        [StringLength(50)]
        public string Name { get; set; }

        [DisplayName("Eğitmen Soyadı")]
        [StringLength(50)]
        public string SurName { get; set; }


        [DisplayName("Eğitmen Branşı")]
        [StringLength(50)]
        public string Brans { get; set; }


        public virtual ICollection<ClassRoom> Classrooms{ get; set; }


        
    }
}