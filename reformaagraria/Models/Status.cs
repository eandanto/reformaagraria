using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace reformaagraria.Models
{
    public enum Status
    {
        USULAN = 0,
        VERIFIKASI = 1,
        PENETAPAN = 2
    }
}
