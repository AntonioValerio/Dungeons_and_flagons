using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Dungeons_And_Flagons.Models
{
    public class SubclassSpell
    {
        [Key][ForeignKey(nameof(Subclass))]
        public int SubclassID { get; set; }
        public Subclasses Subclass { get; set; }

        [Key]
        [ForeignKey(nameof(Classe))]
        public int ClasseID { get; set; }
        public Subclasses Classe { get; set; }

        [Key]
        [ForeignKey(nameof(Tome))]
        public int SpellID { get; set; }
        public Subclasses Tome { get; set; }


    }
}
