using Microsoft.EntityFrameworkCore;
using ZestMonitor.Api.Data.Entities;

namespace ZestMonitor.Api.Data.Contexts
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        public DbSet<ProposalPayments> ProposalPayments { get; set; }
    }
}