using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using TaskTrackerApi.Model.Entities;
using TaskTrackerApi.Model.Repositories;

namespace TaskTrackerApi.Controllers;

[ApiController]
[Route("[controller]")]
[Authorize]
public class TrackerTaskController : ControllerBase
{
    private readonly TrackerTaskRepository _taskRepository;

    public TrackerTaskController(TrackerTaskRepository taskRepository)
    {
        _taskRepository = taskRepository;
    }

    [HttpGet("GetTrackerTask")]
    public async Task<IActionResult> GetTrackerTaskAsync(Guid id)
    {
        TrackerTask? task = await _taskRepository.GetTrackerTaskAsync(id);

        if (task != null)
        {
            return Ok(task);
        }
        return NotFound();
    }

    [HttpGet("GetTrackerTasks")]
    public async Task<IActionResult> GetTrackerTasksAsync()
    {
        List<TrackerTask> tasks = await _taskRepository.GetAllTrackerTasksAsync();

        return Ok(tasks);
    }

    [HttpPost("CreateTrackerTask")]
    public async Task<IActionResult> CreateTrackerTaskAsync([FromBody] TrackerTask task)
    {
        await _taskRepository.CreateTrackerTaskAsync(task);
        
        return Ok();
    }

    [HttpPut("UpdateTrackerTask")]
    public async Task<IActionResult> UpdateTrackerTaskAsync([FromBody] TrackerTask task)
    {
        await _taskRepository.UpdateTrackerTaskAsync(task);

        return Ok();
    }

    [HttpDelete("DeleteTrackerTask")]
    public async Task<IActionResult> DeleteTrackerTaskAsync(Guid id)
    {
        await _taskRepository.DeleteTrackerTaskAsync(id);

        return Ok();
    }
}
