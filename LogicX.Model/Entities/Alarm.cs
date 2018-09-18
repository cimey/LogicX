using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicX.Model.Entities
{
    [Table("Alarm")]
    public class Alarm
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        public int OrderId { get; set; }

        [Required]
        public DateTime CreationDate { get; set; }

        [Required]
        public DateTime ActivationTime { get; set; }

        [ForeignKey("OrderId")]
        public virtual Order Order { get; set; }
    }
}
