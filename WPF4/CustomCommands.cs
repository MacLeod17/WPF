using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace WPF4
{
    static class CustomCommands
    {
        public static readonly RoutedUICommand Exit = new RoutedUICommand("Exit", "Exit", typeof(CustomCommands), 
            new InputGestureCollection() { new KeyGesture(Key.F4, ModifierKeys.Alt) });

        public static readonly RoutedUICommand Submit = new RoutedUICommand("Submit", "Submit", typeof(CustomCommands),
            new InputGestureCollection() { new KeyGesture(Key.E, ModifierKeys.Control) });
    }
}
