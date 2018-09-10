using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MailSender
{
    public static class DataBase
    {
        private static readonly EmailsDataContext _emailsDataContext = new EmailsDataContext();

        public static IQueryable<Email> Email = from mail in _emailsDataContext.Email
            select mail;
    }
}
