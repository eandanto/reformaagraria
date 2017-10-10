using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace reformaagraria.Models
{
    public class KalenderKerja
    {
        public KalenderKerja()
        {

        }
        
        [Required]
        [Key]
        public string Id { get; set; }
        
        public string JudulKegiatan { get; set; }

        public string AgendaKegiatan { get; set; }

        public RegionType PelaksanaanKegiatan { get; set; }

        public string Tempat { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public string Keterangan { get; set; }
        
        public DateTime DateCreated { get; set; }

        public DateTime DateModified { get; set; }
    }
}
