#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Api.Data;
using api.Data.Models;
using Api.Interfaces;
using Microsoft.AspNetCore.JsonPatch;

namespace Stive.Api.Controllers
{
    [Route("api/Categorie")]
    [ApiController]
    public class StocksController : ControllerBase
    {
        private readonly ApiDbContext _context;

        public StocksController(ApiDbContext context)
        {
            _context = context;
        }

        // GET: api/Stocks
        [HttpGet]
        public IEnumerable <Stock> GetStock()
        {
            var stock = new ApiDbContext();
            var result = stock.Stock.ToList();


            return result;
        }

        // GET: api/Stocks/5
        [HttpGet("{id}")]
        public Stock GetStock(int id)
        {
            var stock = new ApiDbContext();
            return stock.Stock.Find(id = id);


           
        }

        // PATCH : api/Articles/5
        [HttpPatch("{id}")]
        public IActionResult Patch(int id, [FromBody] JsonPatchDocument<Stock> patchEntity)
        {
            var entity = _context.Stock.FirstOrDefault(stock => stock.Id == id);

            if (entity == null)
            {
                return NotFound();
            }

            patchEntity.ApplyTo(entity, ModelState); // Must have Microsoft.AspNetCore.Mvc.NewtonsoftJson installed

            return Ok(entity);
        }


        // PUT: api/Stocks/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutStock(int id, Stock stock)
        {
            if (id != stock.Id)
            {
                return BadRequest();
            }
            stock.Id = id;

            _context.Entry(stock).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!StockExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Stocks
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Stock>> PostStock(Stock stock)
        {
            _context.Stock.Add(stock);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetStock", new { id = stock.Id }, stock);
        }

        // DELETE: api/Stocks/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteStock(int id)
        {
            var stock = await _context.Stock.FindAsync(id);
            if (stock == null)
            {
                return NotFound();
            }

            _context.Stock.Remove(stock);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool StockExists(int id)
        {
            return _context.Stock.Any(e => e.Id == id);
        }



        [Route("getStockByArticleId/{id}")]
        [HttpGet]
        public int GetStockByArticleId(int id)
        {

            var stock = GetStock(id);

            return (int)stock.Quantite;
        }

    }
}
