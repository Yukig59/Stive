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

namespace Stive.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FournisseursController : ControllerBase
    {
        private readonly ApiDbContext _context;

        public FournisseursController(ApiDbContext context)
        {
            _context = context;
        }

        // GET: api/Fournisseurs
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Fournisseurs>>> GetFournisseurs()
        {
            return await _context.Fournisseurs.ToListAsync();
        }

        // GET: api/Fournisseurs/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Fournisseurs>> GetFournisseurs(int id)
        {
            var fournisseurs = await _context.Fournisseurs.FindAsync(id);

            if (fournisseurs == null)
            {
                return NotFound();
            }

            return fournisseurs;
        }

        // PUT: api/Fournisseurs/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutFournisseurs(int id, Fournisseurs fournisseurs)
        {
            fournisseurs.Id = id;
            _context.Entry(fournisseurs).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!FournisseursExists(id))
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

        // POST: api/Fournisseurs
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Fournisseurs>> PostFournisseurs(Fournisseurs fournisseurs)
        {
            _context.Fournisseurs.Add(fournisseurs);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetFournisseurs", new { id = fournisseurs.Id }, fournisseurs);
        }

        // DELETE: api/Fournisseurs/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteFournisseurs(int id)
        {
            var fournisseurs = await _context.Fournisseurs.FindAsync(id);
            if (fournisseurs == null)
            {
                return NotFound();
            }

            _context.Fournisseurs.Remove(fournisseurs);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool FournisseursExists(int id)
        {
            return _context.Fournisseurs.Any(e => e.Id == id);
        }
    }
}
