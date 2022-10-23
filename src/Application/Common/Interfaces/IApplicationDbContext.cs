using MisterX.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Domain.Entities;

namespace MisterX.Application.Common.Interfaces;

public interface IApplicationDbContext
{
    DbSet<TodoList> TodoLists { get; }

    DbSet<TodoItem> TodoItems { get; }

    DbSet<Student> Students {get;}
    DbSet<Room> Rooms { get; }

    Task<int> SaveChangesAsync(CancellationToken cancellationToken);
}
