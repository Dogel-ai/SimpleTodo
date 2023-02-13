using System.Collections.Generic;
using System.Collections.ObjectModel;
using Todo_Application.Models;

namespace Todo_Application.ViewModels {
    public class TodoListViewModel : ViewModelBase{
        public TodoListViewModel(IEnumerable<TodoItem> items) {
            Items = new ObservableCollection<TodoItem>(items);
        }
        public ObservableCollection<TodoItem> Items { get; }
    }
}
