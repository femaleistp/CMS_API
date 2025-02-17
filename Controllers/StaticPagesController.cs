using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CMS_API.Data;
using CMS_API.Models;
using Microsoft.AspNetCore.Authorization;

namespace CMS_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StaticPagesController : ControllerBase
    {
        private readonly CMS_APIContext _context;

        public StaticPagesController(CMS_APIContext context)
        {
            _context = context;
        }

        // GET: api/StaticPages
        [AllowAnonymous]
        [HttpGet]
        public async Task<ActionResult<IEnumerable<StaticPage>>> GetStaticPage()
        {
            return await _context.StaticPage.ToListAsync();
        }

        // GET: api/StaticPages/5
        [AllowAnonymous]
        [HttpGet("{id}")]
        public async Task<ActionResult<StaticPage>> GetStaticPage(int id)
        {
            var staticPage = await _context.StaticPage.FindAsync(id);

            if (staticPage == null)
            {
                return NotFound();
            }

            return staticPage;
        }

        // PUT: api/StaticPages/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [Authorize]
        [HttpPut("{id}")]
        public async Task<IActionResult> PutStaticPage(int id, StaticPage staticPage)
        {
            if (id != staticPage.Id)
            {
                return BadRequest();
            }

            _context.Entry(staticPage).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!StaticPageExists(id))
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

        // POST: api/StaticPages
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [Authorize]
        [HttpPost]
        public async Task<ActionResult<StaticPage>> PostStaticPage(StaticPage staticPage)
        {
            _context.StaticPage.Add(staticPage);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetStaticPage", new { id = staticPage.Id }, staticPage);
        }

        // DELETE: api/StaticPages/5
        [Authorize]
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteStaticPage(int id)
        {
            var staticPage = await _context.StaticPage.FindAsync(id);
            if (staticPage == null)
            {
                return NotFound();
            }

            _context.StaticPage.Remove(staticPage);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool StaticPageExists(int id)
        {
            return _context.StaticPage.Any(e => e.Id == id);
        }
    }
}
