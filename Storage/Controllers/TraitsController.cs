using CharacterStorage.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace CharacterStorage.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TraitsController : ControllerBase
    {
        private CharacterStorageContext _db;

        public TraitsController(CharacterStorageContext db)
        {
            _db = db;
        }

        // GET api/Trait
        [HttpGet]
        public ActionResult<IEnumerable<Trait>> Get(string name, int id, string bio, string faction, int minLevel, int maxLevel, int minMight, int maxMight, int minSpryness, int maxSpryness, int minJudgement, int maxJudgement, int minEcho, int maxEcho, int minMagnetism, int maxMagnetism, int minFortune, int maxFortune)
        {
            var query = _db.Traits.AsQueryable();

            if (name != null) query = query.Where(entry => entry.Name == name);
            if (faction != null) query = query.Where(entry => entry.Name == faction);
            if (id > 0) query = query.Where(entry => entry.TraitId == id);
            if (minMight > 0) query = query.Where(entry => entry.Might >= minMight);
            if (maxMight > 0) query = query.Where(entry => entry.Might <= maxMight);            
            if (minSpryness > 0) query = query.Where(entry => entry.Spryness >= minSpryness);
            if (maxSpryness > 0) query = query.Where(entry => entry.Spryness <= maxSpryness);
            if (minJudgement > 0) query = query.Where(entry => entry.Judgement >= minJudgement);
            if (maxJudgement > 0) query = query.Where(entry => entry.Judgement <= maxJudgement);
            if (minEcho > 0) query = query.Where(entry => entry.Echo >= minEcho);
            if (maxEcho > 0) query = query.Where(entry => entry.Echo <= maxEcho);
            if (minMagnetism > 0) query = query.Where(entry => entry.Magnetism >= minMagnetism);
            if (maxMagnetism > 0) query = query.Where(entry => entry.Magnetism <= maxMagnetism);
            if (minFortune > 0) query = query.Where(entry => entry.Fortune >= minFortune);
            if (maxFortune > 0) query = query.Where(entry => entry.Fortune <= maxFortune);
            
            return query.ToList();
        }

        // GET api/Trait/{id}
        [HttpGet("{id}")]
        public ActionResult<Trait> Get(int id)
        {
            return _db.Traits.FirstOrDefault(entry => entry.TraitId == id);
        }

        // POST api/Trait
        [HttpPost /*, ActionName("PostSingle") */ ]
        public void Post([FromBody] Trait Trait)
        {
            _db.Traits.Add(Trait);
            _db.SaveChanges();
        }

        // [HttpPost, ActionName("PostArray")]
        // public void Post([FromBody] Trait[] Trait)
        // {
        //     foreach (Trait Trait in Trait)
        //     {
        //         _db.Trait.Add(Trait);
        //     }
        //     _db.SaveChanges();
        // }

        //PUT api/Trait/{id}
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Trait Trait)
        {
            Trait.TraitId = id;
            _db.Entry(Trait).State = EntityState.Modified;
            _db.SaveChanges();
        }

        //DELETE api/Trait/{id}
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var TraitToDelete = _db.Traits.FirstOrDefault(entry => entry.TraitId == id);
            _db.Traits.Remove(TraitToDelete);
            _db.SaveChanges();
        }
    }
}