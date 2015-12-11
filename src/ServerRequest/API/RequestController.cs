﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using ServerRequest.Models;

// For more information on enabling Web API for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace ServerRequest.API
{
    [Route("api/[controller]")]
    public class RequestController : Controller
    {
        // GET: api/values
        [HttpGet]
        public IEnumerable<Request> Get()
        {
            return new List<Request>
            {
                new Request {Id = 0, ServerName = "WebServer01", Requestor = "zjamaso" },
                new Request {Id = 1, ServerName = "WebServer02", Requestor = "zjamaso" },
                new Request {Id = 2, ServerName = "WebServer03", Requestor = "zjamaso" },
                new Request {Id = 3, ServerName = "MSMQServer01", Requestor = "zjamaso" },
                new Request {Id = 4, ServerName = "SQLServer01", Requestor = "zjamaso" }
            };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
