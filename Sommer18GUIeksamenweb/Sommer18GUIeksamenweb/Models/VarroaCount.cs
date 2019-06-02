using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Sommer18GUIeksamenweb.Models
{
    public class VarroaCount
    {
        [Key]
        public int BeehiveId { get; set; }

        public string User { get; set; }

        [Required]
        [StringLength(18)]
        [Display(Name = "Beehive")]
        public string BeeHiveName { get; set; }

        [Required]
        public string Date { get; set; }

        [Required]
        [Display(Name = "Number of Varroa")]
        public int AmountOfVarroa { get; set; }

        [Required]
        [Display(Name = "Duration")]
        public int ObservedDays { get; set; }

        public string Note { get; set; }

    }
}
