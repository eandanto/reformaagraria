using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace reformaagraria.Models
{
    public class KecamatanModel
    {
        public KecamatanModel()
        {

        }
        [Required]
        [Key]
        public int KecamatanId { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        [ForeignKey("KabupatenModel")]
        public int KabupatenId { get; set; }

        public KabupatenModel KabupatenModel { get; set; }
    }
}
