using Library.Models;

namespace Library.Contract
{
    public interface IBookService
    {
        Task<IEnumerable<AllBookViewModel>> GetAllBooksAsync();
        Task<IEnumerable<AllBookViewModel>> GetMyBooksAsync(string userId);
    }
}
