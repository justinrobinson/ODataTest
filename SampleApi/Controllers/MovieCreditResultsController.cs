using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;
using SqlExpressNovember;
using SqlExpressNovember.EntityClasses;

namespace SampleApi.Controllers
{
    /// <summary>
    /// Regular API Controller
    /// </summary>
    public class MovieCreditResultsController : ApiController
    {
        private SqlExpressNovemberDataContext db = new SqlExpressNovemberDataContext();

        // GET: api/MovieCreditResults
        public IQueryable<MovieCreditResult> GetMovieCreditResults()
        {
            return db.MovieCreditResults;
        }

        // GET: api/MovieCreditResults/5
        [ResponseType(typeof(MovieCreditResult))]
        public async Task<IHttpActionResult> GetMovieCreditResult(int id)
        {
            MovieCreditResult movieCreditResult = await db.MovieCreditResults.FindAsync(id);
            if (movieCreditResult == null)
            {
                return NotFound();
            }

            return Ok(movieCreditResult);
        }

        // PUT: api/MovieCreditResults/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutMovieCreditResult(int id, MovieCreditResult movieCreditResult)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != movieCreditResult.ItemId)
            {
                return BadRequest();
            }

            db.Entry(movieCreditResult).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MovieCreditResultExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/MovieCreditResults
        [ResponseType(typeof(MovieCreditResult))]
        public async Task<IHttpActionResult> PostMovieCreditResult(MovieCreditResult movieCreditResult)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.MovieCreditResults.Add(movieCreditResult);

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (MovieCreditResultExists(movieCreditResult.ItemId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = movieCreditResult.ItemId }, movieCreditResult);
        }

        // DELETE: api/MovieCreditResults/5
        [ResponseType(typeof(MovieCreditResult))]
        public async Task<IHttpActionResult> DeleteMovieCreditResult(int id)
        {
            MovieCreditResult movieCreditResult = await db.MovieCreditResults.FindAsync(id);
            if (movieCreditResult == null)
            {
                return NotFound();
            }

            db.MovieCreditResults.Remove(movieCreditResult);
            await db.SaveChangesAsync();

            return Ok(movieCreditResult);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool MovieCreditResultExists(int id)
        {
            return db.MovieCreditResults.Count(e => e.ItemId == id) > 0;
        }
    }
}