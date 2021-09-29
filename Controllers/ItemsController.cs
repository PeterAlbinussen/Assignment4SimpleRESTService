using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Assignment4SimpleRESTService.Managers;
using Assignment4SimpleRESTService.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Assignment4SimpleRESTService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ItemsController : ControllerBase
    {
        private readonly ItemsManager _manager = new ItemsManager();


        // GET: api/<BooksController>
        [HttpGet]
        public IEnumerable<Item> Get()
        {
            return _manager.GetAll();
        }


        // GET api/<ItemsContrBookr>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<ItemsController>
        [HttpPost]
        public Item Post([FromBody] Item value)
        {
            return _manager.Add(value);
        }

        // PUT api/<BooksController>/5
        [HttpPut("{id}")]
        public Item Put(int id, [FromBody] Item value)
        {
            return _manager.Update(id, value);
        }

        // DELETE api/<ItemsController>/5
        [HttpDelete("{id}")]
        public Item Delete(int id)
        {
            return _manager.Delete(id);
        }
    }
}
