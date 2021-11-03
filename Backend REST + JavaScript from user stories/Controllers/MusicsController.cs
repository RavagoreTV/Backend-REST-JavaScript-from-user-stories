using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Backend_REST___JavaScript_from_user_stories.Managers;
using Backend_REST___JavaScript_from_user_stories.Model;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Backend_REST___JavaScript_from_user_stories.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MusicsController : ControllerBase
    {
        private readonly MusicRecordManagers _musicRecordManagers = new MusicRecordManagers();
        // GET: api/<MusicsController>
        [HttpGet]
        public IEnumerable<MusicRecords> GetAll([FromQuery] string title, [FromQuery] string artist, [FromQuery] string sortBy)
        {
            return _musicRecordManagers.GetAll(title, artist, sortBy);
        }

        // GET api/<MusicsController>/5
        [HttpGet("{title}")]
        public MusicRecords GetByTilte(string title)
        {
            return _musicRecordManagers.GetByTitle(title);
        }

        //POST api/<MusicsController>
        [HttpPost]
        public MusicRecords Post([FromBody] MusicRecords value)
        {
            return _musicRecordManagers.Add(value);
        }

        // PUT api/<MusicsController>/5
        [HttpPut("{title}")]
        public MusicRecords Put(string title, [FromBody] MusicRecords value)
        {
            return _musicRecordManagers.Update(title, value);
        }

        // DELETE api/<MusicsController>/5
        [HttpDelete("{title}")]
        public MusicRecords Delete(string title)
        {
            return _musicRecordManagers.Delete(title);
        }        
    }
}