using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace reformaagraria.Models
{
    public class PeriksaDokumenUsulanPenetapan
    {
        public PeriksaDokumenUsulanPenetapan()
        {

        }

        [Required]
        [Key]
        public int Id { get; set; }

        [ForeignKey("Region")]
        public int RegionId { get; set; }

        public bool DaftarUsulanMasyarakat { get; set; }

        public bool DaftarObyekTora { get; set; }

        public bool PetaObyekTora { get; set; }

        public bool DaftarSubyekTora { get; set; }

        public bool DaftarObyekToraKawasanHutan { get; set; }

        public bool PetaObyekToraKawasanHutan { get; set; }

        public bool DaftarSubyekToraKawasanHutan { get; set; }

        public bool DaftarObyekPsDanHutanAdat { get; set; }

        public bool PetaObyekPsDanHutanAdat { get; set; }

        public bool DaftarSubyekPsDanHutanAdat { get; set; }

        public Region Region { get; set; }

    }
}
