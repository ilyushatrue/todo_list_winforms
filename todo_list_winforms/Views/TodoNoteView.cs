using System.Data;
using todo_list_winforms.Views;

namespace todo_list_winforms;

public partial class TodoNoteView : Form, ITodoNoteView
{
    public TodoNoteView()
    {
        InitializeComponent();
        save_button.Click += delegate { CreateEvent?.Invoke(this, EventArgs.Empty); };
        delete_button.Click += delegate { DeleteEvent?.Invoke(this, EventArgs.Empty); };
        create_button.Click += delegate { 
            CreateEvent?.Invoke(this, EventArgs.Empty);
            MessageBox.Show(Message);
        };
    }

    public int Id { get; set; }
    public bool IsDone { get; set; }
    public string Title { get { return title_textBox.Text; } set { title_textBox.Text = value; } }
    public string? Description { get { return description_textBox.Text; } set { description_textBox.Text = value; } }
    public DateTime? StartDate { get { return DateTime.Now; } set { } }
    public DateTime? EndDate { get { return DateTime.Parse(deadline_textBox.Text); } set { deadline_textBox.Text = value.ToString(); } }
    public bool IsEdit { get; set; }
    public bool IsSuccessful { get; set; }
    public string? Message { get; set; }

    public event EventHandler? EditEvent;
    public event EventHandler? DeleteEvent;
    public event EventHandler? CreateEvent;
    public event EventHandler? CancelEvent;

    public void SetTodoListBindingSource(BindingSource todoList)
    {
        todo_dataGrid.DataSource = todoList;
    }
}
