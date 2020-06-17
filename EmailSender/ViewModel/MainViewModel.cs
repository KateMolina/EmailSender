using EmailSender.Services;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows.Data;

namespace EmailSender.ViewModel
{

    public class MainViewModel : ViewModelBase
    {
        ObservableCollection<Email> _Emails;
        IDataAccessService _serviceProxy;
        Email _EmailInfo;
        private string _filterName;
        private CollectionViewSource _emailsView;

        public ObservableCollection<Email> Emails
        {
            get { return _Emails; }
            set
            {
                if (!Set(ref _Emails, value)) return;
                _emailsView = new CollectionViewSource { Source = value };
                _emailsView.Filter += OnEmailsCollectionViewSourceFilter;
                RaisePropertyChanged(nameof(EmailsView));
            }
        }

        private void OnEmailsCollectionViewSourceFilter(object sender, FilterEventArgs e)
        {
            if (!(e.Item is Email email) || string.IsNullOrWhiteSpace(_filterName)) return;
            if (!email.Name.Contains(_filterName)) e.Accepted=false;
        }

        public Email EmailInfo { get { return _EmailInfo; } set { _EmailInfo = value; RaisePropertyChanged(nameof(EmailInfo)); } }

        void GetEmails()
        {
            Emails.Clear();
            foreach (var item in _serviceProxy.GetEmails()) { Emails.Add(item); }
        }

        public ICollectionView EmailsView => _emailsView?.View;

        public string FilterName
        {
            get
            {
                return _filterName;
            }
            set
            {
                if (!Set(ref _filterName, value)) return;
                EmailsView.Refresh();
            }
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