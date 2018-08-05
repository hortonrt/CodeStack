﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CodeStack.Data.Models;
using CodeStack.Data.Models.Navigation;
using Microsoft.AspNetCore.Mvc;

namespace CodeStack.WebAPI.Controllers {
    [Route("api/[controller]")]
    [ApiController]
    public class OptionsController : ControllerBase {
        private readonly CodeStackContext _context;
        // initiate database context  
        public OptionsController(CodeStackContext context) {
            _context = context;
        }

        [HttpGet("Routes")]
        public IActionResult Routes() {
            try {
                var routes = new Route(_context).Get();
                if (routes == null) return NotFound("No Routes Found");
                return Ok(routes);
            } catch (Exception ex) {
                return BadRequest("Could not get routes: " + ex.Message.ToString());
            }
        }
    }
}