using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RESTDemo.API.Models;

namespace RESTDemo.API.Controllers
{
    [Route("api/properties")]
    public class PropertiesController : Controller
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(PropertiesDataStore.Current.Properties);
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var propertyToReturn = PropertiesDataStore.Current.Properties.FirstOrDefault(p => p.Id == id);
            return Ok(propertyToReturn);
        }

        [HttpPost]
        public IActionResult Post([FromBody]PropertyDto property)
        {
            var PropertiesCount = PropertiesDataStore.Current.Properties.Count;
            PropertiesDataStore.Current.Properties.Insert(PropertiesCount, property);
            return Ok();
        }

        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var PropertyToRemove = PropertiesDataStore.Current.Properties.FirstOrDefault(p => p.Id == id);
            PropertiesDataStore.Current.Properties.Remove(PropertyToRemove);
            return Ok();
        }
    }
}
