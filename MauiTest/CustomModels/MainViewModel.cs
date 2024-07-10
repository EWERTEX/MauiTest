using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;

namespace MauiTest.CustomModels
{
    public class MainViewModel : INotifyPropertyChanged
    {
        public ICommand SaveCommand { get; set; }
        public ICommand RemoveCommand { get; set; }
        public ObservableCollection<Person> People { get; } = [new Person { Name = "Tom", Age = 35},
                                                               new Person { Name = "Stive", Age = 29},
                                                               new Person { Name = "Jhon", Age = 47},
                                                               new Person { Name = "Donald", Age = 49},
                                                               new Person { Name = "Alice", Age = 26},
                                                               new Person { Name = "Poll", Age = 18},];

        private string _name = string.Empty;
        public string Name
        {
            get => _name;
            set
            {
                if (_name != value)
                {
                    _name = value;
                    OnPropertyChanged();
                }
            }
        }

        private int _age;
        public int Age
        {
            get => _age;
            set
            {
                if (_age != value)
                {
                    _age = value;
                    OnPropertyChanged();
                }
            }
        }

        public MainViewModel()
        {
            SaveCommand = new Command(() =>
            {
                People.Add(new Person { Name = this.Name, Age = this.Age});
                Name = string.Empty;
                Age = 0;
            },
            () => Age > 0 && Age < 110 && Name.Length >= 2);

            RemoveCommand = new Command<Person>((Person person) =>
            {
                People.Remove(person);
            });
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
            ((Command)SaveCommand).ChangeCanExecute();
        }
    }
}
