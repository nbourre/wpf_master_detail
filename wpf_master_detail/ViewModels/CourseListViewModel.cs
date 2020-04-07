using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using wpf_master_detail.Models;
using wpf_master_detail.Services;

namespace wpf_master_detail.ViewModels
{
    class CourseListViewModel : BaseViewModel
    {
		private ObservableCollection<Course> courses;

		public ObservableCollection<Course> Courses
		{
			get { return courses; }
			set
			{
				courses = value;
				OnPropertyChanged();
			}
		}

		private Course selectedCourse;

		public Course SelectedCourse
		{
			get { return selectedCourse; }
			set
			{
				selectedCourse = value;
				courseViewModel.Course = selectedCourse;
				OnPropertyChanged();
			}
		}

		CourseDataService courseDataService;
		CourseViewModel courseViewModel;

		public CourseListViewModel(CourseViewModel vm)
		{
			InitValues();

			courseViewModel = vm;
		}

		private void InitValues()
		{
			courseDataService = new CourseDataService();
			Courses = new ObservableCollection<Course>(courseDataService.GetAll());
		}

	}
}
