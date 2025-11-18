using Microsoft.EntityFrameworkCore;

using modelo.Entidades;


namespace veterinariaback.Data
{
    public class DataContext:DbContext
    {

        public DataContext(DbContextOptions<DataContext> options) : base(options)

        {

        }


        public DbSet<medico> Productos { get; set; }

    }
}

