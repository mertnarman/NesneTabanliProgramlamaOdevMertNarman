using System;
using System.ComponentModel;
using System.Text.RegularExpressions;

namespace UyeKayit
{
    public class Uye : INotifyPropertyChanged, IDataErrorInfo
    {
        private string ad;
        private string mail;

        public string Ad
        {
            get { return ad; }
            set
            {
                ad = value;
                OnPropertyChanged("Ad");
            }
        }

        public string Mail
        {
            get { return mail; }
            set
            {
                mail = value;
                OnPropertyChanged("Mail");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public string this[string columnName]
        {
            get
            {
                string hata = string.Empty;

                if (columnName == "Mail")
                {
                    if (string.IsNullOrWhiteSpace(Mail))
                        hata = "Mail boş geçilemez.";
                    else if (!Regex.IsMatch(Mail, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
                        hata = "Geçersiz mail adresi.";
                }

                return hata;
            }
        }

        public string Error => null;
    }
}
