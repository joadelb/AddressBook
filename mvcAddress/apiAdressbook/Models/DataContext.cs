

namespace apiAdressbook.Models
{
    using System.Data.Entity;
    public class DataContext:DbContext
    {
        public DataContext():base("DefaultConnection")
        {

        }

        public System.Data.Entity.DbSet<apiAdressbook.Models.Book> Books { get; set; }
    }
}