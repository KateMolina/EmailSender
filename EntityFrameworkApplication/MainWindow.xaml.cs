using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace EntityFrameworkApplication
{
    public partial class MainWindow : Window
    {
        private readonly DatabaseContainer databaseContainer = new DatabaseContainer();
        public List<Track> TracksList;
        public MainWindow()
        {
            InitializeComponent();
            DataContext = databaseContainer;
        }

        private void MainWindow_OnLoaded(object sender, RoutedEventArgs e)
        {
            ReloadTracksList();
        }

        private void AddButton_OnClick(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(ArtistNameTxt.Text) && !string.IsNullOrWhiteSpace(TrackNameTxt.Text))
            {
                AddNewTrack();
                ReloadTracksList();
            }

        }

        private void AddNewTrack()
        {
            databaseContainer.Tracks.Add(new Track
            {
                ArtistName = ArtistNameTxt.Text,
                TrackName = TrackNameTxt.Text
            });
            databaseContainer.SaveChanges();
        }

        private void ReloadTracksList()
        {
            TracksList = databaseContainer.Tracks.ToList();
            Grid.ItemsSource = TracksList;
        }
    }
}
