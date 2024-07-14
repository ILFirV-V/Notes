using Notes.Application.Repository.NotesRepositoryInterfaces;
using Notes.Application.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Notes.Domain.DbModels;

namespace Notes.Persistence.Repository.NotesRepository
{
    public class NotesRepository : RepositoryBase<NoteDbModel>, INotesRepository
    {
        public Task<IEnumerable<NoteDbModel>> GetAllNotesAsync(CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public Task<NoteDbModel?> GetNoteByIdAsync(Guid noteId, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public Task<NoteDbModel?> GetNoteWithDetailsAsync(Guid noteId, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }
    }
}