using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace reformaagraria.Models
{
    public class TipologiPermasalahanAgraria
    {
        public TipologiPermasalahanAgraria()
        {

        }

        [Required]
        [Key]
        public int Id { get; set; }

        [ForeignKey("Region")]
        public int RegionId { get; set; }

        public int JumlahKK { get; set; }

        public int JumlahJiwa { get; set; }

        public double LuasWilayah { get; set; }

        public string MasalahUtama { get; set; }

        public Kodefikasi Kodefikasi { get; set; }

        public UsulanPenanganan UsulanPenanganan { get; set; }

        public double LuasUsulan { get; set; }

        public bool DataSubyekIndividuTerpenuhi { get; set; }

        public bool DataSubyekKomunalTerpenuhi { get; set; }

        public bool DataObyekTerpenuhi { get; set; }

        public bool DataSejarahPenguasaanTanahTerpenuhi { get; set; }

        public string KoordinatLokasi { get; set; }

        public int KontakPerson { get; set; }

        public BentanganLahan BentanganLahan { get; set; }

        public double LuasPemanfaatanLahanHutanMukim { get; set; }

        public double LuasPemanfaatanLahanHutanSawah { get; set; }

        public double LuasPemanfaatanLahanHutanKebun { get; set; }

        public double LuasPemanfaatanLahanHutanLadang { get; set; }

        public double LuasPemanfaatanLahanHutanPadangGembala { get; set; }

        public double LuasPemanfaatanLahanHutanHutan { get; set; }

        public double LuasPemanfaatanLahanHutanKolam { get; set; }

        public DateTime DateCreated { get; set; }

        public DateTime DateModified { get; set; }

        public Region Region { get; set; }

    }
}
