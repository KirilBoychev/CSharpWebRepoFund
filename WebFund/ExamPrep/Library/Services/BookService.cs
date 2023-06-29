using Library.Contract;
using Library.Data;
using Library.Models;
using Microsoft.EntityFrameworkCore;

namespace Library.Services
{
    public class BookService : IBookService
    {
        private readonly LibraryDbContext dbContext;

        public BookService(LibraryDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task<IEnumerable<AllBookViewModel>> GetAllBooksAsync()
        {
            return await this.dbContext
                .Books
                .Select(b => new AllBookViewModel
                {
                    Id = b.Id,
                    Title = b.Title,
                    Author = b.Author,
                    ImageUrl = b.ImageUrl,
                    Rating = b.Rating,
                    Category = b.Category.Name
                })
                .ToListAsync();
        }

        public Task<IEnumerable<AllBookViewModel>> GetMyBooksAsync(string userId)
        {
            throw new NotImplementedException();
        }

        //public async Task<IEnumerable<AllBookViewModel>> GetMyBooksAsync(string userId)
        //{
        //    return await dbContext.IdentityUserBooks
        //        .Where(ub => ub.CollectorId == userId)
        //        .Select(b => new AllBookViewModel
        //        {
        //            Id = b.Id,
        //            Title = b.Title,
        //            Author = b.Author,
        //            ImageUrl = b.ImageUrl,
        //            Description = b.Description,
        //            Category = b.Category.Name
        //        })
        //        .ToListAsync();
        //}
    }
}
