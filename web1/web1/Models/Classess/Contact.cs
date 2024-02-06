using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace web1.Models.Classess
{
    public class Contact
    {
        [Key] 
        public int ID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Message { get; set; }


    }
}