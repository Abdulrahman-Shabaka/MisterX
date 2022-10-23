using MisterX.Application.TodoLists.Queries.ExportTodos;

namespace MisterX.Application.Common.Interfaces;

public interface ICsvFileBuilder
{
    byte[] BuildTodoItemsFile(IEnumerable<TodoItemRecord> records);
}
