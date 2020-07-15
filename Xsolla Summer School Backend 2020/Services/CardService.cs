using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Xsolla_Summer_School_Backend_2020.Interfaces;
using Xsolla_Summer_School_Backend_2020.Models;

namespace Xsolla_Summer_School_Backend_2020.Services
{
    public class CardService : ICardService
    {
        private readonly ApplicationContext _db;
        public CardService(ApplicationContext context)
        {
            _db = context;
        }
        public Card CreateCard(Card card)
        {
            if (card == null)
            {
                throw new Exception("Карта не валидна");
            }

                _db.Cards.Add(card);
                _db.SaveChanges();
                return card;
            
           
        }

        //public IEnumerable ViewCard()
        //{
        //    return _db.Cards.ToList();
        //}
    }
}
