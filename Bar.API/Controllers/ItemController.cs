﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Bar.API.Controllers.Repository;
using Bar.Database.Entities;
using Bar.Infrastructure.Interfaces;
using Bar.Infrastructure.Repository;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Bar.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize(AuthenticationSchemes = scheme)]
    public class ItemController : BaseCrudController<Item, Item, Item, Item>
    {
        private readonly IItem _service;
        private const string scheme = "BasicAuthentication";
        public ItemController(IItem service) : base(service)
        {
            _service = service;
        }
        [HttpGet]
        public override async Task<List<Item>> Get([FromQuery] Item obj = null)
        {
            var result = await _service.Get(obj);
            return result;
        }
    }
}