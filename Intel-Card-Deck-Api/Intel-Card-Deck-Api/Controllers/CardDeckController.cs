using Microsoft.AspNetCore.Mvc;
using Intel_Card_Deck_Api.Models;
using Intel_Card_Deck_Api.Helpers;
using Microsoft.AspNetCore.Cors;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Intel_Card_Deck_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    
    public class CardDeckController : ControllerBase
    {
        // GET: api/<CardDeckController>
        [HttpGet]
        
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<CardDeckController>/5
        //[HttpGet("{id}")]
        //public ActionResult<string> GetSortedCards(CardDeck value)
        //{
        //    try
        //    {
        //        String[] elements = value.CardList.Split(",");

        //        value.Cards = elements.ToList();
        //        value.Cards = CardDeckHelper.GetSortedCards(value.Cards);
        //        value.CardList = String.Join(" | ", value.Cards);
        //    }
        //    catch (Exception ex)
        //    {
        //        throw;
        //    }
        //    return CreatedAtAction(nameof(PostCardDeck), new { id = value.Cards });
        //}

        // POST api/<CardDeckController>
        [HttpPost]
        
        public ActionResult<string> PostCardDeck([FromBody] CardDeck value)
        {
            try
            {
                String[] elements = value.CardList.Split(",");

                value.Cards = elements.ToList();
                value.Cards = CardDeckHelper.GetSortedCards(value.Cards);
                value.CardList = String.Join(" | ", value.Cards);
            }
            catch(Exception ex)
            {
                throw;
            }
            return CreatedAtAction(nameof(PostCardDeck), new { id = value.Cards });
        }
    }
}
