using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;


namespace WpfTestMailSender
{
    public static class EmailSendServiceClass
    {
        
        public static void EmailSend()
        {
            string from = MailSender.from;
            string to= MailSender.to;
            string server=MailSender.server;

            string user = MailSender.User;
            string pass = MailSender.Pass;
            string subject = MailSender.Subject;
            string body = MailSender.Body;
            

            try
            {
                using (var message = new MailMessage(from, to, subject, body))
                using (var client = new SmtpClient(server) { EnableSsl = true, Credentials = new NetworkCredential(user, pass) })
                {
                    client.Send(message);
                }
            }
            catch (SmtpException error)
            {
                //MessageBox.Show(error.Message, "При отправке сообщения возникла ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                var dlg = new SendEndWindow(error.Message);
                dlg.ShowDialog();
            }
        }
        
    }
}
