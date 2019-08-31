using System.Data.Entity;

namespace apiAdressbook.Models
{
    public class DataContext:DbContext
    {
        public DataContext():base("DefaultConnection")
        {

        }

        public System.Data.Entity.DbSet<apiAdressbook.Models.Book> Books { get; set; }
    }
}