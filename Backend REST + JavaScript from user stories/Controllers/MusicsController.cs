using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Backend_REST___JavaScript_from_user_stories.Managers;
using Backend_REST___JavaScript_from_user_stories.Model;
using Microsoft.AspNetCore.Http;

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
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        public ActionResult<IEnumerable<MusicRecords>> GetAll([FromQuery] string title, [FromQuery] string artist,
            [FromQuery] string sortBy)
        {
            var musicRecordsList = _musicRecordManagers.GetAll(title, artist, sortBy);
            if (musicRecordsList.Count == 0)
            {
                return NoContent();
            }

            return Ok(musicRecordsList);
        }

        // GET api/<MusicsController>/5
        [HttpGet("{title}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult<MusicRecords> GetByTilte(string title)
        {
            var musicRecords = _musicRecordManagers.GetByTitle(title);
            if (musicRecords == null)
            {
                return NotFound();
            }

            return Ok(musicRecords);
        }

        //POST api/<MusicsController>
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status200OK)]

        public ActionResult<MusicRecords> Post([FromBody] MusicRecords value)
        {
            return Ok(_musicRecordManagers.Add(value));
        }

        // PUT api/<MusicsController>/5
        [HttpPut("{title}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult <MusicRecords> Put(string title, [FromBody] MusicRecords value)
        {
            var musicRecords = _musicRecordManagers.Update(title, value);
            if (musicRecords == null)
            {
                return NotFound();
            }
            return Ok( musicRecords);
        }

        // DELETE api/<MusicsController>/5
        [HttpDelete("{title}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult <MusicRecords> Delete(string title)
        {
            var musicRecords = _musicRecordManagers.Delete(title);
            if (musicRecords == null)
            {
                return NotFound();
            }
            return Ok( musicRecords);
        }        
    }
}