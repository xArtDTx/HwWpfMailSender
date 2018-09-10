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
using System.Net;
using System.Net.Mail;

namespace WpfTestMailSender
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary> 
    public partial class WpfMailSender : Window
    {
        
        public WpfMailSender()
        {
            InitializeComponent();


                        
        }

        private void btSendEmail_Click(object sender, RoutedEventArgs e)
        {
            EmailSendServiceClass.EmailSend();
        }

        private void tbSubject_TextChanged(object sender, TextChangedEventArgs e)
        {
            tbSubject.Text = MailSender.Subject;
        }

        private void tbText_TextChanged(object sender, TextChangedEventArgs e)
        {
            tbText.Text = MailSender.Body;
        }
    }
}
