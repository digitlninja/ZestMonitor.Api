using Microsoft.EntityFrameworkCore;
using ZestMonitor.Api.Data.Entities;

namespace ZestMonitor.Api.Data.Contexts
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        public DbSet<ProposalPayments> ProposalPayments { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ProposalPayments>().HasKey(x => x.Id);

            modelBuilder.Entity<ProposalPayments>().Property(x => x.Amount).IsRequired();
            modelBuilder.Entity<ProposalPayments>().Property(x => x.Hash).IsRequired();
            modelBuilder.Entity<ProposalPayments>().Property(x => x.ExpectedPayment).IsRequired();
            modelBuilder.Entity<ProposalPayments>().Property(x => x.ShortDescription);
            modelBuilder.Entity<ProposalPayments>().Property(x => x.CreatedAt);
            modelBuilder.Entity<ProposalPayments>().Property(x => x.UpdatedAt);
        }
    }
}