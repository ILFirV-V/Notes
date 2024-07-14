using Microsoft.EntityFrameworkCore;
using Notes.Domain.DbModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notes.Application.Repository.NotesRepositoryInterfaces
{
    public interface INotesDbContext
    {
        DbSet<NoteDbModel> Notes { get; set; }
        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
    }
}
