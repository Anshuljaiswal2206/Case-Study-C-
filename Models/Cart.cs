using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebApplication9.Models
{
    public class Cart
    {
       [Key]
        public int Id { get; set; }
       public int MenuItemId { get; set; }
        public MenuItem MenuItem { get; set; }
    }
}