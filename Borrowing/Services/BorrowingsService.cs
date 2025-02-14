using Borrowing.Models;
using Borrowing.Repositories;

namespace Borrowing.Services
{
    public class BorrowingsService: IBorrowingsService
    {
        private readonly IBorrowRepository _repository;

        public BorrowingsService(IBorrowRepository repository)
        {
            _repository = repository;
        }

        public void AddBorrowing(Borrowings item) => _repository.AddBorrowing(item);

        public void DeleteBorrowing(int borrowingId) => _repository.DeleteBorrowingAsync(borrowingId);

        public List<Borrowings> GetBookBorrowings(int bookId)
        {
            return _repository.GetBookBorrowings(bookId);
        }

        public List<Borrowings> GetBorrowings() => _repository.GetBorrowings();

        public List<Borrowings> GetUserBorrowings(int userId)
        {
            return _repository.GetUserBorrowings(userId);
        }

        public void UpdateBorrowing(Borrowings item) => _repository.UpdateBorrowing(item);

        Borrowings IBorrowingsService.GetBookBorrowings(int bookId)
        {
            throw new NotImplementedException();
        }

        Borrowings IBorrowingsService.GetUserBorrowings(int userId)
        {
            throw new NotImplementedException();
        }
    }
}
