using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace reformaagraria.Models
{
    public enum TahapProsesPenetapanTora
    {
        IDENTIFIKASI = 0,
        MUSYAWARAH_DESA = 1,
        MUSYAWARAH_ANTAR_DESA = 2,
        RAPAT_KOORDINASI_GUGUS_TUGAS_RA = 3,
        USULAN_PENETAPAN_OBYEK_SUBYEK_TORA_MELALUI_SK_BUPATI = 4,
        PENERBITAN_IZIN_OLEH_KEMEN_ATRBPN_ATAU_KEMENLHK = 4
    }
}
