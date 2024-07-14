using Notes.Domain.DbModels;

namespace Notes.Application.Repository.NotesRepositoryInterfaces
{
    public interface INotesRepository
    {
        Task<IEnumerable<NoteDbModel>> GetAllNotesAsync(CancellationToken cancellationToken = default);
        Task<NoteDbModel?> GetNoteByIdAsync(Guid noteId, CancellationToken cancellationToken = default);
        Task<NoteDbModel?> GetNoteWithDetailsAsync(Guid noteId, CancellationToken cancellationToken = default);
    }
}
