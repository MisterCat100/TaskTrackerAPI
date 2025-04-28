using Microsoft.EntityFrameworkCore;
using TaskTrackerApi.Model.EFCore;
using TaskTrackerApi.Model.Entities;
using TaskTrackerApi.Model.Interfaces;

namespace TaskTrackerApi.Model.Repositories;

public class TrackerTaskRepository : ITrackerTaskRepository
{
    private readonly TrackerTaskContext _context;

    public TrackerTaskRepository(TrackerTaskContext context)
    {
        _context = context;
    }

    public async Task CreateTrackerTaskAsync(TrackerTask task)
    {
        await _context.TrackerTasks.AddAsync(task);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteTrackerTaskAsync(Guid id)
    {
        TrackerTask? task = await _context.TrackerTasks.FindAsync(id);
        
        if (task != null)
        {
            _context.TrackerTasks.Remove(task);
            await _context.SaveChangesAsync();
        }
        else
        {
            await Task.CompletedTask;
        }

    }

    public async Task<List<TrackerTask>> GetAllTrackerTasksAsync()
    {
        return await _context.TrackerTasks.ToListAsync();
    }

    public async Task<TrackerTask?> GetTrackerTaskAsync(Guid id)
    {
        TrackerTask? task = await _context.TrackerTasks.FindAsync(id);

        if (task != null)
        {
            return task;
        }
        return null;
    }

    public async Task UpdateTrackerTaskAsync(TrackerTask task)
    {
        _context.TrackerTasks.Update(task);
        await _context.SaveChangesAsync();
    }
}
