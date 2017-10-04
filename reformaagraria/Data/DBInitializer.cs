using reformaagraria.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace reformaagraria.Data
{
    public class DbInitializer
    {
        public static void Initialize(RADataContext context)
        {
            context.Database.EnsureCreated();

            // Look for any kabupaten.
            if (context.KabupatenModel.Any())
            {
                return;   // DB has been seeded
            }

            var kabupatenModel = new KabupatenModel[]
            {
            new KabupatenModel{KabupatenId=1,Name="Sigi"}
            };
            foreach (KabupatenModel kb in kabupatenModel)
            {
                context.KabupatenModel.Add(kb);
            }
            context.SaveChanges();

            var kecamatanModel = new KecamatanModel[]
            {
            new KecamatanModel{KecamatanId=1,Name="Dolo",KabupatenId=1},
            new KecamatanModel{KecamatanId=2,Name="Gumbasa",KabupatenId=1},
            new KecamatanModel{KecamatanId=3,Name="Kinovaro",KabupatenId=1},
            new KecamatanModel{KecamatanId=4,Name="Nokilalaki",KabupatenId=1},
            new KecamatanModel{KecamatanId=5,Name="Palolo",KabupatenId=1}
            };
            foreach (KecamatanModel kc in kecamatanModel)
            {
                context.KecamatanModel.Add(kc);
            }
            context.SaveChanges();

            var desaModel = new DesaModel[]
            {
            new DesaModel{DesaId=1,Name="Kabobona",KecamatanId=1},
            new DesaModel{DesaId=2,Name="Tulo",KecamatanId=1},
            new DesaModel{DesaId=3,Name="Pakuli",KecamatanId=2},
            new DesaModel{DesaId=4,Name="Doda",KecamatanId=3},
            new DesaModel{DesaId=5,Name="Rondingo",KecamatanId=3},
            new DesaModel{DesaId=6,Name="Sopu",KecamatanId=4},
            new DesaModel{DesaId=7,Name="Makmur",KecamatanId=5},
            };
            foreach (DesaModel ds in desaModel)
            {
                context.DesaModel.Add(ds);
            }
            context.SaveChanges();
        }
    }
}
