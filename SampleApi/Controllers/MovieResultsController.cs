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
using System.Web.Http.ModelBinding;
using System.Web.Http.OData;
using System.Web.Http.OData.Routing;
using SqlExpressNovember;
using SqlExpressNovember.EntityClasses;

namespace SampleApi.Controllers
{
    /*
    The WebApiConfig class may require additional changes to add a route for this controller. Merge these statements into the Register method of the WebApiConfig class as applicable. Note that OData URLs are case sensitive.

    using System.Web.Http.OData.Builder;
    using System.Web.Http.OData.Extensions;
    using SqlExpressNovember.EntityClasses;
    ODataConventionModelBuilder builder = new ODataConventionModelBuilder();
    builder.EntitySet<MovieResult>("MovieResults");
    config.Routes.MapODataServiceRoute("odata", "odata", builder.GetEdmModel());
    */
    public class MovieResultsController : ODataController
    {
        private SqlExpressNovemberDataContext db = new SqlExpressNovemberDataContext();

        // GET: odata/MovieResults
        [EnableQuery]
        public IQueryable<MovieResult> GetMovieResults()
        {
            return db.MovieResults;
        }

        // GET: odata/MovieResults(5)
        [EnableQuery]
        public SingleResult<MovieResult> GetMovieResult([FromODataUri] int key)
        {
            return SingleResult.Create(db.MovieResults.Where(movieResult => movieResult.ItemId == key));
        }

        // PUT: odata/MovieResults(5)
        public async Task<IHttpActionResult> Put([FromODataUri] int key, Delta<MovieResult> patch)
        {
            Validate(patch.GetEntity());

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            MovieResult movieResult = await db.MovieResults.FindAsync(key);
            if (movieResult == null)
            {
                return NotFound();
            }

            patch.Put(movieResult);

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MovieResultExists(key))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return Updated(movieResult);
        }

        // POST: odata/MovieResults
        public async Task<IHttpActionResult> Post(MovieResult movieResult)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.MovieResults.Add(movieResult);

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (MovieResultExists(movieResult.ItemId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return Created(movieResult);
        }

        // PATCH: odata/MovieResults(5)
        [AcceptVerbs("PATCH", "MERGE")]
        public async Task<IHttpActionResult> Patch([FromODataUri] int key, Delta<MovieResult> patch)
        {
            Validate(patch.GetEntity());

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            MovieResult movieResult = await db.MovieResults.FindAsync(key);
            if (movieResult == null)
            {
                return NotFound();
            }

            patch.Patch(movieResult);

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MovieResultExists(key))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return Updated(movieResult);
        }

        // DELETE: odata/MovieResults(5)
        public async Task<IHttpActionResult> Delete([FromODataUri] int key)
        {
            MovieResult movieResult = await db.MovieResults.FindAsync(key);
            if (movieResult == null)
            {
                return NotFound();
            }

            db.MovieResults.Remove(movieResult);
            await db.SaveChangesAsync();

            return StatusCode(HttpStatusCode.NoContent);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool MovieResultExists(int key)
        {
            return db.MovieResults.Count(e => e.ItemId == key) > 0;
        }
    }
}
