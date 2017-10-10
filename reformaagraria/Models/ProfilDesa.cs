using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace reformaagraria.Models
{
    public class ProfilDesa
    {
        public ProfilDesa()
        {

        }

        [Required]
        [Key]
        [ForeignKey("Region")]
        public int Id { get; set; }

        public string Sejarah { get; set; }
                
        public string Potensi { get; set; }
                
        public string KondisiTenurial { get; set; }
        
        public DateTime DateCreated { get; set; }

        public DateTime DateModified { get; set; }

        public Region Region { get; set; }
    }
}
