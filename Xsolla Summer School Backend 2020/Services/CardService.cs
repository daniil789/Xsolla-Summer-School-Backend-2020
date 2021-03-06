﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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
        private readonly IValidateService _validateService;
        public CardService(ApplicationContext context, IValidateService validateService)
        {
            _db = context;
            _validateService = validateService;
        }
        public Card CreateCard(Card card)
        {
            if (card == null)
            {
                throw new Exception("Карта не валидна");
            }

            if (_validateService.LuhnAlgorithm(card.Number))
                {
                _db.Cards.Add(card);
                _db.SaveChanges();
                return card;
            }
            else
            {
                throw new Exception("Карта не валидна");
            }
           
        }

        public Transfer MoneyTransfer(Transfer transfer)
        {

            if (transfer == null)
            {
                throw new Exception("Карта не валидна");
            }

            if (_validateService.LuhnAlgorithm(transfer.NumberCard))
            {
                _db.Transfers.Add(transfer);
                _db.SaveChanges();
                return transfer;
            }
            else
            {
                throw new Exception("Карта не валидна");
            }

        }


        public async Task<List<Card>> ViewCard()
        {
            return await _db.Cards.ToListAsync();
        }

       
    }
}

