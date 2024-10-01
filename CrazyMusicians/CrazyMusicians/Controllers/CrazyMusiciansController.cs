using CrazyMusicians.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CrazyMusicians.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CrazyMusiciansController : ControllerBase
    {
        static List<MusicianEntity> _crazyMusicians = new List<MusicianEntity>()
        {
            new MusicianEntity{ Id = 1, FullName = "Ahmet Instrument", Profession = "Famous Musical Instrument Player", EntertainingTrait = "Always hits the wrong note, but it's so much fun" },
            new MusicianEntity{ Id = 2, FullName = "Zeynep Melody", Profession = "Popular Melody Writer", EntertainingTrait = "Their songs are misunderstood but very popular" },
            new MusicianEntity{ Id = 3, FullName = "Cemil Chord", Profession = "Crazy Tuner", EntertainingTrait = "He changes the chords frequently,  but he is surprisingly talented." },
            new MusicianEntity{ Id = 4, FullName = "Fatma Note", Profession = "Surprise Note Producer", EntertainingTrait = "Constantly prepares surprises while composing notes" },
            new MusicianEntity{ Id = 5, FullName = "Hasan Rhythm", Profession = "Rhythm Beast", EntertainingTrait = "Creates rhythms in his own style, never fitting, but quite funny" },
            new MusicianEntity{ Id = 6, FullName = "Elif Harmony", Profession = "Harmony Master", EntertainingTrait = "Occasionally plays wrong harmonies, but is extremely creative" },
            new MusicianEntity{ Id = 7, FullName = "Ali Curtain", Profession = "Curtain Technician", EntertainingTrait = "Plays every chord differently, always a surprise" },
            new MusicianEntity{ Id = 8, FullName = "Ayse Resonance", Profession = "Resonance Expert", EntertainingTrait = "An expert in resonance, but sometimes too loud" },
            new MusicianEntity{ Id = 9, FullName = "Murat Tone", Profession = "Tone Enthusiast", EntertainingTrait = "Variations in tonality are amusing, but very interesting" },
            new MusicianEntity{ Id = 10, FullName = "Selin Chord", Profession = "Chord Magician", EntertainingTrait = "Creates a magical atmosphere when changing chords occasionally" },
        };

        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_crazyMusicians);
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var musician = _crazyMusicians.FirstOrDefault(x => x.Id == id);
            if(musician is null)
                return NotFound();
            return Ok(musician);
        }

        [HttpPost]
        public IActionResult Post([FromBody] MusicianEntity request)
        {
            var id = _crazyMusicians.Max(x => x.Id) + 1;
            request.Id = id;
            _crazyMusicians.Add(request);

            return CreatedAtAction(nameof(Get), new {id = request.Id}, request );
            // return Ok() --> StatusCode(200) -> işlem başarılı.
            // return Created() --> StatusCode(201) -> Ekleme yapıldı.
            // return CreatedAtAction() --> StatusCode(201) -> Ekleme yapıldı ve eklenen yapıyı getirir.
        }

        [HttpPatch("{id}")]
        public IActionResult Patch(int id, [FromBody] MusicianEntity request)
        {
            var musician = _crazyMusicians.FirstOrDefault(x => x.Id == id);
            if (musician == null)
                return NotFound();

            musician.EntertainingTrait = request.EntertainingTrait;

            return Ok(musician);
        }

        [HttpGet("search")]
        public IActionResult Search([FromQuery] string name)
        {
            var musician = _crazyMusicians.Where(x => x.FullName.ToLower().Contains(name.ToLower())).ToList();

            if (musician.Count == 0)
                return NotFound();


            return Ok(musician);
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] MusicianEntity request)
        {
            if (request is null || id != request.Id)
                return BadRequest();

            var musician = _crazyMusicians.FirstOrDefault(x => x.Id == id);

            if (musician is null)
                return NotFound();

            musician.FullName = request.FullName;
            musician.Profession = request.Profession;
            musician.EntertainingTrait = musician.EntertainingTrait;
            return Ok(musician);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var musician = _crazyMusicians.FirstOrDefault(x => x.Id == id);
            if (musician == null) 
                return NotFound();

            musician.IsDeleted = true;


            return Ok(musician);
        }

    }
}
