using Microsoft.AspNetCore.Mvc;
using TaskTrackerApi.Model.Entities;

namespace TaskTrackerApi.Model.Interfaces;

public interface ITrackerTaskRepository
{
    public Task CreateTrackerTaskAsync(TrackerTask task);
    public Task<TrackerTask?> GetTrackerTaskAsync(Guid id);
    public Task<List<TrackerTask>> GetAllTrackerTasksAsync();
    public Task UpdateTrackerTaskAsync(TrackerTask task);
    public Task DeleteTrackerTaskAsync(Guid id);
}
