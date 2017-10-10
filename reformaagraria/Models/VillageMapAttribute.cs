using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace reformaagraria.Models
{
    public class VillageMapAttribute
    {
        public VillageMapAttribute()
        {

        }

        [Required]
        [Key]
        [ForeignKey("Region")]
        public int RegionId { get; set; }

        public string Coordinate { get; set; }

        public double Size { get; set; }

        public StageOfBorderSettingProcess StageOfBorderSettingProcess { get; set; }

        public Status BorderSettingStatus { get; set; }

        public string Attachment { get; set; }
        
        public Region Region { get; set; }

    }
}
