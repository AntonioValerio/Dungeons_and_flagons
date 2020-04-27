using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Dungeons_And_Flagons.Models
{
    public class Subclasses
    {
        [Key]
        public int ID { get; set; }
        public String description { get; set; }
        public String features { get; set; }


    }
}
