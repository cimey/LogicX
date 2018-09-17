using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicX.Model.Entities
{

    public enum CoffeePreparationTimeEnum : short
    {

        OneMinuteCoffee = 1,
        ThreeMinutesCoffe = 3
    }

    [Table("Coffee")]
    public class Coffee
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public CoffeePreparationTimeEnum PreparationTime { get; set; }
    }
}
