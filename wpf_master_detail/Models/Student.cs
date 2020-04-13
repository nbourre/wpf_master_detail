using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using System.Linq;

namespace wpf_master_detail.Models
{
    class Student : INotifyPropertyChanged
    {
        private string registrationNumber;
        private string firstName;
        private string lastName;

        public int StudentId { get; set; }

        public string RegistrationNumber
        {
            get => registrationNumber;
            set
            {
                registrationNumber = value;
                OnPropertyChanged();
            }
        }

        public string FirstName
        {
            get => firstName;
            set
            {
                firstName = value;
                OnPropertyChanged();
                OnPropertyChanged(nameof(FullName));
            }
        }

        public string LastName
        {
            get => lastName;
            set
            {
                lastName = value;
                OnPropertyChanged();
                OnPropertyChanged(nameof(FullName));
            }
        }

        public string FullName => $"{LastName}, {FirstName}";

        private ObservableCollection<Enrollment> enrollments;
        public ObservableCollection<Enrollment> Enrollments
        {
            get => enrollments;
            set
            {
                enrollments = value;
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
