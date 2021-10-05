using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Assignment4SimpleRESTService.Managers;
using Opgave1UnitTest;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Assignment4SimpleRESTService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FootballplayersController : ControllerBase
    {
        private readonly FootballManagers _footballManagers = new FootballManagers();

        // GET: api/<FootballplayersController>
        [HttpGet]
        public IEnumerable<FootballPlayer> Get()
        {
            return _footballManagers.GetAll();
        }

        // GET api/<FootballplayersController>/5
        [HttpGet("{id}")]
        public FootballPlayer Get(int id)
        {
            return _footballManagers.GetById(id);
        }

        // POST api/<FootballplayersController>
        [HttpPost]
        public FootballPlayer Post([FromBody] FootballPlayer value)
        {
            return _footballManagers.Add(value);
        }

        // PUT api/<FootballplayersController>/5
        [HttpPut("{id}")]
        public FootballPlayer Put(int id, [FromBody] FootballPlayer value)
        {
            return _footballManagers.Update(id, value);
        }

        // DELETE api/<FootballplayersController>/5
        [HttpDelete("{id}")]
        public FootballPlayer Delete(int id)
        {
            return _footballManagers.Delete(id);
        }
    }
}