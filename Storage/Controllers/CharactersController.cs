using CharacterStorage.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace CharacterStorage.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CharactersController : ControllerBase
    {
        private CharacterStorageContext _db;

        public CharactersController(CharacterStorageContext db)
        {
            _db = db;
        }

        // GET api/Characters
        [HttpGet]
        public ActionResult<IEnumerable<Character>> Get(string name, int id, string bio, string faction, int minLevel, int maxLevel, int minMight, int maxMight, int minSpryness, int maxSpryness, int minJudgement, int maxJudgement, int minEcho, int maxEcho, int minMagnetism, int maxMagnetism, int minFortune, int maxFortune)
        {
            var query = _db.Characters.AsQueryable();

            if (name != null) query = query.Where(entry => entry.Name == name);
            if (faction != null) query = query.Where(entry => entry.Name == faction);
            if (bio != null) query = query.Where(entry => entry.Bio.Contains(bio));
            if (id > 0) query = query.Where(entry => entry.CharacterId == id);
            if (minLevel > 0) query = query.Where(entry => entry.Level >= minLevel);
            if (maxLevel > 0) query = query.Where(entry => entry.Level <= maxLevel); 
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

        // GET api/Characters/{id}
        [HttpGet("{id}")]
        public ActionResult<Character> Get(int id)
        {
            return _db.Characters.FirstOrDefault(entry => entry.CharacterId == id);
        }

        // POST api/Characters
        [HttpPost /*, ActionName("PostSingle") */ ]
        public void Post([FromBody] Character Character)
        {
            _db.Characters.Add(Character);
            _db.SaveChanges();
        }

        // [HttpPost, ActionName("PostArray")]
        // public void Post([FromBody] Character[] Characters)
        // {
        //     foreach (Character Character in Characters)
        //     {
        //         _db.Characters.Add(Character);
        //     }
        //     _db.SaveChanges();
        // }

        //PUT api/Characters/{id}
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Character Character)
        {
            Character.CharacterId = id;
            _db.Entry(Character).State = EntityState.Modified;
            _db.SaveChanges();
        }

        //DELETE api/Characters/{id}
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var CharacterToDelete = _db.Characters.FirstOrDefault(entry => entry.CharacterId == id);
            _db.Characters.Remove(CharacterToDelete);
            _db.SaveChanges();
        }
    }
}