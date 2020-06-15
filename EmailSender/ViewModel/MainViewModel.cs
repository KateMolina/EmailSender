using EmailSender.Services;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using System.Collections.ObjectModel;

namespace EmailSender.ViewModel
{

    public class MainViewModel : ViewModelBase
    {
        ObservableCollection<Email> _Emails;
        IDataAccessService _serviceProxy;
        Email _EmailInfo;
        public ObservableCollection<Email> Emails
        {
            get { return _Emails; }
            set
            {
                _Emails = value;
                RaisePropertyChanged(nameof(Emails));
            }
        }

        public Email EmailInfo { get { return _EmailInfo; } set { _EmailInfo = value; RaisePropertyChanged(nameof(EmailInfo)); } }

        void GetEmails()
        {
            Emails.Clear();
            foreach (var item in _serviceProxy.GetEmails()) { Emails.Add(item); }
        }

        public RelayCommand ReadAllCommand { get; set; }
        public RelayCommand<Email> SaveCommand { get; set; }

        void SaveEmail(Email email)
        {
            EmailInfo.Id = _serviceProxy.CreateEmail(email);
            if (EmailInfo.Id != 0)
            {
                Emails.Add(EmailInfo);
                RaisePropertyChanged(nameof(EmailInfo));
            }
        }

        public MainViewModel(IDataAccessService servProxy)
        {
            _serviceProxy = servProxy;
            Emails = new ObservableCollection<Email>();
            EmailInfo = new Email();
            ReadAllCommand = new RelayCommand(GetEmails);
            SaveCommand = new RelayCommand<Email>(SaveEmail);
        }



    }
}