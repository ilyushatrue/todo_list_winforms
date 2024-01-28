using todo_list_winforms.DAL.Models.Base;

namespace todo_list_winforms.DAL.Models;

public class TodoNote : BaseEntity
{
    public bool IsDone { get; set; }
    public string Title { get; set; } = null!;
    public string? Description { get; set; }
    public int? CategoryId { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
}
