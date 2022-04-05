using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CIBB_Data.Models;
using wsCIBB.Request;
using System.Diagnostics;

namespace wsCIBB.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TblCibbRegistroesController : ControllerBase
    {
        private readonly CIBB_Reg _context;

        public TblCibbRegistroesController(CIBB_Reg context)
        {
            _context = context;
        }

        // GET: api/TblCibbRegistroes
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TblCibbRegistro>>> GetTblCibbRegistros()
        {
            return await _context.TblCibbRegistros.ToListAsync();
        }

        // GET: api/TblCibbRegistroes/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TblCibbRegistro>> GetTblCibbRegistro(int id)
        {
            var tblCibbRegistro = await _context.TblCibbRegistros.FindAsync(id);

            if (tblCibbRegistro == null)
            {
                return NotFound();
            }

            return tblCibbRegistro;
        }

        // PUT: api/TblCibbRegistroes/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTblCibbRegistro(int id, TblCibbRegistro tblCibbRegistro)
        {
            if (id != tblCibbRegistro.Idcibbregistro)
            {
                return BadRequest();
            }

            _context.Entry(tblCibbRegistro).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TblCibbRegistroExists(id))
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

        // POST: api/TblCibbRegistroes
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<TblCibbRegistro>> PostTblCibbRegistro(TblCibbRegistro tblCibbRegistro)
        {
            _context.TblCibbRegistros.Add(tblCibbRegistro);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetTblCibbRegistro", new { id = tblCibbRegistro.Idcibbregistro }, tblCibbRegistro);
        }

        // DELETE: api/TblCibbRegistroes/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTblCibbRegistro(int id)
        {
            var tblCibbRegistro = await _context.TblCibbRegistros.FindAsync(id);
            if (tblCibbRegistro == null)
            {
                return NotFound();
            }

            _context.TblCibbRegistros.Remove(tblCibbRegistro);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool TblCibbRegistroExists(int id)
        {
            return _context.TblCibbRegistros.Any(e => e.Idcibbregistro == id);
        }

        [Consumes("multipart/form-data")]
        [HttpPost]
        [Route("")]
        public async Task uploadFile([FromForm] presentacionesRequest request) {
            //Debug.WriteLine();
        }
    }
}
