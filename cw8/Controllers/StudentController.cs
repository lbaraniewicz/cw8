using cw8.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System.Net.Http.Json;
using System.Text.Json.Serialization;

namespace cw8.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var context = new MainDbContext();
            var studiaStudenta = context.Studia
                .Include(s => s.Student)
                .Where(s => s.IdStudent == id)
                .Select(st => new
                {
                    Imie = st.Student.Imie,
                    Nazwisko = st.Student.Nazwisko,
                    Studia = st.Nazwa

                }).ToList();
            return Ok(JsonConvert.SerializeObject(studiaStudenta));
        }
    }
}
