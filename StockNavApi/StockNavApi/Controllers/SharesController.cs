using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StockNavApi.Models;

namespace StockNavApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SharesController : ControllerBase
    {
        private readonly StockContext _context;

        public SharesController(StockContext context)
        {
            _context = context;
        }

        // GET: api/Shares
        //Get all shares in the database
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Share>>> GetShares()
        {
            return await _context.Shares.ToListAsync();
        }

        // GET: api/Shares/5
        // Get shares based on the share id
        // This method should only be used if the user wants to sell their share
        [HttpGet("{id}")]
        public async Task<ActionResult<Share>> GetShare(int id)
        {
            var share = await _context.Shares.FindAsync(id);

            if (share == null)
            {
                return NotFound();
            }

            return share;
        }

        // PUT: api/Shares/5
        // Updates shares based on user input
        // The only user input that would change this is changing the sold bool
        // Everything else should be automatically updated
        [HttpPut("{id}")]
        public async Task<IActionResult> PutShare(int id, Share share)
        {
            if (id != share.Id)
            {
                return BadRequest();
            }

            _context.Entry(share).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ShareExists(id))
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

        // POST: api/Shares
        // Create new shares based on user input
        [HttpPost]
        public async Task<ActionResult<Share>> PostShare(Share share)
        {
            _context.Shares.Add(share);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetShare", new { id = share.Id }, share);
        }

        // DELETE: api/Shares/5
        // Delete shares by their id number
        [HttpDelete("{id}")]
        public async Task<ActionResult<Share>> DeleteShare(int id)
        {
            var share = await _context.Shares.FindAsync(id);
            if (share == null)
            {
                return NotFound();
            }

            _context.Shares.Remove(share);
            await _context.SaveChangesAsync();

            return share;
        }

        private bool ShareExists(int id)
        {
            return _context.Shares.Any(e => e.Id == id);
        }
    }
}
