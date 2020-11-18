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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace LINQ
{
    public partial class MainWindow : Window
    {
        public class Student
        {
            public enum eDegree { IS, CS, SE, WD, TM, GD }

            public string Name { get; set; }
            public int Age { get; set; }
            public eDegree Degree { get; set; }

            public override string ToString()
            {
                return $"Name = {Name}, Age = {Age}";
            }
        }

        public MainWindow()
        {
            InitializeComponent();

            List<int> values = new List<int>() { 4, 10, 9, 17 };

            //Query
            //List<int> results = new List<int>();
            //foreach (int value in values)
            //{
            //    if (value >= 10) results.Add(value);
            //}

            //Linq Query
            //var results = from value in values where value >= 10 select value;
            //var results = values.Where(value => value >= 10);
            //values.Add(24);
            //Display.ItemsSource = results;

            List<Student> students = new List<Student>()
            {
                new Student() { Name = "Garrick", Age = 19, Degree = Student.eDegree.GD },
                new Student() { Name = "Noah", Age = 17, Degree = Student.eDegree.IS },
                new Student() { Name = "Dalton", Age = 16, Degree = Student.eDegree.WD },
                new Student() { Name = "Corey", Age = 19, Degree = Student.eDegree.GD }
            };

            //var results = from student in students
            //              where student.Degree == Student.eDegree.GD
            //              where student.Name.Contains("a")
            //              select new { student.Name, student.Age};
            //var results = students.Where(student => student.Degree == Student.eDegree.GD);

            //var results = from student in students
            //              orderby student.Age descending
            //              select student;
            //var results = students.OrderBy(student => student.Name);
            //var results = values.OrderBy(value => value);
            //var results = students.Skip(2);
            //var results = students.Take(2);
            //var results = students.TakeWhile(student => student.Age < 18);
            //var results = students.SkipWhile(student => student.Age < 18);
            //Display.ItemsSource = results;

            //ELEMENT OPERATORS
            //var results = students.FirstOrDefault(student => student.Age == 21);
            //var results = students.LastOrDefault(student => student.Age == 21);
            //var results = students.SingleOrDefault(student => student.Age == 17);
            //var results = students.ElementAt(0);
            //var results = students.ElementAtOrDefault(0);
            //Display.Items.Add(results);

            //QUANTIFIERS
            //bool b = values.Contains(10);
            //bool b = values.Any(v => v % 2 == 1);
            //bool b = values.All(v => v > 3);
            //Display.Items.Add(b);

            //AGGREGATION OPERATORS
            //var i = students.Min(s => s.Age);
            //var i = students.Max(s => s.Age);
            //var i = students.Average(s => s.Age);
            //var i = values.Average();
            //var i = values.Sum();
            //var i = students.Count(s => s.Degree == Student.eDegree.IS);
            //Display.Items.Add(i);

            //SET OPERATORS
            int[] v1 = { 1, 2, 3 };
            int[] v2 = { 3, 4, 5 };

            //var set = v1.Concat(v2);
            //var set = v1.Union(v2);
            //var set = v1.Intersect(v2);
            //var set = v1.Except(v2);
            //Display.ItemsSource = set;

            //LET
            //var results = from student in students
            //              let age = student.Age * 365
            //              where age > 2000
            //              select student;

            //var results = from student in students
            //              let age = student.Age * 365
            //              where age > 2000
            //              select age;

            //Display.ItemsSource = results;

            //JOIN
            List<string> outer = new List<string>() { "One", "Two", "Three" };
            List<string> inner = new List<string>() { "Two", "Three", "Four" };

            //var results = outer.Join(inner, o => o, i => i, (o, i) => o);
            //var results = from o in outer
            //              join i in inner
            //              on o equals i
            //              select o;

            //Display.ItemsSource = results;

            //MULTIPLE GENERATORS
            var results = from o in outer
                          from i in inner
                          where o == i
                          select o + " " + i;

            Display.ItemsSource = results;
        }
    }
}
