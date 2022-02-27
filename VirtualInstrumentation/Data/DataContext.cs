using System.Data.Entity;

namespace VirtualInstrumentation.Data
{
    internal class DataContext : DbContext
    {
        public DataContext() : base("ConnectionString")
            {
            }
    }
}
