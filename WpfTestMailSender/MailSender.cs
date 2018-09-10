using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfTestMailSender
{
    public static class MailSender
    {
        public static string from = "user@yandex.ru";
        public static string to = "user@gmail.com";

        public static string server = "smtp.yandex.ru";
        
        public static string User { get ; set ; }
        public static string Pass { get ; set ; }
        public static string Subject { get ; set; }
        public static string Body { get; set; }
    }
}
