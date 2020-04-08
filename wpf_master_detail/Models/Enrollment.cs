using System;
using System.Collections.Generic;
using System.Text;

namespace wpf_master_detail.Models
{
    class Enrollment
    {
		private Student student;

		public Student Student
		{
			get { return student; }
			set { student = value; }
		}

		public string StudentName => Student.FullName;

		private Course course;

		public Course Course
		{
			get { return course; }
			set { course = value; }
		}

		public string CourseTitle => Course.Title;

		private int grade;

		public int Grade
		{
			get { 
				return grade; 
			}
			set { 
				grade = value; 
			}
		}


	}
}
