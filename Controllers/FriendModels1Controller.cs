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
using Friends.Models;
using d5.Models;

namespace d5.Controllers
{
    public class FriendModels1Controller : ApiController
    {
        private IdentityModels db = new IdentityModels();

        // DELETE: api/FriendModels1/5
        [ResponseType(typeof(FriendModel))]
        public async Task<IHttpActionResult> DeleteFriendModel(int id)
        {
            if (!User.IsInRole(Roles.Administrator))
            {
                throw new HttpResponseException(HttpStatusCode.Unauthorized);
            }
            FriendModel friendModel = await db.Friends.FindAsync(id);
                if (friendModel == null)
                {
                    return NotFound();
                }

                db.Friends.Remove(friendModel);
                await db.SaveChangesAsync();

                return Ok(friendModel);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}