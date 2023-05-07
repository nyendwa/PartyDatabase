﻿using Class_Register.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Class_Register.View
{
    /// <summary>
    /// Interaction logic for AddUser.xaml
    /// </summary>
    public partial class AddUser : Window
    {
        public AddUser()
        {
            InitializeComponent();
            AddUserViewModel viewModel = new AddUserViewModel();
            this.DataContext = viewModel;
            
        }


        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
