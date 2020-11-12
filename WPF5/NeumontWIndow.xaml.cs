using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WPF5
{
    public partial class NeumontWindow : Window
    {
        private BaseItem selected;

        public NeumontWindow()
        {
            InitializeComponent();

            List<Cohort> cohorts = new List<Cohort>();
            Cohort cohort35 = new Cohort() { Name = "Cohort 35" };
            cohort35.Students.Add(new Student() { Name = "Ana", ID = 34 });
            cohort35.Students.Add(new Student() { Name = "Dakota", ID = 23 });
            cohort35.Students.Add(new Student() { Name = "Cameron", ID = 12 });
            cohorts.Add(cohort35);

            Cohort cohort34 = new Cohort() { Name = "Cohort 34" };
            cohort34.Students.Add(new Student() { Name = "Ryder", ID = 78 });
            cohort34.Students.Add(new Student() { Name = "Adam", ID = 32 });
            cohorts.Add(cohort34);

            trvNeumont.ItemsSource = cohorts;
        }

        private void trvNeumont_SelectedItemChanged(object sender, RoutedPropertyChangedEventArgs<object> e)
        {
            TreeView treeView = sender as TreeView;
            selected = treeView.SelectedItem as BaseItem;

            //MessageBox.Show(selected.ToString());
        }

        private void Submit_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = selected is Cohort;
        }

        private void Submit_Executed(object sender, ExecutedRoutedEventArgs e)
        {

        }

        private void btnSubmit_Click(object sender, RoutedEventArgs e)
        {
            if (selected is Cohort cohort && !string.IsNullOrEmpty(txtName.Text))
            {
                cohort.Students.Add(new Student() { Name = txtName.Text, ID = 45 });
                txtName.Text = "";
            }
        }
    }

    public class BaseItem
    {

    }

    public class Cohort : BaseItem
    {
        public string Name { get; set; }
        public ObservableCollection<Student> Students { get; set; }

        public Cohort()
        {
            Students = new ObservableCollection<Student>();
        }
    }

    public class Student : BaseItem
    {
        public string Name { get; set; }
        public int ID { get; set; }

    }
}
