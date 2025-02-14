using BookService.Models;
using BookService.Repositories;

namespace BookService.Services
{
    public class BooksService: IBooksService
    {
        private readonly IBookRepository _bookRepository;

        public BooksService(IBookRepository bookRepository)
        {
            _bookRepository = bookRepository;
        }

        public async Task AddBookAsync(Book book) =>
            await _bookRepository.AddAsync(book);

        public async Task DeleteBookAsync(int id) =>
            await _bookRepository.DeleteAsync(id);

        public async Task<IEnumerable<Book>> GetAllBooksAsync() =>
            await _bookRepository.GetAllAsync();

        public async Task<Book?> GetBookByIdAsync(int id) =>
            await _bookRepository.GetByIdAsync(id);

        public async Task UpdateBookAsync(Book book) =>
            await _bookRepository.UpdateAsync(book);
    }
}
