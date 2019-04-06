using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using ApiProyect.Models;

namespace ApiProyect.Controllers
{
    public class ChristianYabetaFriendsController : ApiController
    {
        private DataContext db = new DataContext();

        // GET: api/ChristianYabetaFriends
        public IQueryable<ChristianYabetaFriends> GetChristianYabetaFriends()
        {
            return db.ChristianYabetaFriends;
        }

        // GET: api/ChristianYabetaFriends/5
        [ResponseType(typeof(ChristianYabetaFriends))]
        public IHttpActionResult GetChristianYabetaFriends(int id)
        {
            ChristianYabetaFriends christianYabetaFriends = db.ChristianYabetaFriends.Find(id);
            if (christianYabetaFriends == null)
            {
                return NotFound();
            }

            return Ok(christianYabetaFriends);
        }

        // PUT: api/ChristianYabetaFriends/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutChristianYabetaFriends(int id, ChristianYabetaFriends christianYabetaFriends)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != christianYabetaFriends.FriendID)
            {
                return BadRequest();
            }

            db.Entry(christianYabetaFriends).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ChristianYabetaFriendsExists(id))
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

        // POST: api/ChristianYabetaFriends
        [ResponseType(typeof(ChristianYabetaFriends))]
        public IHttpActionResult PostChristianYabetaFriends(ChristianYabetaFriends christianYabetaFriends)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.ChristianYabetaFriends.Add(christianYabetaFriends);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = christianYabetaFriends.FriendID }, christianYabetaFriends);
        }

        // DELETE: api/ChristianYabetaFriends/5
        [ResponseType(typeof(ChristianYabetaFriends))]
        public IHttpActionResult DeleteChristianYabetaFriends(int id)
        {
            ChristianYabetaFriends christianYabetaFriends = db.ChristianYabetaFriends.Find(id);
            if (christianYabetaFriends == null)
            {
                return NotFound();
            }

            db.ChristianYabetaFriends.Remove(christianYabetaFriends);
            db.SaveChanges();

            return Ok(christianYabetaFriends);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool ChristianYabetaFriendsExists(int id)
        {
            return db.ChristianYabetaFriends.Count(e => e.FriendID == id) > 0;
        }
    }
}