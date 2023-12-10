﻿using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CetContact.Model
{
    public class ContactInfo
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; } 
        
        public string Name { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }

        //public override string ToString()
        //{
        //    return $"{Name} ({Phone})";
        //}
    }
}
