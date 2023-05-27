using BlazorSyncFusionCm.Server.Data;
using BlazorSyncFusionCm.Shared;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BlazorSyncFusionCm.Server.Contorollers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactsController : ControllerBase
    {
        private readonly DataContext context;

        public ContactsController(DataContext context)
        {
            this.context = context;
        }
        [HttpGet]
        public async Task<ActionResult<List<Contact>>> GetAll()
        {
            return await context.contacts.Where(a=> !a.IsDeleted).ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Contact>> GetContactById(int id)
        {
            var result = await context.contacts.FindAsync(id);
            if (result is null)
            {
                return NotFound("Contact Not Found");
            }
            return result;
        }

        [HttpPost]
        public async Task<ActionResult<Contact>> CreateContact(Contact contact)
        {
            try
            {
                context.contacts.Add(contact);
                await context.SaveChangesAsync();
                return Ok(contact);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            } 
        }
        [HttpPut("{id}")]
        public async Task<ActionResult<Contact>> UpdateContact(int id , Contact contact)
        {
            var dbContact = await context.contacts.FindAsync(id);
            if(dbContact is null)
            {
                return NotFound("ContactNotDounf");
            }
            dbContact.FirstName = contact.FirstName;
            dbContact.LastName = contact.LastName;
            dbContact.NickName = contact.NickName;
            dbContact.DateOfBirth = contact.DateOfBirth;
            dbContact.Place = contact.Place;
            dbContact.DateUpdated  = contact.DateUpdated;
            await context.SaveChangesAsync();
            return Ok(contact);
        }
        [HttpDelete("{id}")]
        public async Task<ActionResult<List<Contact>>> DeleteContact(int id)
        {
            var dbContact = await context.contacts.FindAsync(id);
            if (dbContact is null)
            {
                return NotFound("ContactNotDounf");
            }
            dbContact.IsDeleted = true;
            dbContact.DateDeleted = DateTime.Now;
            await context.SaveChangesAsync();
            return await GetAll();
        }
    }
}
