﻿using System;
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

        public bool Validation()
        {
            long numbercard = Convert.ToInt64(Number);
            string str = numbercard.ToString();
            int[] numcard = new int[str.Length];
            for (int i = 0; i < str.Length; i++)
            {
                numcard[i] = int.Parse(str[i].ToString());
            }

            for (int i = 0; i < numcard.Length; i += 2)
            {
                var a = numcard[i] * 2;
                numcard[i] = a;
                if (numcard[i] > 9)
                {
                    numcard[i] = numcard[i] - 9;
                }

            }
            int sumnumber = 0;
            for (int i = 0; i < numcard.Length; i++)
            {
                sumnumber = sumnumber + numcard[i];

            }
            if (sumnumber % 10 == 0)
            {
                return true;
            }
            else
                return false;
        }

    }
}
