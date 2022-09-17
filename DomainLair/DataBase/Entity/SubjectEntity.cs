using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLair.DataBase.Entity
{
    [Table("Subject")]
    public class SubjectEntity : IEntity
    {
        [Required]
        public int Id { get; set; }
        [Required]
        [MaxLength(100)]
        public string Subject { get; set; }
        
    }
}
