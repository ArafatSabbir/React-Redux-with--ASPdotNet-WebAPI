using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ESchool.API.Models
{
    public class Student
    {
        [Key]
        public int Id { get; set; }

        [Column(TypeName = "nvarchar(50)")]
        public string FullName  { get; set; }

        [Column(TypeName = "nvarchar(14)")]
        public string Mobile { get; set; }

        [Column(TypeName = "nvarchar(20)")]
        public string Grade { get; set; }


    }
}
