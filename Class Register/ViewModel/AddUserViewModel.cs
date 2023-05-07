using Class_Register.Commands;
using Class_Register.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace Class_Register.ViewModel
{
    public class AddUserViewModel
    {
        public string? Name { get; set; }
        public string? NRC { get; set; }
        public string? Province { get; set; }
        public string? District { get; set; }
        public string? Constituency { get; set; }
        public string? Ward { get; set; }

        public ICommand AddUserCommand { get; set; }
        public AddUserViewModel()
        {
            AddUserCommand = new RelayCommand(_AddUser, CanAddUser);
        }

        private bool CanAddUser(object obj)
        {
            return true;
        }
        private void _AddUser(object obj)
        {
            UserManager.AddUser(new User() {Name=Name,NRC=NRC, Province=Province,District=District, Ward = Ward, Constituency=Constituency });
        }
        

    }
}
