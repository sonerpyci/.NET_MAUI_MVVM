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
        public List<string> People { get; set; }

        public PeopleViewModel()
        {
            People = new List<string>
            {
                "Soner",
                "Messi",
                "Aguero",
                "Ronaldo",
                "David",
                "Bale",
            };
        }
    }
}
