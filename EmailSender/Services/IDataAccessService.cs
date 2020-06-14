using System;
using System.Collections.ObjectModel;

namespace EmailSender.Services
{
   public interface IDataAccessService
    {
        ObservableCollection<Email> GetEmails();

        int CreateEmail(Email email);
    }
}