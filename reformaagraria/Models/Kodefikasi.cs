using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace reformaagraria.Models
{
    public enum Kodefikasi
    {
        MASYARAKAT_MASYARAKAT = 0,
        MASYARAKAT_NEGARA = 1,
        MASYARAKAT_SWASTA = 2,
        NEGARA_SWASTA = 3
    }
}
