﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace personeel_service.Models
{
    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string FontysId { get; set; }

        /*public Person(int id, string name, string email)
        {
            Id = id;
            Name = name;
            Email = email;
        }*/

    }
}
