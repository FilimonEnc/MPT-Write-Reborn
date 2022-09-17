using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLair.DataBase.Entity
{
    [Table("Group")]
    public class GroupEntity : IEntity
    {
        [Required]
        public int Id { get; set; }

        [Required]
        [MaxLength(25)]
        public string GroupName { get; set; }
        
        
    }
}
