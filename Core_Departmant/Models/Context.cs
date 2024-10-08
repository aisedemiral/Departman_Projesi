using Microsoft.EntityFrameworkCore;

namespace Core_Departmant.Models;

public class Context:DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server=localhost,1401; Database=corepersonel; User Id=sa; Password=YourSTRONG!Passw0rd;TrustServerCertificate=true");

    }
    public DbSet<departmanlar> departmanlars { get; set; }
    public DbSet<Personel> Personels { get; set; }
}