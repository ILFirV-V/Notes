using Notes.Application.Repository.NotesRepositoryInterfaces;
using Notes.Application.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notes.Persistence.Repository
{
    public class RepositoryWrapper : IRepositoryWrapper
    {
        private INotesDbContext repoContext;
        public INotesRepository Notes { get; }

        public RepositoryWrapper(INotesDbContext repositoryContext, INotesRepository notesRepository)
        {
            repoContext = repositoryContext;
            Notes = notesRepository;
        }

        public async Task SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            await repoContext.SaveChangesAsync(cancellationToken);
        }
    }
}
