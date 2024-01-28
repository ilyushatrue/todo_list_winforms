using System.Data;
using todo_list_winforms.Views;

namespace todo_list_winforms;

public partial class TodoList : Form, ITodoNoteView
{
    public TodoList()
    {
        InitializeComponent();

    }

    public bool IsDone { get; set; }
    public string Title { get { return title_textBox.Text; } set { title_textBox.Text = value; } }
    public string? Description { get { return description_textBox.Text; } set { description_textBox.Text = value; } }
    public int? CategoryId { get; set; }
    public DateTime StartDate { get { return DateTime.Now; } }
    public DateTime EndDate { get { return DateTime.Parse(deadline_textBox.Text); } set { deadline_textBox.Text = value.ToString(); } }
    public string SearchValue { get; set; }
    public bool IsEdit { get; set; }
    public bool IsSuccessful { get; set; }
    public string Message { get; set; }

    public event EventHandler SearchEvent;
    public event EventHandler AddNewEvent;
    public event EventHandler EditEvent;
    public event EventHandler DeleteEvent;
    public event EventHandler SaveEvent;
    public event EventHandler CancelEvent;

    public void SetTodoListBindingSource(BindingSource todoList)
    {
        todo_dataGrid.DataSource = todoList;
    }
}
