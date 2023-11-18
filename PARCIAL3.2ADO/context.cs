using Microsoft.EntityFrameworkCore;
using PARCIAL3._2ADO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
public class Context : DbContext
{
    public DbSet<notas> notas { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server=CC1PC59-60;Database=estudiantes;Trusted_Connection=True;");
    }
}
