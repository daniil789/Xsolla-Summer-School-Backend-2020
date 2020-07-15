using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Xsolla_Summer_School_Backend_2020.Models
{
    public class Card
    {
        
        public string Number { get; set; }
        public int CVC { get; set; }
        //public DateTime Date { get; set; }
        [Key]
        public int SessionId { get; set; }

    }
}
