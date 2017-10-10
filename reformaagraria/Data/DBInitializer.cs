using reformaagraria.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace reformaagraria.Data
{
    public class DbInitializer
    {
        public static void Initialize(ReformaAgrariaDataContext context)
        {
            context.Database.EnsureCreated();

            // Look for any kabupaten.
            if (context.Region.Any())
            {
                return;   // DB has been seeded
            }

            var region = new Region[]
            {
            new Region{Id="1",Name="Sigi",Type=RegionType.KABUPATEN,fkParentId=null,DateCreated=DateTime.Now,DateModified=DateTime.Now},
            new Region{Id="2",Name="Dolo",Type=RegionType.KECAMATAN,fkParentId="1",DateCreated=DateTime.Now,DateModified=DateTime.Now},
            new Region{Id="3",Name="Gumbasa",Type=RegionType.KABUPATEN,fkParentId="1",DateCreated=DateTime.Now,DateModified=DateTime.Now},
            new Region{Id="4",Name="Maku",Type=RegionType.DESA,fkParentId="2",DateCreated=DateTime.Now,DateModified=DateTime.Now},
            new Region{Id="5",Name="Tulo",Type=RegionType.DESA,fkParentId="2",DateCreated=DateTime.Now,DateModified=DateTime.Now},
            new Region{Id="6",Name="Tuwa",Type=RegionType.DESA,fkParentId="3",DateCreated=DateTime.Now,DateModified=DateTime.Now},
            new Region{Id="7",Name="Pakuli",Type=RegionType.DESA,fkParentId="3",DateCreated=DateTime.Now,DateModified=DateTime.Now},
            };
            foreach (Region rg in region)
            {
                context.Region.Add(rg);
            }
            context.SaveChanges();
        }
    }
}
