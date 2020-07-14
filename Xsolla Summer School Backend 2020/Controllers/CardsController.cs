using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Xsolla_Summer_School_Backend_2020.Interfaces;
using Xsolla_Summer_School_Backend_2020.Models;

namespace Xsolla_Summer_School_Backend_2020.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CardsController : ControllerBase
    {
       
        private readonly ICardService _cardService;

        public CardsController(ICardService cardService)
        {
            _cardService = cardService;

        }

        [HttpPost("CreateCard")]
        public ActionResult CreateCard(Card card)
        {
            try
            {
                _cardService.CreateCard(card);
                return Ok();

            }
            catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
       

    }
}