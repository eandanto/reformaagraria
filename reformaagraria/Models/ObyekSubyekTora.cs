using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace reformaagraria.Models
{
    public class ObyekSubyekTora
    {
        public ObyekSubyekTora()
        {

        }
        
        [Required]
        [Key]
        public string Id { get; set; }

        [ForeignKey("Region")]
        public int RegionId { get; set; }

        public int Bidang { get; set; }
        
        public double Luas { get; set; }

        public string Subyek { get; set; }

        public string NIK { get; set; }
        
        public string DaftarPenggarap { get; set; }
        
        public string MataPencaharian { get; set; }

        public RegionType Administratif { get; set; }

        public double LuasHPT { get; set; }

        public double LuasHP { get; set; }

        public double LuasHPK { get; set; }

        public double LuasHL { get; set; }

        public double LuasAPL { get; set; }
        
        public string Konsesi { get; set; }

        public string ResumeKasus { get; set; }

        public string Keterangan { get; set; }

        public Status Status { get; set; }

        public DateTime DateCreated { get; set; }

        public DateTime DateModified { get; set; }

        public Region Region { get; set; }
    }
}
