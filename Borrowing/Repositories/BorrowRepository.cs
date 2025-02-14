using Borrowing.Data;
using Borrowing.Models;
using static Borrowing.Repositories.BorrowRepository;

namespace Borrowing.Repositories
{
    public class BorrowRepository : IBorrowRepository
    {
        private readonly BorrowingContext _context;
        public BorrowRepository(BorrowingContext context)
        {
            _context = context;
        }
        public List<Borrowings> GetBorrowings() => _context.Borrowings.ToList();
        public List<Borrowings> GetBookBorrowings(int bookId) => _context.Borrowings.Where(i => i.BookId == bookId).ToList();
        public List<Borrowings> GetUserBorrowings(int userId) => _context.Borrowings.Where(i => i.UserId == userId).ToList();

        public void AddBorrowing(Borrowings item)
        {
            _context.Borrowings.Add(item);
            _context.SaveChanges();
        }

        public async void UpdateBorrowing(Borrowings item)
        {
            _context.Borrowings.Update(item);
            await _context.SaveChangesAsync();
        }

        public async void DeleteBorrowingAsync(int borrowingId)
        {
            var borrowing = await _context.Borrowings.FindAsync(borrowingId);
            if (borrowing != null)
            {
                _context.Borrowings.Remove(borrowing);
                await _context.SaveChangesAsync();
            }
        }
    } 
}
