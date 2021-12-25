using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace web_odev.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private Context db;
        public ValuesController(Context dbc)
        {
            db = dbc;
        }

        // GET: api/<ValuesController>
        [HttpGet]
        public IEnumerable<Arac> Get()
        {
            var arac = db.Cars.ToList();
            return arac;
        }

        // GET api/<ValuesController>/5
        [HttpGet("{id}")]
        public Arac Get(int id)
        {
            var arac = db.Cars.FirstOrDefault(s => s.AracID==id);
            return arac;
        }

        // POST api/<ValuesController>
        [HttpPost]
        public ActionResult Post([FromBody] Arac a)
        {
            var arac = new Arac() { Model = a.Model, Fiyat = a.Fiyat };
            db.Cars.Add(arac);
            db.SaveChanges();
            return CreatedAtAction("Get", new { a.AracID }, arac);

        }

        // PUT api/<ValuesController>/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] Arac a)
        {
            var arac = db.Cars.FirstOrDefault(x => x.AracID == id);
            if(arac is null)
            {
                return NotFound();
            }
            else
            {
                arac.Model = a.Model;
                arac.Fiyat = a.Fiyat;
                db.SaveChanges();
                return Ok();
            }
        }

        // DELETE api/<ValuesController>/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            var arac = db.Cars.FirstOrDefault(x => x.AracID == id);
            if (arac is null)
            {
                return NotFound();
            }
            else
            {
                db.Cars.Remove(arac);
                db.SaveChanges();
                return Ok();
            }
        }
    }
}
