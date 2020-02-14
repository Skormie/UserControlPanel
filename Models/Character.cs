using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace UserControlPanel.Models
{
    public enum Job
    {
        SWORDMAN,
        WIZARD,
        SAGE,
        PROFFESSOR,
        SNIPER,
        CHAMPION,
        THEIF,
        ASSASSIN,
        PALADIN,
        ACOLYTE,
        PREIST,
        MONK
    }

    public class Character
    {
        [ForeignKey("Login")]
        public int LoginID { get; set; }
        [Key]
        public int ID { get; set; }
        public string Name { get; set; }
        public int Level { get; set; }
        public Job Class { get; set; }
        public int Experience { get; set; }
        public int Next { get; set; }
        public DateTime CharacterCreationDate { get; set; }

        public virtual Login Login { get; set; }
    }
}