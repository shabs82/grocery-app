using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GroceryApp.Core.AppService;
using GroceryApp.Core.Entities;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace GroceryApp.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StoreController : ControllerBase
    {
        private readonly IStoreService _storeService;

        public StoreController(IStoreService storeService)
        {
            _storeService = storeService;
        }
        // GET: api/<StoreController>
        [HttpGet]
        public ActionResult Get()
        {
            return Ok(_storeService.ReadAll());
        }

        // GET api/<StoreController>/5
        [HttpGet("{id}")]
        public ActionResult<IEnumerable<Stores>> Get( int id)
        {
            try
            {
                if (id > 0)
                {
                    return Ok(_storeService.ReadById(id));
                }

                return BadRequest();


            }
            catch (Exception e)
            {
                return StatusCode(500, e.Message);
            }
        }

        // POST api/<StoreController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<StoreController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<StoreController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
