using MauiTest.CustomModels;
using System.Collections.ObjectModel;
using System.Text.RegularExpressions;

namespace MauiTest
{
    public partial class MainPage : ContentPage
    { 
        public ObservableCollection<User> Users { get; set; }

        public MainPage()
        {
            InitializeComponent();

            Users = new ObservableCollection<User>
            {
                new User {Name = "Tom", Age=38},
                new User {Name = "Bob", Age=42},
                new User {Name = "Sam", Age=25}
            };
            usersList.BindingContext = Users;
        }

        public void AddUser(User user)
        {
            Users.Add(user);
        }

        private async void AddButtonClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new PersonPage(null));
        }

        private async void UsersListItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem is User selectedUser)
            {
                usersList.SelectedItem = null;
                await Navigation.PushAsync(new PersonPage(selectedUser));
            }
        }
    }
}
