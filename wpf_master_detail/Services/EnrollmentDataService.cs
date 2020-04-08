using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using wpf_master_detail.Models;

namespace wpf_master_detail.Services
{
    class EnrollmentDataService
    {
        List<Enrollment> enrollments;
        List<Student> students;
        List<Course> courses;

        public EnrollmentDataService(CourseDataService courseDS, StudentDataService studentDS)
        {
            courses = courseDS.GetAll().ToList();
            students = studentDS.GetAll().ToList();

            Random rnd = new Random();

            foreach(Course c in courses)
            {
                c.Enrollments = new ObservableCollection<Enrollment>();

                int nbStudentsInClass = rnd.Next(20, 26);               

                for (int i = 0; i < nbStudentsInClass; i++)
                {
                    var enrollment = new Enrollment();

                    enrollment.Course = c;
                    c.Enrollments.Add(enrollment);

                    int studentIndex = rnd.Next(students.Count);

                    if (students[studentIndex].Enrollments == null)
                    {
                        students[studentIndex].Enrollments = new ObservableCollection<Enrollment>();
                    }

                    students[studentIndex].Enrollments.Add(enrollment);
                    enrollment.Student = students[studentIndex];

                    enrollment.Grade = rnd.Next(55, 101);
                }
            }
        }


    }
}
