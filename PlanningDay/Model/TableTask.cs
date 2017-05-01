using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace PlanningDay.Model
{
    public class TableTask
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [Required]
        public DateTime Date { get; set; }
        [Required]
        public DateTime Time { get; set; }
        [Required]
        [MaxLength(50)]
        public string Work { get; set; }
        [MaxLength(255)]
        public string Information { get; set; }
        public bool EveryDay { get; set; }
    }
}
