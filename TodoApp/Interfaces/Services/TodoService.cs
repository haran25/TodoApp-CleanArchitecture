using ToDoApp.Core.Entities;
using ToDoApp.Core.Interfaces;

namespace ToDoApp.Application.Services
{
    public class TodoService
    {
        private readonly ITodoRepository _repository;

        public TodoService(ITodoRepository repository)
        {
            _repository = repository;
        }

        public Task<List<TodoItem>> GetAllAsync() => _repository.GetAllAsync();
        public Task<TodoItem?> GetByIdAsync(int id) => _repository.GetByIdAsync(id);
        public Task<TodoItem> AddAsync(TodoItem item) => _repository.AddAsync(item);
        public Task UpdateAsync(TodoItem item) => _repository.UpdateAsync(item);
        public Task DeleteAsync(int id) => _repository.DeleteAsync(id);
    }
}