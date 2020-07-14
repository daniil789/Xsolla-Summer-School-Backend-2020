using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Xsolla_Summer_School_Backend_2020.Models;

namespace Xsolla_Summer_School_Backend_2020.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CardsController : ControllerBase
    {
        ApplicationContext db;

        public CardsController(ApplicationContext context)
        {
            db = context; 
        }

        [HttpPost]
        public ActionResult CreateCard(Card card)
        {
            if (card == null)
            {
                return BadRequest();
            }

            db.Cards.Add(card);
            db.SaveChanges();
            return Ok(card);
        }
       

    }
}