using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmailSendServiceDLL;

namespace EmailSender.Services
{
    class DataAccessService : IDataAccessService

    {
        // EmailsDataContext context;
        MailsAndSendersEntities context;
        public ObservableCollection<Email> GetEmails()
        {
            ObservableCollection<Email> Emails = new ObservableCollection<Email>();
            foreach (var item in context.Emails) { Emails.Add(item); }
            return Emails;
        }

        public int CreateEmail(Email email)
        {
            context.Emails.Add(email);
            //context.Emails.InsertOnSubmit(email);
            //context.SubmitChanges();
            context.SaveChanges();
            return email.Id;
        }

        public DataAccessService()
        {
            //context = new EmailsDataContext();
            context = new MailsAndSendersEntities();
        }
    }
}

    

