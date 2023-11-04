using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using To_Do_Manager_API.Data;
using To_Do_Manager_API.Models;

namespace To_Do_Manager_API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TasksController : Controller
    {
        private readonly ToDoDBContext dbContext;

        public TasksController(ToDoDBContext dbContext)
        {
            this.dbContext = dbContext;
        }

        [HttpGet]
        public async Task<IActionResult> GetTasks()
        {
            return Ok(await dbContext.Tasks.ToListAsync());
        }

        [HttpGet]
        [Route("{id:guid}")]
        public async Task<IActionResult> GetTaskById([FromRoute] Guid id)
        {
            var task = await dbContext.Tasks.FindAsync(id);

            if (task == null) return NotFound();

            return Ok(task);
        }

        [HttpPost]
        public async Task<IActionResult> AddTask(AddTaskPayload payload)
        {
            var task = new TaskModel()
            {
                Id = Guid.NewGuid(),
                Title = payload.Title,
                Description = payload.Description,
                DueDate = payload.DueDate,
                IsCompleted = false,
                CreatedAt = DateTime.Now,
                CompletedAt = null,
            };

            await dbContext.Tasks.AddAsync(task);
            await dbContext.SaveChangesAsync();

            return Ok(task);
        }

        [HttpPut]
        [Route("{id:guid}")]
        public async Task<IActionResult> UpdateTask([FromRoute] Guid id, UpdateTaskPayload payload)
        {
            var task = await dbContext.Tasks.FindAsync(id);

            if (task == null) return NotFound();

            task.IsCompleted = payload.IsCompleted;
            task.CompletedAt = DateTime.Now;

            await dbContext.SaveChangesAsync();

            return Ok(task);
        }

        [HttpDelete]
        [Route("{id:guid}")]
        public async Task<IActionResult> DeleteTask([FromRoute] Guid id)
        {
            var task = await dbContext.Tasks.FindAsync(id);

            if (task == null) return NotFound();

            dbContext.Remove(task);
            await dbContext.SaveChangesAsync();
            return Ok(task);
        }
    }
}
