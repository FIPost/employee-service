﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using personeel_service.Models;
using personeel_service.Services;

namespace personeel_service.Controllers
{
    [Route("api/persons")]
    [ApiController]
    public class PersonController : Controller
    {

        private readonly IPersonService _service;

        public PersonController(IPersonService service)
        {
            _service = service;
        }

        // GET: api/Persons
        [HttpGet]
        public ActionResult<IEnumerable<Person>> GetPerson()
        {
            return _service.GetAll();
        }

        // GET: api/Persons/5
        [HttpGet("{id}")]
        public ActionResult<Person> GetPerson(string id)
        {
            try
            {
                return _service.GetById(id);
            }
            catch(Exception e)
            {
                return NotFound(e.Message);
            }
        }

        // GET: api/Persons
        [HttpGet]
        [Route("health")]
        public ActionResult Health()
        {
            return Ok();
        }
    }
}
