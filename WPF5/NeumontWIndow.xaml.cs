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
    /// <summary>
    /// Interaction logic for NeumontWIndow.xaml
    /// </summary>
    public partial class NeumontWindow : Window
    {
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
        }

        public class Cohort
        {
            public string Name { get; set; }
            public ObservableCollection<Student> Students { get; set; }

            public Cohort()
            {
                Students = new ObservableCollection<Student>();
            }
        }

        public class Student
        {
            public string Name { get; set; }
            public int ID { get; set; }

        }
    }
}
