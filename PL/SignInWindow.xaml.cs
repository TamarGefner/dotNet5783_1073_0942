﻿using BlApi;
using BO;
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

namespace PL
{
    /// <summary>
    /// Interaction logic for SignInWindow.xaml
    /// </summary>
    public partial class SignInWindow : Window
    {
        public SignInWindow()
        {
            InitializeComponent();
            statusComboBox.ItemsSource = Enum.GetValues(typeof(userStatus));
        }

        private static readonly IBl bl = BlApi.Factory.Get();
        private void SignInBtn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                bl.User.SignIn(new BO.User
                {
                    userName = userNameTextBox.Text,
                    password = passwordTextBox.Text,
                    status = (BO.userStatus)statusComboBox.SelectedItem,
                });

            }
            catch(BlAlreadyExistException ex)
            {
                MessageBox.Show(ex.Message);
            }
            Close();
        }
    }
}
