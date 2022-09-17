using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLair.DataBase.Entity
{
    [Table("GroupTeacher")]
    public class GroupTeacherEntity : IEntity
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public TeacherEntity Teacher_Id { get; set; }
        [Required]
        public GroupEntity Group_Id { get; set; }

    }
}
