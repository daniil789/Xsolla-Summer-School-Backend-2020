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

        public CardsController(ICardService cardService, ApplicationContext context)
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
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost("MoneyTransfer")]
        public int MoneyTransfer(Transfer transfer)
        {
            try
            {
                _cardService.MoneyTransfer(transfer);
                return transfer.SessionId;
            }
            catch
            {
                throw new Exception("Неудача");
            }
        }

        [HttpGet("ViewCars")]
        public async Task<List<Card>> ViewCard()
        {
            return await _cardService.ViewCard();     
        }
       

    }
}