using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicX.Model.Entities
{
    public enum LogType : short
    {
        Error = 1, 
        Information = 2, 
        Diagnostic =3,
        AliveSignal = 4,
        Confirmation = 5,
        Acknowledgement = 6
    }
    [Table("Log")]
    public class Log
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [MaxLength(Int32.MaxValue)]
        [Required]
        public string Message { get; set; }

        [Required]
        public DateTime CreationDate { get; set; }

        [Required]
        public LogType LogType { get; set; }
    }
}
