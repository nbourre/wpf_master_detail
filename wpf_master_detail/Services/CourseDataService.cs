using System;
using System.Collections.Generic;
using System.Text;
using wpf_master_detail.Models;

namespace wpf_master_detail.Services
{
    class CourseDataService : IDataService<Course>
    {
        List<Course> courses;

        public CourseDataService()
        {
            InitValues();
        }

        public IEnumerable<Course> GetAll()
        {
            foreach (Course c in courses)
            {
                yield return c;
            }
        }

        private void InitValues()
        {
            courses = new List<Course>()
            {
                new Course{ Title = "Analyse relationnelle", Number="420-000-SW", Description = "On fait de l'analyse relationnelle"},
                new Course{ Title = "Échange de données 2", Number="420-000-SW", Description = "On échange des données"},
                new Course{ Title = "Développement d'application d'entreprise 1", Number="420-000-SW", Description = "On développe des applis"},
                new Course{ Title = "Gestion de projet", Number="420-000-SW", Description = "On gère son projet"},
                new Course{ Title = "Web serveur 1", Number="420-000-SW", Description = "On sert un web 1"},

            };
        }

        
    }
}
