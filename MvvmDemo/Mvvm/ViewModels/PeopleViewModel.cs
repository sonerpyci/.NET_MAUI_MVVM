using MvvmDemo.Mvvm.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvvmDemo.Mvvm.ViewModels
{
    public class PeopleViewModel
    {
        public List<Person> People { get; set; } = new();

        public PeopleViewModel()
        {
            People = new List<Person>
            {
                new Person{Name = "Soner", Age = 28, BirthDate = new DateTime(1995,1,1), Married = false, Weight = 90, LunchTime = new TimeSpan(12,0,0)},
                new Person{Name = "Messi", Age = 30, BirthDate = new DateTime(1993,1,1), Married = true, Weight = 75, LunchTime = new TimeSpan(13,0,0)},
                new Person{Name = "Aguero", Age = 35, BirthDate = new DateTime(1988,1,1), Married = false, Weight = 78, LunchTime = new TimeSpan(14,0,0)},
                new Person{Name = "Ronaldo", Age = 32, BirthDate = new DateTime(1991,1,1), Married = true, Weight = 80, LunchTime = new TimeSpan(15,0,0)},
                new Person{Name = "David", Age = 40, BirthDate = new DateTime(1983,1,1), Married = true, Weight = 78, LunchTime = new TimeSpan(16,0,0)},
                new Person{Name = "Bale", Age = 41, BirthDate = new DateTime(1982,1,1), Married = true, Weight = 91, LunchTime = new TimeSpan(17,0,0)},
            };
        }
    }
}
