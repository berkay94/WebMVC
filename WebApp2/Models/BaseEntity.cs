using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApp2.Models
{
    public class BaseEntity
    {
        public int Id{ get; set; }
        [DisplayName("Oluşturma Tarihi")]
        [DataType(DataType.Date)]

        public DateTime CreateDate { get; set; }
        [DisplayName("Güncelleme Tarihi")]
        [DataType(DataType.Date)]


        public DateTime UpdateDate { get; set; }
    }
}