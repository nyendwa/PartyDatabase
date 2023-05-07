using System;
using Class_Register.Model;
using Class_Register.ViewModel;
using System.Windows;
using System.Windows.Controls;


namespace Class_Register.View
{
    /// <summary>
    /// Interaction logic for Main.xaml
    /// </summary>
    public partial class Main : Window
    {
        public Main()
        {
            InitializeComponent();
            MainViewModel mainViewModel = new MainViewModel();
            this.DataContext = mainViewModel;

        }

        private void Filterbox_TextChanged(object sender, TextChangedEventArgs e)
        {
            UserList.Items.Filter = FilterMethod;
        }

        private bool FilterMethod(object obj)
        {
            var user = (User)obj;
            return user.NRC.Contains(Filterbox.Text, StringComparison.OrdinalIgnoreCase);
        }
    }
}
