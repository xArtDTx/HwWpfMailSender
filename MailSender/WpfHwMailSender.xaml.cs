using System.Windows;

namespace MailSender
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class WpfHwMailSender : Window
    {
        public WpfHwMailSender() => InitializeComponent();


        private void btScheduler(object sender, RoutedEventArgs e)
        {
            MainTabControl.SelectedIndex = 1;
        }

        private void TabSwitcherControl_OnBack(object sender, RoutedEventArgs e)
        {
            if (MainTabControl.SelectedIndex < 1) { MainTabControl.SelectedIndex = 2; }
            else { MainTabControl.SelectedIndex--; }
        }

        private void TabSwitcherControl_OnForward(object sender, RoutedEventArgs e)
        {
            if (MainTabControl.SelectedIndex > 1) { MainTabControl.SelectedIndex = 0; }
            else { MainTabControl.SelectedIndex++; }
        }

        private void btSendNow_Click(object sender, RoutedEventArgs e)
        {
            MainTabControl.SelectedIndex = 2;
        }
    }
}
