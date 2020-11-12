using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace WPF5
{
    public static class CustomCommands
    {
        public static readonly RoutedUICommand submit = new RoutedUICommand("Submit", "Submit", typeof(CustomCommands));
    }
}
