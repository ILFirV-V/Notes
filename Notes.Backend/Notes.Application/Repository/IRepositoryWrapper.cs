using Notes.Application.Repository.NotesRepositoryInterfaces;

namespace Notes.Application.Repository
{
    public interface IRepositoryWrapper
    {
        public INotesRepository Notes { get; }
        public Task SaveChangesAsync(CancellationToken cancellationToken = default);
    }
}
