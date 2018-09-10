using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MailSender
{
    public static class Senders
    {
        public static Dictionary<string, string> SendersDictionary { get; } = new Dictionary<string, string>
        {
            {"zxc@yandex.ru", Encrypt.Encrypter.Encrypt("123")},
            {"xzc@yandex.ru", Encrypt.Encrypter.Encrypt("214")}
        };
    }
}
