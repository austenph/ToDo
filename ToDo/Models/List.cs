using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ToDo.Models
{
    public class List
    {
        [Key]
        public int listID { get; set;}

        public string Title { get; set; }
        DateTime Date { get; set; }
         
    }
}