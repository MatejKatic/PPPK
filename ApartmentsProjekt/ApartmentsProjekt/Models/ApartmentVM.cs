﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ApartmentsProjekt.Models
{
    public class ApartmentVM
    {
        public Apartment Apartment { get; set; }

        public IEnumerable<Osoba> People { get; set; }

        public int vlasnikID { get; set; }

    }
}