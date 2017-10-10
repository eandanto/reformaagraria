using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace reformaagraria.Models
{
    public class ProfileOfVillage
    {
        public ProfileOfVillage()
        {

        }

        [Required]
        [Key]
        [ForeignKey("Region")]
        public int Id { get; set; }

        public string History { get; set; }
                
        public string Potential { get; set; }
                
        public string TenurialCondition { get; set; }
        
        public DateTime DateCreated { get; set; }

        public DateTime DateModified { get; set; }

        public Region Region { get; set; }
    }
}
