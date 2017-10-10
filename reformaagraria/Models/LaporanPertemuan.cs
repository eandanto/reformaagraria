using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace reformaagraria.Models
{
    public class LaporanPertemuan
    {
        public LaporanPertemuan()
        {

        }
        
        [Required]
        [Key]
        public string Id { get; set; }
        
        public string NamaKegiatan { get; set; }
        
        public DateTime Tanggal { get; set; }
        
        public string Tempat { get; set; }
        
        public RegionType TingkatPertemuan { get; set; }
        
        public string AgendaPembahasan { get; set; }
        
        public string UraianHasil { get; set; }
        
        public string DaftarPeserta { get; set; }
        
        public string Lampiran { get; set; }
        
        public DateTime DateCreated { get; set; }

        public DateTime DateModified { get; set; }
    }
}
