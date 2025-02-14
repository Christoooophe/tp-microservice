using Borrowing.Models;
using Borrowing.Services;
using Microsoft.AspNetCore.Mvc;

namespace Borrowing.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BorrowingsController: ControllerBase
    {
        private readonly IBorrowingsService _service;

        public BorrowingsController(IBorrowingsService service)
        {
            _service = service;
        }

        [HttpGet]
        public IActionResult GetBorrowings() => Ok(_service.GetBorrowings);

        [HttpPost]
        public IActionResult AddStock([FromBody] Borrowings item)
        {
            _service.AddBorrowing(item);
            return Ok();
        }

        [HttpPut("{productId}")]
        public IActionResult UpdateStock(int productId, [FromBody] Borrowings updatedItem)
        {
            _service.UpdateBorrowing(updatedItem);
            return NoContent();
        }

        [HttpDelete("{productId}")]
        public IActionResult DeleteStock(int productId)
        {
            _service.DeleteBorrowing(productId);
            return NoContent();
        }
    }
}
