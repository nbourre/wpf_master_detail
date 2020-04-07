using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace wpf_master_detail.Models
{
    class Course : INotifyPropertyChanged
    {
        private string title;

        public string Title
        {
            get { return title; }
            set {
                title = value;
                OnPropertyChanged();
            }
        }

        private string number;

        public string Number
        {
            get { return number; }
            set {
                number = value;
                OnPropertyChanged();
            }
        }

        private string description;

        public string Description
        {
            get { return description; }
            set { 
                description = value;
                OnPropertyChanged();
            }
        }




        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName]string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
