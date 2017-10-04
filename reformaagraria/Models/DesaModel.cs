using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace reformaagraria.Models
{
    public class DesaModel
    {
        public DesaModel()
        {

        }
        [Required]
        [Key]
        public int DesaId { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        [ForeignKey("KecamatanModel")]
        public int KecamatanId { get; set; }

        public KecamatanModel KecamatanModel { get; set; }
    }
}
