﻿using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    public interface ICompany
    {
        public string CompanyName { get; set; }
        public string CityLocation { get; set; }
        public string Slogan { get; set; }
    }
}
