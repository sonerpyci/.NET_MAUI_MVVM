using MvvmDemo.Mvvm.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvvmDemo.Mvvm.ViewModels
{
    public class PersonViewModel
    {
        public Person Person { get; set; }

        public PersonViewModel()
        {
            Person = new Person
            {
                Name = "Soner",
                Age = 28,
                Married= false,
                BirthDate = new DateTime(1995, 1, 1),
                Weight = 90,
                LunchTime = new TimeSpan(10,0,0),
            };
        }
    }
}
