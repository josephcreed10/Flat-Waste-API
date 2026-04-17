using FlatWaste.Models.DTOs;
using Microsoft.AspNetCore.Mvc;
using System.Reflection.Metadata.Ecma335;

namespace FlatWaste.Controllers
{
    [ApiController]
    [Route("api/duty")]
    public class DutyScheduleController : ControllerBase
    {
        [HttpGet]
        public ActionResult GetDuties()
        {
            return Ok();
        }
        [HttpGet("{id:int}")]
        public ActionResult GetDutyById(int id)
        {
            return Ok();
        }
        [HttpGet("user/{userId:int}")]
        public ActionResult GetDutyByUserId(int userId)
        {
            return Ok();
        }
        [HttpPost]
        public ActionResult CreateDuty(DutyScheduleCreateDTO duty)
        {
            return Ok();
        }
        [HttpPut("{id:int}")]
        public ActionResult MarkAsCompleted(int id)
        {
            return Ok();
        }
    }
}
