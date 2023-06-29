using Homies.Contract;
using Homies.Data;
using Homies.Data.Entities;
using Homies.Models;
using Microsoft.EntityFrameworkCore;

namespace Homies.Services
{
    public class EventService : IEventService
    {
        private readonly HomiesDbContext dbContext;

        public EventService(HomiesDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task<IEnumerable<AllEventViewModel>> GetAllEventsAsync()
        {
            return await dbContext
                    .Events
                    .Select(e => new AllEventViewModel
                    {
                        Name = e.Name,
                        Start = e.Start,
                        //Type = e.Type.Name
                    })
                    .ToListAsync();
        }

        public Task<IEnumerable<AllEventViewModel>> GetMyEventsAsync(string userId)
        {
            throw new NotImplementedException();
        }

        //public async Task<IEnumerable<AllEventsViewModel>> GetAllBooksAsync()
        //{
        //    
        //}

        //public async Task<IEnumerable<AllEventsViewModel>> GetMyBooksAsync(string userId)
        //{
        //    //return await dbContext.IdentityUserBooks
        //    //    .Where(ub => ub.CollectorId == userId)
        //    //    .Select(b => new AllEventsViewModel
        //    //    {
        //    //        Id = b.Id,
        //    //        Title = b.Title,
        //    //        Author = b.Author,
        //    //        ImageUrl = b.ImageUrl,
        //    //        Description = b.Description,
        //    //        Category = b.Category.Name
        //    //    })
        //    //    .ToListAsync();
    //}
    }
}
