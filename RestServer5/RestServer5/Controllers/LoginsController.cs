using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using RestServer5.Models;

namespace RestServer5.Controllers
{
    public class LoginsController : ApiController
    {
        List<Login> logins = new List<Login> 
        { 
            new Login { Id = 1, date = "01/01/1901 10:02 AM"}, 
            new Login { Id = 2, date = "02/01/1901 10:02 AM"}, 
            new Login { Id = 3, date = "03/01/1901 10:02 AM"}
        };
        // GET api/values
        public List<Login> Get()
        {
            return logins;
        }

        // GET api/values/5
        public string Get(int id)
        {
            foreach (Login l in logins)
                if (l.Id == id)
                    return "ID: " + l.Id + " DATE: " + l.date;
            return "no logins found with that ID";
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        public List<Login> Put(int id)
        {
            logins.Add(new Login {Id = id, date = DateTime.Now.ToString("MM/dd/yyyy h:mm tt") });
            return logins;
        }

        public List<Login> Put()
        {
            logins.Add(new Login { Id = logins.Capacity, date = DateTime.Now.ToString("MM/dd/yyyy h:mm tt") });
            return logins;
        }

        // DELETE api/values/5
        public List<Login> Delete(int id)
        {
            var temp = 0;
            foreach (Login l in logins)
            {
                if (l.Id == id)
                { 
                    temp = logins.IndexOf(l);
                }
            }
            logins.RemoveAt(2);
            return logins;
        }
    }
}