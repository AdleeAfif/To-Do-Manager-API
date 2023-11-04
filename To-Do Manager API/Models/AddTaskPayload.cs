namespace To_Do_Manager_API.Models
{
    public class AddTaskPayload
    {
        public string Title { get; set; }
        public string? Description { get; set; }
        public DateTime DueDate { get; set; }
    }
}
