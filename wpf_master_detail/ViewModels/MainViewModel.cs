using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using wpf_master_detail.Services;
using wpf_master_detail.ViewModels.Commands;

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
		
		CourseViewModel courseViewModel;
		CourseListViewModel courseListViewModel;

		public ChangeViewCommand ChangeViewCommand { get; set; }

		public MainViewModel()
		{
			ChangeViewCommand = new ChangeViewCommand(ChangeView);

			studentViewModel = new StudentViewModel();
			studentListViewModel = new StudentListViewModel(studentViewModel);

			courseViewModel = new CourseViewModel();
			courseListViewModel = new CourseListViewModel(courseViewModel);

			EnrollmentDataService enrollmentDataService = 
				new EnrollmentDataService(
					courseListViewModel.courseDataService, 
					studentListViewModel.studentDataService);

			LeftViewModel = courseListViewModel;
			CentralViewModel = courseViewModel;

		}

		private void ChangeView(string vm)
		{
			switch (vm)
			{
				case "student":
					LeftViewModel = studentListViewModel;
					CentralViewModel = studentViewModel;
					break;
				case "course":
					LeftViewModel = courseListViewModel;
					CentralViewModel = courseViewModel;
					break;
			}
		}
	}
}
