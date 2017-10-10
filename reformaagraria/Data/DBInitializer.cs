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
            new Region{RegionId="1",Name="Sigi",Type=RegionType.REGENCY,fkParentId=null,DateCreated=DateTime.Now,DateModified=DateTime.Now},
            new Region{RegionId="2",Name="Dolo",Type=RegionType.DISTRICT,fkParentId="1",DateCreated=DateTime.Now,DateModified=DateTime.Now},
            new Region{RegionId="3",Name="Gumbasa",Type=RegionType.DISTRICT,fkParentId="1",DateCreated=DateTime.Now,DateModified=DateTime.Now},
            new Region{RegionId="4",Name="Maku",Type=RegionType.VILLAGE,fkParentId="2",DateCreated=DateTime.Now,DateModified=DateTime.Now},
            new Region{RegionId="5",Name="Tulo",Type=RegionType.VILLAGE,fkParentId="2",DateCreated=DateTime.Now,DateModified=DateTime.Now},
            new Region{RegionId="6",Name="Tuwa",Type=RegionType.VILLAGE,fkParentId="3",DateCreated=DateTime.Now,DateModified=DateTime.Now},
            new Region{RegionId="7",Name="Pakuli",Type=RegionType.VILLAGE,fkParentId="3",DateCreated=DateTime.Now,DateModified=DateTime.Now},
            };
            foreach (Region rg in region)
            {
                context.Region.Add(rg);
            }
            context.SaveChanges();
        }
    }
}
