using Lab01Shvets.Models;
using Lab01Shvets.Tools;
using System.ComponentModel;
using System.Windows;

namespace Lab01Shvets.ViewModels
{
    class ZodiacViewModel : INotifyPropertyChanged
    {
        private readonly User _user = new();
        private int _age;
        private string _westernZodiac = "";
        private string _chineseZodiac = "";

        public void SetBirthDate(DateTime date)
        {
            BirthDate = date;
        }

        public DateTime BirthDate
        {
            get { return _user.BirthDate; }
            set
            {
                if (DateHandler.IsIncorrect(value))
                {
                    MessageBox.Show("Error! It is a wrong birthday!");
                    return;
                }
                _user.BirthDate = value;
                UpdateData();
                OnPropertyChanged(nameof(BirthDate));
            }
        }

        public int Age
        {
            get { return _age; }
            set
            {
                _age = value;
                OnPropertyChanged(nameof(Age));
            }
        }

        public string WesternZodiac
        {
            get { return _westernZodiac; }
            set
            {
                _westernZodiac = value;
                OnPropertyChanged(nameof(WesternZodiac));
            }
        }

        public string ChineseZodiac
        {
            get { return _chineseZodiac; }
            set
            {
                _chineseZodiac = value;
                OnPropertyChanged(nameof(ChineseZodiac));
            }
        }

        private void UpdateData()
        {
            WesternZodiac = DateHandler.WesternZodiac(_user.BDay, _user.BMonth);
            ChineseZodiac = DateHandler.ChineseZodiac(_user.BYear);
            Age = DateHandler.Age(_user.BirthDate);
            if (DateHandler.BirthdayIsToday(_user.BirthDate))
                MessageBox.Show("Happy Birthday!");
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
