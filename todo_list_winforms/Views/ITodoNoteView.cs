namespace todo_list_winforms.Views;

public interface ITodoNoteView
{
    public int Id { get; set; }
    public bool IsDone { get; set; }
    public string Title { get; set; }
    public string? Description { get; set; }
    public DateTime? StartDate { get; set; }
    public DateTime? EndDate { get; set; }

    public bool IsEdit { get; set; }
    public bool IsSuccessful { get; set; }
    public string? Message { get; set; }

    event EventHandler EditEvent;
    event EventHandler DeleteEvent;
    event EventHandler CreateEvent;
    event EventHandler CancelEvent;

    void SetTodoListBindingSource(BindingSource todoList);
    void Show();
}
