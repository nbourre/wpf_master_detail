using System;
using System.Collections.Generic;
using System.Text;

namespace wpf_master_detail.ViewModels
{
    class MainViewModel : BaseViewModel
    {
		private BaseViewModel leftViewModel;

		public BaseViewModel LeftViewModel
		{
			get { return leftViewModel; }
			set { 
				leftViewModel = value;
				OnPropertyChanged();
			}
		}

		private BaseViewModel centralViewModel;

		public BaseViewModel CentralViewModel
		{
			get { return centralViewModel; }
			set { 
				centralViewModel = value;
				OnPropertyChanged();
			}
		}

		StudentListViewModel studentListViewModel;
		StudentViewModel studentViewModel;

		public MainViewModel()
		{
			studentViewModel = new StudentViewModel();
			studentListViewModel = new StudentListViewModel(studentViewModel);

			LeftViewModel = studentListViewModel;
			CentralViewModel = studentViewModel;

		}
	}
}
