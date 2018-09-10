using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MailSender
{
    public static class Server
    {
        public static Dictionary<string, int> ServerDictionary { get; } = new Dictionary<string, int>
        {
            {"smtp.yandex.ru", 25 },
            {"smtp.gmail.com", 58 },
            {"smtp.mail.ru", 25 }
        };
    }
}
