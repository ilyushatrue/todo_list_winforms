using System.Runtime.CompilerServices;
using todo_list_winforms.DAL.Models;
using todo_list_winforms.DAL.Repository;
using todo_list_winforms.Migrations;
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
        _view.EditEvent += LoadSelectedTodoToEdit;
        _view.DeleteEvent += DeleteSelectedTodo;
        _view.CreateEvent += SaveTodo;
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
        CleanViewFields();
    }

    private void SaveTodo(object? sender, EventArgs e)
    {
        var model = new TodoNote();
        model.Id = _view.Id;
        model.Title = _view.Title;
        model.Description = _view.Description;
        model.IsDone = _view.IsDone;
        model.StartDate = _view.StartDate;
        model.EndDate = _view.EndDate;

        try
        {
            if (_view.IsEdit)
            {
                _repository.Update(model);
                _view.Message = "Ура обновлено";
            }
            else
            {
                _repository.Create(model);
                _view.Message = "Ура добавлено";
            }
            _view.IsSuccessful = true;
            LoadAllTodoList();
            CleanViewFields();
        }
        catch (Exception ex)
        {
            _view.IsSuccessful = false;
            _view.Message = ex.Message;
            throw;
        }
    }

    private void CleanViewFields()
    {
        _view.Id = 0;
        _view.Title = "";
        _view.Description = "";
        _view.IsEdit = false;
        _view.StartDate = null;
        _view.EndDate = null;
    }

    private void DeleteSelectedTodo(object? sender, EventArgs e)
    {
        try
        {
            var todo = (TodoNote)_bindingSource.Current;
            _repository.Delete(todo.Id);
            _view.IsSuccessful = true;
            _view.Message = "Удалилось";
            LoadAllTodoList();
        }
        catch (Exception)
        {
            _view.IsSuccessful = false;
            _view.Message = "Error БЛЯТЬ!";
            throw;
        }
    }

    private void LoadSelectedTodoToEdit(object? sender, EventArgs e)
    {
        var todo = (TodoNote)_bindingSource.Current;
        _view.Id = todo.Id;
        _view.Title = todo.Title;
        _view.Description = todo.Description;
        _view.IsEdit = true;
        _view.StartDate = DateTime.Now;
        _view.EndDate = todo.EndDate;
    }
}
