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

namespace TabSwitcher
{
    /// <summary>
    /// Логика взаимодействия для UserControl1.xaml
    /// </summary>
    public partial class TabSwitcherControl : UserControl
    {
        public TabSwitcherControl()=> InitializeComponent();

        public event RoutedEventHandler Back;
        public event RoutedEventHandler Forward;

        private void btBack(object sender, RoutedEventArgs e)
        {
            Back?.Invoke(this, new RoutedEventArgs());
        }

        private void btForward(object sender, RoutedEventArgs e)
        {
            Forward?.Invoke(this, new RoutedEventArgs());
        }
    }
}
