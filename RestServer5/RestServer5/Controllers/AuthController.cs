using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using RestServer5.Models;

namespace RestServer5.Controllers
{
    public class AuthController : ApiController
    {
        List<User> user = new List<User> 
        { 
            new User { Id = 1, Name = "fido", Password = "1234pass"}, 
            new User { Id = 2, Name = "Yo-yo", Password = "Toys"}, 
            new User { Id = 3, Name = "Hammer", Password = "Hardware"} 
        };
        // GET api/values
        public List<User> Get()
        {
            return user;
        }

        // GET api/values/5
        public string Get(int id)
        {
            foreach (User u in user)
            {
                if (u.Id == id)
                    return "User: " + u.Name + " Pass: " + u.Password;
            }
            return "No user found with that ID";
        }

        // POST api/values
        public Boolean Post(string uname, string pword)
        {
            //if we were using a DB we would write code to put a record in the login tracker for each attempt here
            foreach (User u in user)
            {
                if (u.Password == pword)
                    return true;
            }
            return false;
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}