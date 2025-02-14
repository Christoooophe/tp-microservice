using Borrowing.Models;

namespace Borrowing.Services
{
    public interface IBorrowingsService
    {
        List<Borrowings> GetBorrowings();
        Borrowings GetBookBorrowings(int bookId);
        Borrowings GetUserBorrowings(int userId);
        void AddBorrowing(Borrowings item);
        void UpdateBorrowing(Borrowings item);
        void DeleteBorrowing(int borrowingId);
    }
}
