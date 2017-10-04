using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace reformaagraria.Models
{
    public class KabupatenModel
    {
        public KabupatenModel()
        {

        }
        [Required]
        [Key]
        public int KabupatenId { get; set; }

        [Required]
        public string Name { get; set; }
    }
}
