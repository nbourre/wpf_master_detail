﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using wpf_master_detail.Models;
using wpf_master_detail.Services;

namespace wpf_master_detail.ViewModels
{
    class StudentListViewModel : BaseViewModel
    {
		private ObservableCollection<Student> students;

		public ObservableCollection<Student> Students
		{
			get { return students; }
			set { 
				students = value;
				OnPropertyChanged();
			}
		}

		private Student selectedStudent;

		public Student SelectedStudent
		{
			get { return selectedStudent; }
			set { 
				selectedStudent = value;
				OnPropertyChanged();
			}
		}

		StudentDataService studentDataService;

		public StudentListViewModel()
		{
			InitValues();
		}

		private void InitValues()
		{
			studentDataService = new StudentDataService();
			Students = new ObservableCollection<Student>(studentDataService.GetAll());
		}

	}
}