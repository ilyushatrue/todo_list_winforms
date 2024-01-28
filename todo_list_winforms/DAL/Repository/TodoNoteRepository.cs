using Microsoft.EntityFrameworkCore;
using todo_list_winforms.DAL.Models;
using todo_list_winforms.DAL.Repository.Common;

namespace todo_list_winforms.DAL.Repository;

public class TodoNoteRepository : BaseRepository, ITodoNoteRepository
{

    public TodoNoteRepository(Context context) : base(context)
    {
    }

    public void Create(TodoNote note)
    {
        _context.Set<TodoNote>();
        _context.Attach(note);
        _context.SaveChanges();
        _context.ChangeTracker.Clear();
    }

    public void Delete(int id)
    {
        _context.Set<TodoNote>();
        _context.Remove(new TodoNote { Id = id });  
        _context.SaveChanges();
    }

    public void Update(TodoNote note)
    {
        _context.Entry(note).State = EntityState.Modified;
        _context.SaveChanges();
        _context.ChangeTracker.Clear();
    }

    public IEnumerable<TodoNote> GetAll()
    {
        var quiry = _context.Set<TodoNote>().AsNoTracking();
        return quiry.ToArray();
    }
}
