namespace todo_list_winforms.DAL.Repository.Common;

public class BaseRepository
{
    public readonly Context _context;
    public BaseRepository(Context context)
    {
        _context = context;
    }
}
