using System.ComponentModel;

namespace WebApp.Models
{
    public class ViewModelMain : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private void NotifyPropertyChange(string info)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(info));
            }

            
        }
        string region;
        public string Region
        {
            get { return region; }
            set { region = value; NotifyPropertyChange(region); }
        }

        string summonerName;
        public string SummonerName
        {
            get { return summonerName; }
            set { summonerName = value; NotifyPropertyChange(summonerName); }
        }

    }
}
