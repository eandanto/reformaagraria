using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace reformaagraria.Models
{
    public enum BentanganLahan
    {
        DATAR = 0,
        LANDAI = 1,
        BUKIT = 2,
        PEGUNUNGAN = 3
    }
}
