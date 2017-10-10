using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace reformaagraria.Models
{
    public class AtributPetaTora
    {
        public AtributPetaTora()
        {

        }

        [Required]
        [Key]
        public int Id { get; set; }

        [ForeignKey("Region")]
        public int RegionId { get; set; }

        public string Koordinat { get; set; }

        public double Luas { get; set; }

        public TahapProsesPenetapanTataBatas TahapProsesPenetapanTataBatas { get; set; }

        public Status StatusTataBatas { get; set; }

        public string Lampiran { get; set; }
        
        public Region Region { get; set; }

    }
}
