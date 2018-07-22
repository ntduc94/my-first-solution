using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace my_first_project.Models
{
    public class Hero
    {
        public String Name { get; set; }
        public int Power { get; set; }
        public Hero(string Name, int Power)
        {
            this.Name = Name;
            this.Power = Power;
        }

    }
}