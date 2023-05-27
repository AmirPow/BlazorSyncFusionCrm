using BlazorSyncFusionCm.Server.Data;
using BlazorSyncFusionCm.Shared;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Syncfusion.Blazor.Diagram;

namespace BlazorSyncFusionCm.Server.Contorollers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NotesController : ControllerBase
    {
        private readonly DataContext context;

        public NotesController(DataContext context )
        {
            this.context = context;
        }
        [HttpGet]
        public async Task<ActionResult<List<Note>>> GetAllNotes()
        {
            return await context.Nots.Include(a => a.Contact)
                .OrderByDescending(a => a.DateCreated).ToListAsync();
        }


        [HttpGet("{contactId}")]
        public async Task<ActionResult<List<Note>>> GetNotesFromContact(int contactId)
        {
            
            var result =  await context.Nots.Where(a => a.ContactId ==contactId)
                .OrderByDescending(a => a.DateCreated).ToListAsync();
            return Ok(result);
        }

        [HttpPost]
        public async Task<ActionResult<List<Note>>> CreateNote(Note note)
        {
            context.Nots.Add(note);
            await context.SaveChangesAsync();
            return await context.Nots.Where(a => a.ContactId == note.ContactId)
                .OrderByDescending(a => a.DateCreated).ToListAsync();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<List<Note>>> DeleteNote(int id)
        {
            var dbNote= await context.Nots.FindAsync(id);
            if(dbNote is null)
            {
                return NotFound("NotFound");
            }
            context.Nots.Remove(dbNote);
            await context.SaveChangesAsync();
            return await context.Nots.Where(a => a.ContactId == dbNote.ContactId)
       .OrderByDescending(a => a.DateCreated).ToListAsync();
        }
    }
}
