using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace reformaagraria.Models
{
    public enum TahapProsesPenetapanTataBatas
    {
        IDENTIFIKASI = 0,
        MUSYAWARAH_DESA = 1,
        MUSYAWARAH_ANTAR_DESA = 2,
        RAPAT_KOORDINASI_TIM_PENEGASAN_DAN_PENETAPAN_BATAS_DESA = 3,
        PENETAPAN_BATAS_DESA_OLEH_BUPATI_MELALUI_PERBUP = 4
    }
}
