using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace web1.Models.Classess
{
    public class HomePage
    {
        [Key]
        public int ID { get; set; } 
        public string Header { get; set; }
        public string Explanation { get; set; }

    }
}