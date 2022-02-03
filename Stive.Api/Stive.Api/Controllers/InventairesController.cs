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
using Microsoft.AspNetCore.JsonPatch;
using Stive.Api.Service;

namespace Stive.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InventairesController : ControllerBase
    {
        private readonly ApiDbContext _context;

        public InventairesController(ApiDbContext context)
        {
            _context = context;
        }

        // GET: api/Inventaires
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Inventaire>>> GetInventaire()
        {
            return await _context.Inventaire.ToListAsync();
        }

        // GET: api/Inventaires/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Inventaire>> GetInventaire(int id)
        {
            var inventaire = await _context.Inventaire.FindAsync(id);

            if (inventaire == null)
            {
                return NotFound();
            }

            return inventaire;
        }

        // PUT: api/Inventaires/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutInventaire(int id, Inventaire inventaire)
        {
            if (id != inventaire.Id)
            {
                return BadRequest();
            }



            _context.Entry(inventaire).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!InventaireExists(id))
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

        [Route("updateStockByArticleId/{id}")]
        [HttpPut]
        public IActionResult SetUpdateStock(int id, int stock)
        {
            var service = new StockService(_context);
            service.SetUpdateStockInventaire(id, stock);
            return Ok(service);

        }

        // POST: api/Inventaires
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Inventaire>> PostInventaire(Inventaire inventaire)
        {
            _context.Inventaire.Add(inventaire);
            await _context.SaveChangesAsync();

            //var stock = GetStockArticle(inventaire.ArticleId);
            //StocksController stockController = GetStockController();
            //_ = stockController.PutStock(inventaire.ArticleId, stock);

            return CreatedAtAction("GetInventaire", new { id = inventaire.Id }, inventaire);
        }

        // DELETE: api/Inventaires/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteInventaire(int id)
        {
            var inventaire = await _context.Inventaire.FindAsync(id);
            if (inventaire == null)
            {
                return NotFound();
            }

            _context.Inventaire.Remove(inventaire);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool InventaireExists(int id)
        {
            return _context.Inventaire.Any(e => e.Id == id);
        }

        // PATCH : api/Inventaire/5
        [HttpPatch("{id}")]
        public IActionResult Patch(int id, [FromBody] JsonPatchDocument<Inventaire> patchEntity)
        {
            var entity = _context.Inventaire.FirstOrDefault(inventaire => inventaire.Id == id);

            if (entity == null)
            {
                return NotFound();
            }

            patchEntity.ApplyTo(entity, ModelState); // Must have Microsoft.AspNetCore.Mvc.NewtonsoftJson installed

            return Ok(entity);
        }





    }
}
