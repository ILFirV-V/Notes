﻿using Microsoft.EntityFrameworkCore;
using Notes.Application.Repository.NotesRepositoryInterfaces;
using Notes.Domain.DbModels;
using Notes.Persistence.Repository.EntityTypeConfigurations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notes.Persistence.Repository.NotesRepository
{
    public class NotesDbContext : DbContext, INotesDbContext
    {
        public DbSet<NoteDbModel> Notes { get; set; }

        public NotesDbContext(DbContextOptions<NotesDbContext> options)
            : base(options) { }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new NoteConfiguration());
            base.OnModelCreating(builder);
        }
    }
}