using todo_list_winforms.DAL.Models;

namespace todo_list_winforms.DAL.Repository;

public interface ITodoNoteRepository
{
    void Add(TodoNote note);
    void Edit(TodoNote note);
    void Delete(int id);
    IEnumerable<TodoNote> GetAll();
    IEnumerable<TodoNote> GetByValue();
}
