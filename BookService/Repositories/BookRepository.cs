using BookService.Data;
using BookService.Models;
using Microsoft.EntityFrameworkCore;

namespace BookService.Repositories
{
    public class BookRepository: IBookRepository
    {
        private readonly BookContext _bookContext;

        public BookRepository(BookContext bookContext) 
        {
            _bookContext = bookContext;
        }

        public async Task<IEnumerable<Book>> GetAllAsync() =>
            await _bookContext.Books.ToListAsync();

        public async Task<Book?> GetByIdAsync(int id) =>
            await _bookContext.Books.FindAsync(id);

        public async Task AddAsync(Book book)
        {
            await _bookContext.Books.AddAsync(book);
            await _bookContext.SaveChangesAsync();
        }

        public async Task UpdateAsync(Book book)
        {
            _bookContext.Books.Update(book);
            await _bookContext.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var book = await _bookContext.Books.FindAsync(id);
            if (book != null)
            {
                _bookContext.Books.Remove(book);
                await _bookContext.SaveChangesAsync();
            }
        }
    }
}
