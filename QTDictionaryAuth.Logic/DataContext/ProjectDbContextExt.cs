using QTDictionaryAuth.Logic.Entities;

namespace QTDictionaryAuth.Logic.DataContext
{
    partial class ProjectDbContext
    {
        public DbSet<Entities.Entry>? EntrySet { get; set; }

        partial void GetDbSet<E>(ref DbSet<E>? dbSet, ref bool handled) where E : IdentityEntity
        {
            if (typeof(E) == typeof(Entities.Entry))
            {
                dbSet = EntrySet as DbSet<E>;
                handled = true;
            }
        }
    }
}
