using System;
using System.Collections.Generic;
using System.Text;
using Todo_Application.ViewModels;

namespace Todo_Application.ViewModels {
    public class MainWindowViewModel : ViewModelBase {
        public MainWindowViewModel(Services.Database db) {
            List = new TodoListViewModel(db.GetItems());
        }
        public TodoListViewModel List { get; }
    }
}
