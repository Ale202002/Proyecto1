//using C3_CD;
//using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoCRUD
{
    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            /*var optionsBuilder = new DbContextOptionsBuilder<ContextCrud>();
            optionsBuilder.UseSqlServer("Server=ACER-NITRO-5;Database=Estudio;Integrated Security=true;Encrypt=True;TrustServerCertificate=True;");

            using (var context = new ContextCrud(optionsBuilder.Options))
            {
                // Aquí puedes realizar operaciones con el contexto
                context.Database.EnsureCreated(); // Crea la base de datos si no existe
            }

            Console.WriteLine("Contexto configurado correctamente.");*/

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmMenuPrincipal());
        }
    }
}
