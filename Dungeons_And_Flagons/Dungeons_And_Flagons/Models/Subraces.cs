using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Dungeons_And_Flagons.Models
{
    public class Subraces
    {
        public Subraces()
        {
            Tome = new HashSet<Spells>();
        }

        [Key]
        public int ID { get; set; }

        public String MainRace { get; set; }
        public String Name { get; set; }
        public String Description {get;set;}
        public String Features { get; set; }


        //FK to Source
        [ForeignKey(" Book")]
        public int Source { get; set; }
        public Sources Book { get; set; }

        //Fk to Spells
        public ICollection<Spells> Tome { get; set; }


    }
}
