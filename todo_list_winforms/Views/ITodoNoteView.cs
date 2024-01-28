namespace todo_list_winforms.Views;

public interface ITodoNoteView
{
    public bool IsDone { get; set; }
    public string Title { get; set; }
    public string? Description { get; set; }
    public int? CategoryId { get; set; }
    public DateTime StartDate { get; }
    public DateTime EndDate { get; set; }

    public bool IsEdit { get; set; }
    public bool IsSuccessful { get; set; }
    public string Message { get; set; }

    event EventHandler AddNewEvent;
    event EventHandler EditEvent;
    event EventHandler DeleteEvent;
    event EventHandler SaveEvent;
    event EventHandler CancelEvent;

    void SetTodoListBindingSource(BindingSource todoList);
    void Show();
}
