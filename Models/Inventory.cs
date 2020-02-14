using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UserControlPanel.Models
{
    public class Inventory
    {
        //[Key]
        //public int ID { get; set; }
        [ForeignKey("Character")]
        public int CharacterID { get; set; }
        [ForeignKey("Item")]
        public int ItemID { get; set; }
        public int Quantity { get; set; }

        public virtual Character Character { get; set; }
        public virtual Item Item { get; set; }
    }
}