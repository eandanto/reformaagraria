using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace reformaagraria.Models
{
    public enum RegionType
    {
        NASIONAL = 0,
        PROPINSI = 1,
        KABUPATEN = 2,
        KECAMATAN = 3,
        DESA = 4
    }
}
