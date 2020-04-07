using System;
using System.Collections.Generic;
using System.Text;
using wpf_master_detail.Models;

namespace wpf_master_detail.ViewModels
{
    class StudentViewModel : BaseViewModel
    {
		private Student student;

		public Student Student
		{
			get { return student; }
			set { 
				student = value;
				OnPropertyChanged();
			}
		}
	}
}
