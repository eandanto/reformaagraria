using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace reformaagraria.Models
{
    public class PengajuanTora
    {
        public PengajuanTora()
        {

        }
        
        [Required]
        [Key]
        public string Id { get; set; }
        
        public string Lampiran { get; set; }
        
        public DateTime DateCreated { get; set; }

        public DateTime DateModified { get; set; }
    }
}
