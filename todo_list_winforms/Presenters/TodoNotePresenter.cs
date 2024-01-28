using System.Runtime.CompilerServices;
using todo_list_winforms.DAL.Models;
using todo_list_winforms.DAL.Repository;
using todo_list_winforms.Views;

namespace todo_list_winforms.Presenters;

public class TodoNotePresenter
{
    private ITodoNoteView _view;
    private ITodoNoteRepository _repository;
    private BindingSource _bindingSource;
    private IEnumerable<TodoNote> _noteList;

    public TodoNotePresenter(ITodoNoteView view, ITodoNoteRepository repository)
    {
        _view = view;
        _repository = repository;
        _bindingSource = new();
        _view.AddNewEvent += AddNewTodo;
        _view.EditEvent += LoadSelectedTodoToEdit;
        _view.DeleteEvent += DeleteSelectedTodo;
        _view.SaveEvent += SaveTodo;
        _view.CancelEvent += CancelAction;
        _view.SetTodoListBindingSource(_bindingSource);
        LoadAllTodoList();
        _view.Show();
    }

    private void LoadAllTodoList()
    {
        _noteList = _repository.GetAll();
        _bindingSource.DataSource = _noteList;
    }

    private void CancelAction(object? sender, EventArgs e)
    {
        throw new NotImplementedException();
    }

    private void SaveTodo(object? sender, EventArgs e)
    {
        throw new NotImplementedException();
    }

    private void DeleteSelectedTodo(object? sender, EventArgs e)
    {
        throw new NotImplementedException();
    }

    private void LoadSelectedTodoToEdit(object? sender, EventArgs e)
    {
        throw new NotImplementedException();
    }

    private void AddNewTodo(object? sender, EventArgs e)
    {
        throw new NotImplementedException();
    }
}
