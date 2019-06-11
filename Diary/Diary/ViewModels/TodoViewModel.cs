﻿using Diary.Models;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Diary.ViewModels
{
    public class TodoViewModel : SimpleViewModel
    {
        public Todo Todo { get; private set; }

        public TodoPageViewModel TodoPageViewModel { get; }

        public string Title
        {
            get { return Todo.Title; }
            set
            {
                if (value == Title) return;
                Todo.Title = value;
                RaisePropertyChanged();
                TodoPageViewModel.SaveCommand.ChangeCanExecute();
            }
        }

        public string Notes
        {
            get { return Todo.Notes; }
            set
            {
                if (value == Todo.Notes) return;
                Todo.Notes = value;
                RaisePropertyChanged();
            }
        }

        public bool Completed
        {
            get { return Todo.Completed; }
            set
            {
                if (value == Todo.Completed) return;
                Todo.Completed = value;
                RaisePropertyChanged();
            }
        }

        public TodoViewModel(Todo todo, TodoPageViewModel todoPageViewModel)
        {
            this.Todo = todo;
            this.TodoPageViewModel = todoPageViewModel;
        }
    }
}
