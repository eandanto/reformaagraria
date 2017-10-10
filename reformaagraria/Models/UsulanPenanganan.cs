using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace reformaagraria.Models
{
    public enum UsulanPenanganan
    {
        PELEPASAN_KAWASAN_HUTAN = 0,
        HUTAN_ADAT = 1,
        REDISTRIBUSI_TANAH = 2,
        LEGALISASI_ASET = 3
    }
}
