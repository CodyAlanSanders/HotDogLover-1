using HotDogLover.Models;
using HotDogLover.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace HotDogLover.Controllers
{
    public class ProfileApiController : ApiController
    {
        IProfileService profileService = new ProfileService();

        // GET: api/ProfileApi
        public List<Profile> Get()
        {
            return profileService.ListAll();
        }

        // GET: api/ProfileApi/5
        public Profile Get(int id)
        {
            return profileService.Get(id);
        }

        // POST: api/ProfileApi
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/ProfileApi/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/ProfileApi/5
        public void Delete(int id)
        {
        }
    }
}
