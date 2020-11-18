using System;
using System.Collections;
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

namespace TryGenerics
{
    
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            float i1 = 12.4f;
            float i2 = 23.2f;

            Swap(ref i1, ref i2);
            Print("Swap", i1 + " " + i2);

            DataStore<int> dataStore = new DataStore<int>();
            dataStore.Data = 12;
            Print("DataStore", dataStore);

            KeyValuePair<int, string> kvp = new KeyValuePair<int, string>();
            kvp.Key = 10;
            kvp.Value = "Garrick";
            Print("KVP", kvp);

            GenericClass<AClass> generic = new GenericClass<AClass>();

            int[] numbers = new int[] { 1, 2, 3 };
            PrintCollection("Array", numbers);

            try
            {
                Function();
            }
            catch(DivideByZeroException e)
            {
                Print(e.Message);
                Print(e.StackTrace);
            }
            catch (SystemException e)
            {
                Print(e.Message);
            }
            finally
            {
                Print("Finally");
            }
        }

        public void Function()
        {
            int i = 5;
            i = i / 0;
        }

        //Generic Methods
        public void Swap<T>(ref T lhs, ref T rhs)
        {
            T temp = lhs;
            lhs = rhs;
            rhs = temp;
        }

        public void Print(string message)
        {
            lstConsole.Items.Add(message);
        }

        public void Print<T>(string message, T value)
        {
            lstConsole.Items.Add($"{message} : {value}");
        }

        public void PrintCollection<T>(string message, T value) where T : IEnumerable
        {
            lstConsole.Items.Add(message);
            foreach(var element in value)
            {
                lstConsole.Items.Add(element);
            }
        }
    }

    //Generic Class
    class DataStore<T>
    {
        public T Data { get; set; }

        public override string ToString()
        {
            return Data.ToString();
        }
    }

    class KeyValuePair<TKey, TValue>
    {
        public TKey Key { get; set; }
        public TValue Value { get; set; }
    }

    class BaseClass
    {
        public int ID { get; set; }
    }

    class AClass : BaseClass { }
    class BClass : BaseClass { }
    class CClass { }

    class GenericClass<T> where T : BaseClass
    {
        public T Base { get; set; }

    }
}
