using GameDatabase.DataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace GameDatabase
{
    
    public partial class LoginWindow : Window
    {
        private UsersTableAdapter usersTableAdapter = new UsersTableAdapter();
        private DataSet dataSet = new DataSet();
        public string Name { get; set; }
        public string Password { get; set; }

        public LoginWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            usersTableAdapter.Fill(dataSet.Users);
            DataContext = dataSet.Users.DefaultView;
        }

        private void SubmitButton_Click(object sender, RoutedEventArgs e)
        {
            var query = from user in dataSet.Users
                        where (user.Name == txtName.Text)
                        where (user.Password == txtPassword.Password)
                        select user;

            // check if there is a match, query will have entry
            if (query.Count() > 0)
            {
                // create instance of the MainWindow (new)
                MainWindow mainWindow = new MainWindow();
                // show window
                mainWindow.Show();
                // Close() this window
                this.Close();
            }
            else
            {
                // show message box that states the user does not exist
                // on the message box show an error icon and “Submit” caption
                // look at resources section below for message box information
                MessageBox.Show("The user does not exist.", "Submit", MessageBoxButton.OK, MessageBoxImage.Error);

                // clear text boxes
                txtName.Clear();
                txtPassword.Clear();
            }
        }

        private void RegisterButton_Click(object sender, RoutedEventArgs e)
        {
            DataSet.UsersRow row = (DataSet.UsersRow)dataSet.Users.NewRow();
            // set row Name to name textbox Text
            row.Name = txtName.Text;
            // set row Password to password textbox Text
            row.Password = txtPassword.Password;

            dataSet.Users.AddUsersRow(row);
            usersTableAdapter.Update(dataSet);

            // show message box that states the user was registered
            // on the message box show an information icon and “Register” caption
            // look at resources section below for message box information
            MessageBox.Show("The user has been registered.", "Register", MessageBoxButton.OK, MessageBoxImage.Information);

            // clear text boxes
            txtName.Clear();
            txtPassword.Clear();
        }

        // Used with the txtPassword TextBox (Commented out in xaml, using PasswordBox instead)
        private void txtPassword_TextChanged(object sender, TextChangedEventArgs e)
        {
            /*SubmitButton.IsEnabled      = (txtPassword.Text.Length > 0 && txtName.Text.Length > 0);
            RegisterButton.IsEnabled    = (txtPassword.Text.Length > 0 && txtName.Text.Length > 0);*/
        }

        private void txtName_TextChanged(object sender, TextChangedEventArgs e)
        {
            /*SubmitButton.IsEnabled      = (txtPassword.Text.Length > 0 && txtName.Text.Length > 0);
            RegisterButton.IsEnabled    = (txtPassword.Text.Length > 0 && txtName.Text.Length > 0);*/
            SubmitButton.IsEnabled      = (txtPassword.Password.Length > 0 && txtName.Text.Length > 0);
            RegisterButton.IsEnabled    = (txtPassword.Password.Length > 0 && txtName.Text.Length > 0);
        }

        // Used with the txtPassword PasswordBox (PasswordBox used instead of TextBox in xaml)
        private void txtPassword_PasswordChanged(object sender, RoutedEventArgs e)
        {
            SubmitButton.IsEnabled      = (txtPassword.Password.Length > 0 && txtName.Text.Length > 0);
            RegisterButton.IsEnabled    = (txtPassword.Password.Length > 0 && txtName.Text.Length > 0);
        }
    }
}
