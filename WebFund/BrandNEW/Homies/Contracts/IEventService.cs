using Homies.Models;

namespace Homies.Contract
{
    public interface IEventService
    {
        Task<IEnumerable<AllEventViewModel>> GetAllEventsAsync();
        Task<IEnumerable<AllEventViewModel>> GetMyEventsAsync(string userId);
    }
}
