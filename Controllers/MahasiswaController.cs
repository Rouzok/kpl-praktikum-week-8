using Microsoft.AspNetCore.Mvc;
using tpmodul9_103082400009.Models;

namespace tpmodul9_103082400009.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MahasiswaController : ControllerBase
    {
        private static List<Mahasiswa> dataMahasiswa = new List<Mahasiswa>
        {
            new Mahasiswa { nama = "Akhmad Alvan Hani", nim = "103082400009" },
            new Mahasiswa { nama = "Amelia Amanda", nim = "103082400039" },
            new Mahasiswa { nama = "Miratun Nisa", nim = "103082400001" },
            new Mahasiswa { nama = "Debby Tampubolon", nim = "103082400029" }
        };

        [HttpGet]
        public IEnumerable<Mahasiswa> Get()
        {
            return dataMahasiswa;
        }

        [HttpGet("{id}")]
        public Mahasiswa Get(int id)
        {
            return dataMahasiswa[id];
        }

        [HttpPost]
        public void Post([FromBody] Mahasiswa mahasiswaBaru)
        {
            dataMahasiswa.Add(mahasiswaBaru);
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            dataMahasiswa.RemoveAt(id);
        }
    }
}
