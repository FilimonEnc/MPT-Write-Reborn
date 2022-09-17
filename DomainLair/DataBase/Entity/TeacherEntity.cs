using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLair.DataBase.Entity
{
    [Table("Teacher")]
    public class TeacherEntity : IEntity
    {
        [Required]
        public int Id { get; set; }
        [Required]
        [MaxLength(25)]
        public string FirstName { get; set; }
        [Required]
        [MaxLength(25)]
        public string LastName { get; set; }
        [Required]
        [MaxLength(25)]
        public string MiddleName { get; set; }
        [Required]
        [MaxLength(25)]
        public string Abbreviation { get; set; }
        
    }
}
