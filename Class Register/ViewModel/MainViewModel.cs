using Class_Register.Commands;
using Class_Register.Model;
using Class_Register.View;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Input;

namespace Class_Register.ViewModel
{
    public class MainViewModel
    {
        public ObservableCollection<User> Users { get; set; }
        public ICommand ShowWindowCommand { get; set; }
        public MainViewModel()
        {
            Users = UserManager.GetUsers();

            ShowWindowCommand = new RelayCommand(ShowWindow, CanShowWindo);

        }

        private bool CanShowWindo(object obj)
        {
            return true;
        }

        private void ShowWindow(object obj)
        {
            var Chipani = obj as Window;
            AddUser addUser = new AddUser();
            addUser.Owner = Chipani;
            addUser.WindowStartupLocation =WindowStartupLocation.CenterScreen;
            addUser.Show();
        }
    }
}
