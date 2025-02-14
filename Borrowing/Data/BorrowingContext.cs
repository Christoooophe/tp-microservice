using Borrowing.Models;
using Microsoft.EntityFrameworkCore;

namespace Borrowing.Data
{
    public class BorrowingContext: DbContext
    {
        public BorrowingContext(DbContextOptions<BorrowingContext> options) : base(options) { }
        public DbSet<Borrowings> Borrowings { get; set; }
    }
}
