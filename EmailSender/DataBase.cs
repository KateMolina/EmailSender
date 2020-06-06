using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmailSender
{
    public static class DataBase
    {
        static private EmailsDataContext emails = new EmailsDataContext();
      static public IQueryable<Email> Emails
        {
            get { return from c in emails.Emails select c; }
        }

    }
}
