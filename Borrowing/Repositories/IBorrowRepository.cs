using Borrowing.Models;

namespace Borrowing.Repositories
{
    public interface IBorrowRepository
    {
        List<Borrowings> GetBorrowings();
        List<Borrowings> GetBookBorrowings(int bookId);
        List<Borrowings> GetUserBorrowings(int userId);
        void AddBorrowing(Borrowings item);
        void UpdateBorrowing(Borrowings item);
        void DeleteBorrowingAsync(int borrowingId);
    }
}
