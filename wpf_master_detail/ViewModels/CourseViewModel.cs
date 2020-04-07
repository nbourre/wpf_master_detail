using System;
using System.Collections.Generic;
using System.Text;
using wpf_master_detail.Models;

namespace wpf_master_detail.ViewModels
{
    class CourseViewModel : BaseViewModel
    {
		private Course course;

		public Course Course
		{
			get { return course; }
			set { 
				course = value;
				OnPropertyChanged();
			}
		}

	}
}
