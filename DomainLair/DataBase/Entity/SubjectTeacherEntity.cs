using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLair.DataBase.Entity
{
    [Table("SubjectTeacher")]
    public class SubjectTeacherEntity : IEntity
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public TeacherEntity Teacher_Id { get; set; }
        [Required]
        public SubjectEntity Subject_Id { get; set; }
    }
}
