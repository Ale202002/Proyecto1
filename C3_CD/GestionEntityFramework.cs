using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C3_CD
{
    public class GestionEntityFramework
    {
        ContextCrud context;
        public GestionEntityFramework() { }

        public void InitializeConection()
        {
            var optionsBuilder = new DbContextOptionsBuilder<ContextCrud>();
            optionsBuilder.UseSqlServer("Server=ACER-NITRO-5;Database=Estudio;Integrated Security=true;Encrypt=True;TrustServerCertificate=True;");
            context = new ContextCrud(optionsBuilder.Options);
        }

        public void CreateDatabase()
        {
            context.Database.EnsureCreated();
        }
    }
}
