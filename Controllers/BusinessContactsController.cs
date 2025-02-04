using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CMS_API.Data;
using CMS_API.Models;

namespace CMS_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BusinessContactsController : ControllerBase
    {
        private readonly CMS_APIContext _context;

        public BusinessContactsController(CMS_APIContext context)
        {
            _context = context;
        }

        // GET: api/BusinessContacts
        [HttpGet]
        public async Task<ActionResult<IEnumerable<BusinessContact>>> GetBusinessContact()
        {
            return await _context.BusinessContact.ToListAsync();
        }

        // GET: api/BusinessContacts/5
        [HttpGet("{id}")]
        public async Task<ActionResult<BusinessContact>> GetBusinessContact(int id)
        {
            var businessContact = await _context.BusinessContact.FindAsync(id);

            if (businessContact == null)
            {
                return NotFound();
            }

            return businessContact;
        }

        // PUT: api/BusinessContacts/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutBusinessContact(int id, BusinessContact businessContact)
        {
            if (id != businessContact.Id)
            {
                return BadRequest();
            }

            _context.Entry(businessContact).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!BusinessContactExists(id))
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

        // POST: api/BusinessContacts
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<BusinessContact>> PostBusinessContact(BusinessContact businessContact)
        {
            _context.BusinessContact.Add(businessContact);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetBusinessContact", new { id = businessContact.Id }, businessContact);
        }

        // DELETE: api/BusinessContacts/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteBusinessContact(int id)
        {
            var businessContact = await _context.BusinessContact.FindAsync(id);
            if (businessContact == null)
            {
                return NotFound();
            }

            _context.BusinessContact.Remove(businessContact);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool BusinessContactExists(int id)
        {
            return _context.BusinessContact.Any(e => e.Id == id);
        }
    }
}
