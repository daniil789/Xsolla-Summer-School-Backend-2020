using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Xsolla_Summer_School_Backend_2020.Interfaces;
using Xsolla_Summer_School_Backend_2020.Models;

namespace Xsolla_Summer_School_Backend_2020.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CardsController : ControllerBase
    {
       
        private readonly ICardService _cardService;
        private ApplicationContext db;

        public CardsController(ICardService cardService, ApplicationContext context)
        {
            _cardService = cardService;
            db = context;
        }

        [HttpPost("CreateCard")]
        public ActionResult CreateCard(Card card)
        {
            try
            {
                if (card.Validation() == true)
                {
                    _cardService.CreateCard(card);
                    return Ok();
                }
                else
                    return BadRequest();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
       
        [HttpGet("ViewCars")]
        public  IEnumerable<Card> ViewCard()
        {
            return db.Cards.ToList();       
        }
       

    }
}