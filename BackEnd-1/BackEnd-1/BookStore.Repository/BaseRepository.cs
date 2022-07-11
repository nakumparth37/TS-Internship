using BookStore.model.ViewModels;


namespace BookStore.Repository
{
    public class BaseRepository
    {
        protected readonly BookStroeContext _context = new BookStroeContext();
    }
}
